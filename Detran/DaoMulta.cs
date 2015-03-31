using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Data.SQLite;

namespace Detran
{
    /// <summary>classe DaoMulta da camada Dao</summary>
    public class DaoMulta
	{
        /// <summary>Armazena a url da conexão com banco de dados </summary>
        private static string conexao = "Data Source=crudDetran.db";

        /// <summary>Armazena o nome do banco de dados</summary>
        private static string bd = "crudDetran.db";

        /// <summary>cria as tabelas do banco caso não existam</summary>
        public void criaBdTabelas()
        {
            if (!File.Exists(bd))
            {
                SQLiteConnection.CreateFile(bd);
                SQLiteConnection con = new SQLiteConnection(conexao);
                con.Open();
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("CREATE TABLE  IF NOT EXISTS multa([codMulta] INTEGER PRIMARY KEY ASC,");
                sql.AppendLine("[Infracao] VARCHAR(50),");
                sql.AppendLine("[Pontos] INTEGER,");
                sql.AppendLine("[Penalidade] VARCHAR(50),");
                sql.AppendLine("[Valor] REAL)");


                SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), con);
                cmd.ExecuteNonQuery();

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro na criação de banco de dados" + ex.Message);
                }
            }
        }

        /// <summary>retorna todas as multas</summary>
        /// <returns>Retorna um List com todos os registros</returns>
        public  List<Multa> retornaRegistros()
        {
            SQLiteConnection con = new SQLiteConnection(conexao);
            List<Multa> lista = new List<Multa>();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT codMulta as Multa,Infracao,Pontos,Penalidade,Valor FROM multa", con);

                SQLiteDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    lista.Add(new Multa
                    {
                        Codigo = Convert.ToInt32(dr["Multa"]),
                        Infracao = dr["Infracao"].ToString(),
                        Pontos = Convert.ToInt32(dr["Pontos"]),
                        Penalidade = dr["Penalidade"].ToString(),
                        Valor = Convert.ToDouble(dr["Valor"])
                    });
                }
               
            }

            return lista;
        }

        /// <summary>verifica se o que foi informado é valido</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se os campos estão validos</returns>
        private string validaCampos(Multa multa)
        {
            string mensagen = "";

            if (multa.Codigo < 1)
            {
                mensagen += "\n informe o código valido";
            }

            if (multa.Infracao.Length == 0)
            {
                mensagen += "\n informe a infração";
            }

            if (multa.Pontos  < 0)
            {
                mensagen += "\n informe os pontos";
            }

            if (multa.Penalidade.Length == 0)
            {
                mensagen += "\n informe a penalidade";
            }

            if (multa.Valor < 0)
            {
                mensagen += "\n informe o valor";
            }

            return mensagen;
        }

        /// <summary>verifica se a multa existe</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se existe ou não a multa informada </returns>
        private bool existeMulta(Multa multa)
        {
            int contadorLinhas = 0;

            SQLiteConnection con = new SQLiteConnection(conexao);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM multa where codMulta = @codMulta", con);

                cmd.Parameters.AddWithValue("codMulta", multa.Codigo);

                SQLiteDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    contadorLinhas++;
                }
            }

            if (contadorLinhas > 0) {
                return true;
            }

            return false;

        }

        /// <summary>valida a gravação da multa</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool validaGravacao(Multa multa)
        {
            bool retorno = true;
            string mensagen = "";

            if (this.existeMulta(multa) == true)
            {
                mensagen += "\n o código da multa ja existe";
            }

            mensagen += validaCampos(multa);

            if (mensagen.Length > 0)
            {
                retorno = false;
                MessageBox.Show(mensagen, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        /// <summary>valida a alteração da multa</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool validaAlteracao(Multa multa)
        {
            bool retorno = true;
            string mensagen = "";

            if (existeMulta(multa) == false)
            {
                mensagen += "\n o código da multa não existe";
            }

            mensagen += validaCampos(multa);

            if (mensagen.Length > 0)
            {
                retorno = false;
                MessageBox.Show(mensagen, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        /// <summary>valida a exclusão da multa</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool validaExclusao(Multa multa)
        {
            bool retorno = true;
            string mensagen = "";

            if (existeMulta(multa) == false)
            {
                mensagen += "\n o código da multa não existe";
            }

            if (mensagen.Length > 0)
            {
                retorno = false;
                MessageBox.Show(mensagen, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retorno;
        }

        /// <summary>Função que salva a multa no banco</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool gravar(Multa multa)
        {
            SQLiteConnection con = new SQLiteConnection(conexao);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("INSERT INTO multa (codMulta,Infracao,Pontos,Penalidade,Valor) values(@codMulta,@Infracao,@Pontos,@Penalidade,@Valor)", con);

                cmd.Parameters.AddWithValue("codMulta", multa.Codigo.ToString());
                cmd.Parameters.AddWithValue("Infracao", multa.Infracao.Trim());
                cmd.Parameters.AddWithValue("Pontos", multa.Pontos);
                cmd.Parameters.AddWithValue("Penalidade", multa.Penalidade.ToString());
                cmd.Parameters.AddWithValue("Valor", multa.Valor);

                try {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Multa salva com sucesso");
                    return true;
                } catch (Exception ex) {
                    MessageBox.Show(ex + "\n Erro ao tentar registrar uma nova multa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return false;
        }

        /// <summary>Função que exclui a multa no banco</summary>
        /// <param name="obj">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool excluir(object obj)
        {
            SQLiteConnection con = new SQLiteConnection(conexao);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("DELETE FROM multa WHERE codMulta=@codMulta", con);
                cmd.Parameters.AddWithValue("@codMulta", obj);

                try {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Multa excluida com sucesso");
                    return true;
                } catch (Exception ex) {
                    MessageBox.Show(ex + "\n Erro ao excluir a multa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

            return false;
        }


        /// <summary>Função que atualiza a multa no banco</summary>
        /// <param name="multa">Armazena o objeto que sera utilizado</param>
        /// <returns>Retorna um boolean que indica se tudo ocorreu bem </returns>
        public bool atualizar(Multa multa)
        {
            SQLiteConnection con = new SQLiteConnection(conexao);

            if (con.State == ConnectionState.Closed) {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("UPDATE  multa SET  Infracao=@Infracao,Pontos=@Pontos,Penalidade=@Penalidade,Valor=@Valor where codMulta=@codMulta", con);
                cmd.Parameters.AddWithValue("codMulta", multa.Codigo.ToString());
                cmd.Parameters.AddWithValue("Infracao", multa.Infracao.Trim());
                cmd.Parameters.AddWithValue("Pontos", multa.Pontos);
                cmd.Parameters.AddWithValue("Penalidade", multa.Penalidade.ToString());
                cmd.Parameters.AddWithValue("Valor", multa.Valor);

                try {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Multa atualizada com sucesso");
                    return true;
                } catch (Exception ex) {
                    MessageBox.Show(ex + "\n Erro ao excluir a multa", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            return false;
        }

	}
}
