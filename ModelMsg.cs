using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
namespace WalkTalk
{
    public class ModelMsg
    {
        private string endereco_banco = "Data Source=25.50.68.130:1521/freepdb1;User Id =WalkTalk_for_dev;Password=WalkTalk_for_dev;";
        private static int id_ultima_msg;
        Mensagem msginf = new Mensagem();
        public int Id
        {
            get
            {
                return id_ultima_msg;
            }
        }

        static private List<Mensagem> contatos = new List<Mensagem>();
        public List<Mensagem> Contatos
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
          /*  using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("prc_env_msg", connection))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.Add("v_id_remetente", OracleDbType.Int16).Value = Convert.ToInt32(id_r);
                        cmd.Parameters.Add("v_id_destinatario", OracleDbType.Int16).Value = Convert.ToInt32(id_d);
                        cmd.Parameters.Add("v_msg", OracleDbType.Varchar2).Value = mensagem;
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
        public void RecebeMensagens()
        {
          /*  using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from view_msg w where w.id_remetente = {Usuario.id_us} and w.id_destinatario = {Usuario.id_des} or w.id_remetente = {Usuario.id_des} and w.id_destinatario = {Usuario.id_us} order by data_envio", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                histlist.Add(new Mensagem(reader["id_remetente"].ToString(), reader["remetente"].ToString(), reader["msg"].ToString(), Convert.ToDateTime(reader["data_envio"])));
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }
        public void NovaMsg()
        {
         /*  using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand("SELECT MAX(id) as id FROM wlk_msg WHERE (id_destinatario = 2 OR id_destinatario = 1) AND (id_remetente = 1 OR id_remetente = 2)", connection))
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
            }*/
        }
        public void SetDestinoId(string us)
        {
            foreach (Mensagem obj in contatos)
            {
                if (obj.Msg == us)
                {
                    Usuario.id_des = obj.Id.ToString();
                }
            }
        }
        public void CarregaContatos()
        {
          /*  using (OracleConnection connection = new OracleConnection(endereco_banco))
            {
                try
                {
                    connection.Open();
                    using (OracleCommand cmd = new OracleCommand($"select * from view_user", connection))
                    {
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                contatos.Add(new Mensagem(Convert.ToInt32(reader["id"]), reader["nome"].ToString()));
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Houve um erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }*/
        }

    }
}
