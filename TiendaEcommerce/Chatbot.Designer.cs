namespace TiendaEcommerce
{
    partial class Chatbot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtChat = new RichTextBox();
            btnEnviar = new Button();
            userInput = new TextBox();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.Location = new Point(12, 12);
            txtChat.Name = "txtChat";
            txtChat.ReadOnly = true;
            txtChat.Size = new Size(494, 281);
            txtChat.TabIndex = 0;
            txtChat.Text = "";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(303, 384);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(155, 29);
            btnEnviar.TabIndex = 1;
            btnEnviar.Text = "Enviar mensaje";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnenviar_Click;
            // 
            // userInput
            // 
            userInput.Location = new Point(39, 308);
            userInput.Multiline = true;
            userInput.Name = "userInput";
            userInput.Size = new Size(419, 60);
            userInput.TabIndex = 2;
            // 
            // Chatbot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 450);
            Controls.Add(userInput);
            Controls.Add(btnEnviar);
            Controls.Add(txtChat);
            Name = "Chatbot";
            Text = "Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox txtChat;
        private Button btnEnviar;
        private TextBox userInput;
    }
}