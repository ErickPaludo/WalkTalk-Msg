using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk
{
    public class Mensagem
    {
        private string id_rem, id_dest,name_r,name_d;
        private string msg;
        private DateTime date;
        public string Id_rem
        {
            get
            {
                return id_rem;
            }
            set
            {
                id_rem = value;
            }
        }
        public string Id_dest
        {
            get
            {
                return id_dest;
            }
            set
            {
                id_dest = value;
            }
        }
        public string Name_r
        {
            get
            {
                return name_r;
            }
            set
            {
                name_r = value;
            }
        }
        public string Name_d
        {
            get
            {
                return name_d;
            }
            set
            {
                name_d = value;
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

        public Mensagem(string id_rem, string id_dest, string msg)
        {
            this.id_rem = id_rem;
            this.id_dest = id_dest;
            this.msg = msg;
        }

        public Mensagem(string id_rem, string id_dest, string msg, DateTime date) : this(id_rem, id_dest, msg)
        {
            this.date = date;
        }

        public Mensagem(string id_rem, string id_dest, string name_r, string name_d, string msg, DateTime date) : this(id_rem, id_dest, name_r)
        {
            this.name_r = name_r;
            this.name_d = name_d;
            this.msg = msg;
            this.date = date;
        }
    }
}
