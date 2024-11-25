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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMsg));
            richAllMsg = new RichTextBox();
            textInf = new TextBox();
            bEnv = new Button();
            dataGridUsers = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            opf = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // richAllMsg
            // 
            richAllMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richAllMsg.BackColor = Color.FromArgb(64, 64, 64);
            richAllMsg.BorderStyle = BorderStyle.None;
            richAllMsg.ForeColor = SystemColors.Window;
            richAllMsg.ImeMode = ImeMode.Off;
            richAllMsg.Location = new Point(345, 16);
            richAllMsg.Margin = new Padding(3, 4, 3, 4);
            richAllMsg.Name = "richAllMsg";
            richAllMsg.ReadOnly = true;
            richAllMsg.Size = new Size(806, 479);
            richAllMsg.TabIndex = 0;
            richAllMsg.Text = "";
            richAllMsg.TextChanged += richAllMsg_TextChanged;
            // 
            // textInf
            // 
            textInf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textInf.BackColor = Color.FromArgb(64, 64, 64);
            textInf.BorderStyle = BorderStyle.FixedSingle;
            textInf.ForeColor = SystemColors.Menu;
            textInf.Location = new Point(345, 509);
            textInf.Margin = new Padding(3, 4, 3, 4);
            textInf.Multiline = true;
            textInf.Name = "textInf";
            textInf.Size = new Size(705, 55);
            textInf.TabIndex = 1;
            // 
            // bEnv
            // 
            bEnv.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bEnv.BackColor = Color.FromArgb(64, 64, 64);
            bEnv.FlatStyle = FlatStyle.Popup;
            bEnv.ForeColor = SystemColors.ButtonHighlight;
            bEnv.Location = new Point(1056, 509);
            bEnv.Margin = new Padding(3, 4, 3, 4);
            bEnv.Name = "bEnv";
            bEnv.Size = new Size(95, 56);
            bEnv.TabIndex = 2;
            bEnv.Text = "Enviar";
            bEnv.UseVisualStyleBackColor = false;
            bEnv.Click += Enviar;
            // 
            // dataGridUsers
            // 
            dataGridUsers.AllowUserToAddRows = false;
            dataGridUsers.AllowUserToDeleteRows = false;
            dataGridUsers.AllowUserToResizeColumns = false;
            dataGridUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridUsers.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridUsers.BorderStyle = BorderStyle.None;
            dataGridUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.ColumnHeadersVisible = false;
            dataGridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridUsers.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridUsers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridUsers.Location = new Point(14, 16);
            dataGridUsers.Margin = new Padding(3, 4, 3, 4);
            dataGridUsers.Name = "dataGridUsers";
            dataGridUsers.ReadOnly = true;
            dataGridUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridUsers.RowHeadersVisible = false;
            dataGridUsers.RowTemplate.Height = 50;
            dataGridUsers.Size = new Size(325, 549);
            dataGridUsers.TabIndex = 3;
            dataGridUsers.CellClick += EscolheUser;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1056, 509);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(95, 56);
            button1.TabIndex = 4;
            button1.Text = "Anexo";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += AnexarImg;
            // 
            // opf
            // 
            opf.FileName = "openFileDialog1";
            // 
            // ViewMsg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1166, 600);
            Controls.Add(button1);
            Controls.Add(dataGridUsers);
            Controls.Add(bEnv);
            Controls.Add(textInf);
            Controls.Add(richAllMsg);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "ViewMsg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WallTalkMsg";
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richAllMsg;
        private TextBox textInf;
        private Button bEnv;
        private DataGridView dataGridUsers;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private OpenFileDialog opf;
    }
}
