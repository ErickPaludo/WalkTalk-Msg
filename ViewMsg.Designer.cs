namespace WalkTalk
{
    partial class ViewMsg
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMsg));
            richAllMsg = new RichTextBox();
            textInf = new TextBox();
            bEnv = new Button();
            SuspendLayout();
            // 
            // richAllMsg
            // 
            richAllMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richAllMsg.BackColor = Color.FromArgb(64, 64, 64);
            richAllMsg.BorderStyle = BorderStyle.None;
            richAllMsg.ForeColor = SystemColors.Window;
            richAllMsg.ImeMode = ImeMode.Off;
            richAllMsg.Location = new Point(12, 12);
            richAllMsg.Name = "richAllMsg";
            richAllMsg.ReadOnly = true;
            richAllMsg.Size = new Size(607, 359);
            richAllMsg.TabIndex = 0;
            richAllMsg.Text = "";
            // 
            // textInf
            // 
            textInf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textInf.BackColor = Color.FromArgb(64, 64, 64);
            textInf.BorderStyle = BorderStyle.FixedSingle;
            textInf.ForeColor = SystemColors.Menu;
            textInf.Location = new Point(12, 382);
            textInf.Multiline = true;
            textInf.Name = "textInf";
            textInf.Size = new Size(518, 42);
            textInf.TabIndex = 1;
            // 
            // bEnv
            // 
            bEnv.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bEnv.BackColor = Color.FromArgb(64, 64, 64);
            bEnv.FlatStyle = FlatStyle.Popup;
            bEnv.ForeColor = SystemColors.ButtonHighlight;
            bEnv.Location = new Point(536, 382);
            bEnv.Name = "bEnv";
            bEnv.Size = new Size(83, 42);
            bEnv.TabIndex = 2;
            bEnv.Text = "Enviar";
            bEnv.UseVisualStyleBackColor = false;
            bEnv.Click += Enviar;
            // 
            // ViewMsg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(632, 450);
            Controls.Add(bEnv);
            Controls.Add(textInf);
            Controls.Add(richAllMsg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewMsg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WallTalkMsg";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richAllMsg;
        private TextBox textInf;
        private Button bEnv;
    }
}
