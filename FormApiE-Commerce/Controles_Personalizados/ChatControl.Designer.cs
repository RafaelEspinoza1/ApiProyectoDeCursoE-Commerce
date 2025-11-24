namespace FormApiE_Commerce.Controles_Personalizados
{
    partial class ChatControl
    {
        private System.ComponentModel.IContainer components = null;

        private FlowLayoutPanel flowPanel;
        private RoundedRichTextBox richMsg;
        private Button btnEnviar;
       
        

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.flowPanel = new FlowLayoutPanel();
            this.richMsg = new RoundedRichTextBox();
            this.btnEnviar = new Button();

            // flowPanel
            this.flowPanel.Dock = DockStyle.Top;
            this.flowPanel.AutoScroll = true;
            this.flowPanel.FlowDirection = FlowDirection.TopDown;
            this.flowPanel.WrapContents = false;
            this.flowPanel.Height = 320;
            this.flowPanel.Padding = new Padding(5);

            // richMsg
            this.richMsg.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            this.richMsg.BorderRadius = 15;
            this.richMsg.BorderColor = Color.Gray;
            this.richMsg.BorderSize = 1;
            this.richMsg.Height = 50;
            this.richMsg.Width = 300;
            this.richMsg.Location = new Point(10, 330);

            // btnEnviar
            this.btnEnviar.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
            this.btnEnviar.Text = "➤";
            this.btnEnviar.Width = 40;
            this.btnEnviar.Height = 40;
            this.btnEnviar.Location = new Point(320, 335);
            this.btnEnviar.Click += new EventHandler(this.btnEnviar_Click);

            // ChatControl
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.richMsg);
            this.Controls.Add(this.btnEnviar);
            this.Name = "ChatControl";
            this.Size = new Size(380, 380);
        }    
    }
}
