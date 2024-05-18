﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk
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
            modelmsg.RecebeMensagens();
            CarregaMensagens();
            modelmsg.NovaMsg();
            old_id = modelmsg.Id;
           CheckMsg();
        }

        public void EnviarMsg()
        {
            if (!string.IsNullOrEmpty(viewmsg.UserText.Text))
            {
                    modelmsg.Env(Usuario.id_us, Usuario.id_des,viewmsg.UserText.Text);
                    viewmsg.UserText.Clear();    
            }
            else
            {
                MessageBox.Show("É necessário escrever algo na mensagem");
            }
        }

        public void CarregaMensagens()
        {
            viewmsg.Allmsg.Clear();
            foreach(Mensagem obj in modelmsg.Histlist)
            {
                if (obj.Id_rem == Usuario.id_us)
                {
                    int start = viewmsg.Allmsg.TextLength;
                    string formattedMessage = $"{obj.Name_r}      \n {obj.Msg}\n{obj.Date}\n" + Environment.NewLine;
                    viewmsg.Allmsg.AppendText(formattedMessage);

                    // Seleciona o texto recém-adicionado
                    viewmsg.Allmsg.Select(start, formattedMessage.Length);
                    viewmsg.Allmsg.SelectionAlignment = HorizontalAlignment.Right;
                }
                else
                {
                    int start = viewmsg.Allmsg.TextLength;
                    string formattedMessage = $"{obj.Name_r}      \n {obj.Msg}\n{obj.Date}\n" + Environment.NewLine;
                    viewmsg.Allmsg.AppendText(formattedMessage);

                    // Seleciona o texto recém-adicionado
                    viewmsg.Allmsg.Select(start, formattedMessage.Length);
                    viewmsg.Allmsg.SelectionAlignment = HorizontalAlignment.Left;
                }
                viewmsg.Allmsg.SelectionStart = viewmsg.Allmsg.Text.Length;
                viewmsg.Allmsg.SelectionLength = 0;
                viewmsg.Allmsg.ScrollToCaret();
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
