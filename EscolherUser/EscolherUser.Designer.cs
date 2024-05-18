namespace WalkTalk
{
    partial class EscolherUser
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
            init = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // init
            // 
            init.Location = new Point(113, 65);
            init.Name = "init";
            init.Size = new Size(75, 23);
            init.TabIndex = 0;
            init.Text = "Entrar";
            init.UseVisualStyleBackColor = true;
            init.Click += init_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "User 1", "User 2" });
            comboBox1.Location = new Point(88, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // EscolherUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 180);
            Controls.Add(comboBox1);
            Controls.Add(init);
            Name = "EscolherUser";
            Text = "EscolherUser";
            ResumeLayout(false);
        }

        #endregion

        private Button init;
        private ComboBox comboBox1;
    }
}