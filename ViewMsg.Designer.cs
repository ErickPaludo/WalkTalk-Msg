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
            label1 = new Label();
            lDestinatario = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridUsers).BeginInit();
            SuspendLayout();
            // 
            // richAllMsg
            // 
            richAllMsg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richAllMsg.BackColor = Color.WhiteSmoke;
            richAllMsg.BorderStyle = BorderStyle.FixedSingle;
            richAllMsg.ForeColor = Color.Black;
            richAllMsg.ImeMode = ImeMode.Off;
            richAllMsg.Location = new Point(303, 12);
            richAllMsg.Name = "richAllMsg";
            richAllMsg.ReadOnly = true;
            richAllMsg.Size = new Size(705, 377);
            richAllMsg.TabIndex = 0;
            richAllMsg.Text = "";
            // 
            // textInf
            // 
            textInf.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textInf.BackColor = Color.WhiteSmoke;
            textInf.BorderStyle = BorderStyle.FixedSingle;
            textInf.ForeColor = SystemColors.InactiveCaptionText;
            textInf.Location = new Point(302, 414);
            textInf.Multiline = true;
            textInf.Name = "textInf";
            textInf.Size = new Size(616, 42);
            textInf.TabIndex = 1;
            // 
            // bEnv
            // 
            bEnv.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            bEnv.BackColor = Color.WhiteSmoke;
            bEnv.FlatStyle = FlatStyle.Popup;
            bEnv.ForeColor = SystemColors.ActiveCaptionText;
            bEnv.Location = new Point(925, 414);
            bEnv.Name = "bEnv";
            bEnv.Size = new Size(83, 42);
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
            dataGridUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridUsers.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridUsers.BorderStyle = BorderStyle.None;
            dataGridUsers.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsers.ColumnHeadersVisible = false;
            dataGridUsers.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridUsers.Cursor = Cursors.Hand;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridUsers.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridUsers.GridColor = Color.FromArgb(128, 128, 255);
            dataGridUsers.Location = new Point(12, 12);
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
            dataGridUsers.Size = new Size(284, 430);
            dataGridUsers.TabIndex = 0;
            dataGridUsers.CellClick += EscolheUser;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(303, 392);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 4;
            label1.Text = "Você está conversando com: ";
            // 
            // lDestinatario
            // 
            lDestinatario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lDestinatario.AutoSize = true;
            lDestinatario.ForeColor = SystemColors.ActiveCaptionText;
            lDestinatario.Location = new Point(469, 392);
            lDestinatario.Name = "lDestinatario";
            lDestinatario.Size = new Size(0, 15);
            lDestinatario.TabIndex = 5;
            // 
            // ViewMsg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1020, 468);
            Controls.Add(lDestinatario);
            Controls.Add(label1);
            Controls.Add(dataGridUsers);
            Controls.Add(bEnv);
            Controls.Add(textInf);
            Controls.Add(richAllMsg);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Label label1;
        private Label lDestinatario;
    }
}
