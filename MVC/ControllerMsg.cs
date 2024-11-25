using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalkTalk.Entity;

namespace WalkTalk.MVC
{
    public class ControllerMsg
    {
        IViewMsg viewmsg;
        ModelMsg modelmsg;
        Mensagem msg = new Mensagem();
        static int old_id;

        public ControllerMsg()
        {
        }

        public ControllerMsg(IViewMsg viewmsg, ModelMsg modelmsg)
        {
            this.viewmsg = viewmsg;
            this.modelmsg = modelmsg;
            viewmsg.SetController(this);
            modelmsg.CarregaContatos();
            CarregaContatos();
        }

        public void EnviarMsg()
        {
            if (!string.IsNullOrEmpty(viewmsg.UserText.Text))
            {
                modelmsg.Env(Usuario.id_us, Usuario.id_des, viewmsg.UserText.Text);
                viewmsg.UserText.Clear();
            }
            else
            {
                MessageBox.Show("É necessário escrever algo na mensagem");
            }
        }
        public void SelecionaImg()
        {
            viewmsg.File.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            viewmsg.File.Multiselect = false;
            viewmsg.File.FileName = "";
            DialogResult resultado = viewmsg.File.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                byte[] imageBytes = File.ReadAllBytes(viewmsg.File.FileName);
                string base64String = $"IMG^{Convert.ToBase64String(imageBytes)}";
                Image img = Image.FromFile(viewmsg.File.FileName);
                Clipboard.SetImage(img);
                viewmsg.Allmsg.Paste();
                viewmsg.Allmsg.Focus();
                modelmsg.Env(Usuario.id_us, Usuario.id_des, base64String);
            }
            

        }
        public void CarregaMensagens()
        {
            viewmsg.Allmsg.Clear();
            foreach (Mensagem obj in modelmsg.Histlist)
            {
                int start = viewmsg.Allmsg.TextLength;
                string formattedMessage = $"{(obj.Nome_remetente.Split('^')[0] == Usuario.id_us ? obj.Nome_remetente.Split('^')[1] : obj.Nome_dest.Split('^')[1])}      \n {obj.Msg}\n{obj.Date}\n" + Environment.NewLine; ;
                viewmsg.Allmsg.AppendText(formattedMessage);
                if (obj.Nome_remetente.Split('^')[0] == Usuario.id_us)
                {
                    viewmsg.Allmsg.Select(start, formattedMessage.Length);
                    viewmsg.Allmsg.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    viewmsg.Allmsg.Select(start, formattedMessage.Length);
                    viewmsg.Allmsg.SelectionAlignment = HorizontalAlignment.Left;
                }
                viewmsg.Allmsg.SelectionStart = viewmsg.Allmsg.Text.Length;
                viewmsg.Allmsg.SelectionLength = 0;
                viewmsg.Allmsg.ScrollToCaret();
            }

        }

        public void SeleiconaContato(string us)
        {
            modelmsg.SetDestinoId(us);
            modelmsg.RecebeMensagens();
            CarregaMensagens();
            modelmsg.NovaMsg();
            old_id = modelmsg.Id;
            CheckMsg();
        }

        public void CarregaContatos()
        {
            foreach (Contatos obj in modelmsg.Contatos)
            {
                viewmsg.GridUser.Rows.Add(obj.Usuario);
            }
        }

        public async Task CheckMsg()
        {
            while (true)
            {
                modelmsg.NovaMsg();
                if (modelmsg.Id != old_id)
                {
                    modelmsg.Histlist.Clear();
                    modelmsg.RecebeMensagens();
                    CarregaMensagens();
                    old_id = modelmsg.Id;
                }
                await Task.Delay(1000);
            }
        }
    }
}
