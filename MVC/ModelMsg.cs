using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using WalkTalk.Entity;
namespace WalkTalk.MVC
{
    public class ModelMsg
    {
        private string endereco_banco = "Data Source=25.49.76.159:1521/freepdb1;User Id =walk;Password=walk;";
        private static int id_ultima_msg;
        Contatos msginf = new Contatos();
        public int Id
        {
            get
            {
                return id_ultima_msg;
            }
        }

        static private List<Contatos> contatos = new List<Contatos>();
        public List<Contatos> Contatos
        {
            get
            {
                return contatos;
            }
        }

        static private List<Mensagem> histlist = new List<Mensagem>();
        public List<Mensagem> Histlist
        {
            get
            {
                return histlist;
            }
        }

        public void Env(string id_r, string id_d, string mensagem)
        {
            using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("prc_env_msg", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id_remetente", OracleDbType.Int16).Value = Convert.ToInt32(id_r);
                        cmd.Parameters.Add("v_id_destinatario", OracleDbType.Int16).Value = Convert.ToInt32(id_d);
                        cmd.Parameters.Add("v_msg", OracleDbType.Clob).Value = mensagem;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void RecebeMensagens()
        {
            using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($@"
                    select w.destinatario ||'^'||(select username from wlk_users u where u.id = {Usuario.id_des}) as destinatario,w.remetente ||'^'||(select username from wlk_users u where u.id = {Usuario.id_us}) as remetente,msg,data_envio from wlk_mensagens w where w.remetente = {Usuario.id_us} and w.destinatario = {Usuario.id_des} or w.remetente = {Usuario.id_des} and w.destinatario = {Usuario.id_us} order by data_envio asc
", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            histlist.Clear();
                            while (reader.Read())
                            {
                                histlist.Add(new Mensagem(reader["remetente"].ToString(), reader["destinatario"].ToString(), reader["msg"].ToString(), Convert.ToDateTime(reader["data_envio"])));
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void NovaMsg()
        {
            using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"SELECT MAX(id) as id FROM wlk_mensagens WHERE (destinatario = {Usuario.id_des} OR destinatario = {Usuario.id_us}) AND (remetente = {Usuario.id_us} OR remetente = {Usuario.id_des})", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader.IsDBNull(reader.GetOrdinal("id")))
                                {
                                    id_ultima_msg = 0;
                                }
                                else
                                {
                                    id_ultima_msg = reader.GetInt32(reader.GetOrdinal("id"));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void SetDestinoId(string us)
        {
            foreach (var obj in contatos)
            {
                if (obj.Id.ToString() == us)
                {
                    Usuario.id_des = obj.Id.ToString();
                    break;
                }
            }
        }
        public void CarregaContatos()
        {
            using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from wlk_users where id != {Usuario.id_us}", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contatos.Add(new Contatos(Convert.ToInt32(reader["id"]), reader["username"].ToString()));
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
