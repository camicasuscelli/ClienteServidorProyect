using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CSP.DataAccess.Interfaces;
using System.Data;

namespace CSP.DataAccess
{
    public class ConexionLogin
    {
        SqlConnection myConnection = new SqlConnection("server=localhost;" +
                                       "Trusted_Connection=yes;" +
                                       "database=MLM; " +
                                       "connection timeout=30");

        public void Conectar() {

            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
        public void Desconectar() { 

            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public string getUser(string user, string password)
        {

            IDataReader oReader = null;
            SqlCommand myCommand = new SqlCommand();
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.CommandText = "GET_USER";

            IDbDataParameter param1 = (IDbDataParameter)myCommand.CreateParameter();
            param1.ParameterName = "@User";
            param1.DbType = DbType.AnsiString;
            param1.Value = user;
            myCommand.Parameters.Add(param1);

            IDbDataParameter param2 = (IDbDataParameter)myCommand.CreateParameter();
            param2.ParameterName = "@Password";
            param2.DbType = DbType.AnsiString;
            param2.Value = password;
            myCommand.Parameters.Add(param1);

            string Usuario = null;
            string Password = null;
            try
            {
                oReader = myCommand.ExecuteReader();
                while (oReader.Read())
                {
                    //getOrdinal parsea el nombre del campo, es el campo de la tabla.
                    Usuario = oReader[oReader.GetOrdinal("NOMBRE")].ToString();
                    Password = oReader[oReader.GetOrdinal("PASSWORD")].ToString();
                }
                Desconectar();
            }
            catch (Exception r)
            {

            }
            finally
            {
                Desconectar();
                if (oReader != null)
                {
                    oReader.Close();
                    //oReader.Dispose();
                    oReader = null;
                }
            }
            return Usuario + Password;

        }

    }
}
