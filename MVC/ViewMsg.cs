using WalkTalk.MVC;

namespace WalkTalk
{
    public partial class ViewMsg : Form, IViewMsg
    {
        ControllerMsg controller;
        public ViewMsg()
        {
            EscolherUser home = new EscolherUser();
            home.ShowDialog();
            InitializeComponent();
        }
        public void SetController(ControllerMsg controller)
        {
            this.controller = controller;
        }

        private void Enviar(object sender, EventArgs e)
        {
             controller.EnviarMsg();
            //richAllMsg.Visible = true;
            //ofd1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            //ofd1.Multiselect = false;
            //ofd1.FileName = "";
            //DialogResult resultado = ofd1.ShowDialog();
            //if (resultado == DialogResult.OK)
            //{
            //    Image img = Image.FromFile(ofd1.FileName);
            //    Clipboard.SetImage(img);
            //    richAllMsg.Paste();
            //    richAllMsg.Focus();
            //}
        }

        private void EscolheUser(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                controller.SeleiconaContato(dataGridUsers.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
        }

        private void richAllMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnexarImg(object sender, EventArgs e)
        {
            controller.SelecionaImg();
        }

        public RichTextBox Allmsg
        {
            get
            {
                return richAllMsg;
            }
            set
            {
                richAllMsg = value;
            }
        }
        public TextBox UserText
        {
            get
            {
                return textInf;
            }
            set
            {
                textInf = value;
            }
        }
        public DataGridView GridUser
        {
            get
            {
                return dataGridUsers;
            }
            set
            {
                dataGridUsers = value;
            }
        }
        public OpenFileDialog File
        {
            get
            {
                return opf;
            }
            set
            {
                opf = value;
            }
        }

    }
}
