using System.Data.SqlClient;

/// <summary>
/// Classe responsável pela conexão com o banco de dados SQL Servern 2019
/// </summary>
/// 

namespace Dao
{
    class ConexaoDB
    {
        // Criação de variáveis para acesso ao banco de dados.

        private static ConexaoDB objConexaoDB = null; //  Criação da variável para carregar o objeto do status.
        private SqlConnection con; // Variável para carregar a conexão.

        // Criação do meu construtor.
        private ConexaoDB()
        {
            // Variáveis para ser utilizada no meu objeto con.
            string servidor = "DESKTOP-K52NLVK\\SQLEXPRESS";
            string bancoDeDados = "Financeiro";


            // Estrutura para conexão da base.
            con = new SqlConnection($"Data Source={servidor}; Initial Catalog={bancoDeDados}; Integrated Security=True;"); // Comando para carregar minha conexão com autenticação do windows.
        }

        // Método para saber o estado da conexão
        public static ConexaoDB saberEstado()
        {
            if (objConexaoDB == null)
            {
                objConexaoDB = new ConexaoDB();
            }

            return objConexaoDB;
        }

        // Método para capturar a conexão
        public SqlConnection capturaConexao()
        {
            return con;
        }

        // Método para fechar conexão.
        public void fecharConexao()
        {
            objConexaoDB = null;
        }
    }
}
