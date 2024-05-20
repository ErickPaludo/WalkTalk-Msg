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
        }

        private void dataGridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

    }
}
