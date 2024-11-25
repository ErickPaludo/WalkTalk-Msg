using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WalkTalk.Entity
{
    public class Contatos
    {
        private int id;
        private string? usuario;

        public Contatos()
        {
        }

        public int Id { get { return id; } set { id = value; } }
        public string Usuario { get { return usuario; } set { usuario = value; } }

        public Contatos(int id, string? usuario)
        {
            this.id = id;
            this.usuario = usuario;
        }
    }
}
