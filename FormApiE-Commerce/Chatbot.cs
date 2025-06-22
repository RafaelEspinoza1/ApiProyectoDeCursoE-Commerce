using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApiE_Commerce
{
    public partial class Chatbot : Form
    {
        private static readonly string endpoint = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=AIzaSyA6C5f3Tp53hFwIXTw9jWa8EFbEXcIuyaY";
        private static readonly HttpClient httpClient = new HttpClient();

        private List<string> chatHistory = new List<string>();
        public Chatbot()
        {
            InitializeComponent();
            txtChat.ReadOnly = true;
            txtChat.AppendText("🤖 Asistente de soporte e-commerce iniciado.\n\n");
            chatHistory.Add("Eres un asistente de soporte de una tienda e-commerce. Usa frases cortas. responde solo lo nesesario. ayudas con pedidos , devoluciones y pagos. ");
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0");

        }


        
        

        private async void btnenviar_Click(object sender, EventArgs e)
        {
            string userInpute = userInput.Text.Trim();
            if (string.IsNullOrEmpty(userInpute)) return;

            txtChat.AppendText($"🧑 Tú: {userInput}\n");
            chatHistory.Add($"Usuario: {userInput}");
            userInput.Clear();

            string respuesta = await EnviarMensajeAGemini();
            txtChat.AppendText($"🤖 Bot: {respuesta}\n\n");
            chatHistory.Add($"Asistente: {respuesta}");
        }


        private async Task<string> EnviarMensajeAGemini()
        {
            var conversation = string.Join("\n", chatHistory);

            var requestData = new
            {
                contents = new[]
                {
            new
            {
                parts = new[]
                {
                    new { text = conversation }
                }
            }
        }
            };

            var json = JsonConvert.SerializeObject(requestData);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await httpClient.PostAsync(endpoint, content);
                var responseJson = await response.Content.ReadAsStringAsync();

                // Verifica si hay errores
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Error de API:\n" + responseJson, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "[Error de API]";
                }

                var jObject = JObject.Parse(responseJson);
                var text = jObject["candidates"]?[0]?["content"]?["parts"]?[0]?["text"]?.ToString();

                return text ?? "[Sin respuesta del modelo]";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excepción: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "[Error de red o formato]";
            }
        }
    }
}
