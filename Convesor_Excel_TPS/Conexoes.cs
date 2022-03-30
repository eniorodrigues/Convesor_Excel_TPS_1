using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convesor_Excel_TPS
{
    public class Conexoes
    {
     

        public List<string> Conectar(string conex)
        {
            List<string> bases = new List<string>();

            string nomeBase;

            SqlConnection conn = new SqlConnection("Data Source=" + conex + "; Integrated Security=True;");

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            DataTable databases = conn.GetSchema("Databases");
             

            foreach (DataRow database in databases.Rows)
            {
                nomeBase = database.Field<String>("database_name");
                 
                if (nomeBase != "master" && nomeBase != "tempdb" && nomeBase != "model" && nomeBase != "msdb")
                {
                    bases.Add(nomeBase);
                }
            }

            conn.Close();

            return bases;
        }


        public SqlConnection ConexaoSQL (string conex, string baseSelecionada)
        {

            SqlConnection sqlConnection = new SqlConnection();

            List<string> bases = new List<string>();

            string nomeBase;

            sqlConnection = new SqlConnection("Data Source=" + conex + "; Integrated Security=True;");


            if (sqlConnection.State.ToString() == "Closed")
            {
                sqlConnection.Open();
            }

            DataTable databases = sqlConnection.GetSchema("Databases");


            foreach (DataRow database in databases.Rows)
            {
                nomeBase = database.Field<String>("database_name");

                if (nomeBase != "master" && nomeBase != "tempdb" && nomeBase != "model" && nomeBase != "msdb")
                {
                    bases.Add(nomeBase);
                }
            }

            sqlConnection = new SqlConnection("Data Source=" + conex + "; Integrated Security=True; Initial Catalog=" + baseSelecionada);
             

            return sqlConnection;

        }


    }
}
