using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk
{
    public class Mensagem
    {
        private int id;
        private string nome_remetente,nome_dest;
        private string msg;
        private DateTime date;
        public int Id
        {
            get
            {
            return id;
            }
            set
            {
            id = value; 
            }
        }
        public string Nome_remetente
        {
            get
            {
                return nome_remetente;
            }
            set
            {
                nome_remetente = value;
            }
        }
        public string Nome_dest
        {
            get
            {
                return nome_dest;
            }
            set
            {
                nome_dest = value;
            }
        }
        public string Msg
        {
            get
            {
                return msg;
            }
            set
            {
                msg = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }
        public Mensagem()
        {
        }

        public Mensagem(string nome_remetente, string nome_dest, string msg, DateTime date) 
        {
            this.nome_remetente = nome_remetente;
            this.nome_dest = nome_dest;
            this.msg = msg;
            this.date = date;
        }
    }
}
