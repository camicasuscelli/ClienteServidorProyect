using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection;


namespace CSP.DataAccess.Interfaces
{
    class ConexionBD
    {
       /* private string _connectionString;
        private string _schema;
        private IDbCommand _oDbCommand;
        private IDbConnection _oDbConnection;
        private IDbTransaction _oDbTransaction;

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public string Schema
        {
            get { return _schema; }
            set { _schema = value; }
        }

        public string Package
        {
            get { return string.Empty; }
            set { }
        }

        public ConexionBD()
        {
            _connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public void OpenConnection()
        {
            try
            {
                if (_oDbConnection == null)
                    SetConnection();
                else if (_oDbConnection.State == ConnectionState.Closed)
                    _oDbConnection.Open();
            }
            catch (System.Exception e)
            {
                throw new Exception(_classFullName + ".OpenConnection()", e);
            }
        }

        public void CloseConnection()
        {
            if (_oDbConnection != null)
            {
                if (_oDbConnection.State != ConnectionState.Closed)
                {
                    try
                    {
                        _oDbConnection.Close();
                    }
                    catch (System.Exception e)
                    {
                        throw new Exception(_classFullName + ".CloseConnection()", e);
                    }
                }
            }
        }

        public void OpenCommand()
        {
            if (_oDbCommand == null)
                _oDbCommand = GetConnection().CreateCommand();
            else
            {
                if (_oDbCommand.Connection.State == ConnectionState.Closed)
                {
                    SetConnection();
                    _oDbCommand.Connection = _oDbConnection;
                }
            }
            if (_oDbTransaction != null)
                _oDbCommand.Transaction = _oDbTransaction;
        }

        public void CloseCommand()
        {
            if (_oDbCommand != null)
            {
                _oDbCommand.Dispose();
                _oDbCommand = null;
                //CloseConnection();
            }
        }

        private void SetConnection()
        {
            try
            {
                _oDbConnection = new SqlConnection(_connectionString);
                try
                {
                    _oDbConnection.Open();
                }
                catch (System.Exception ex1)
                {
                    throw new Exception(_classFullName + ".SetConnection()", ex1);
                }
            }
            catch (System.Exception ex2)
            {
                throw new Exception(_classFullName + ".SetConnection()", ex2);
            }
        }

        private IDbConnection GetConnection()
        {
            OpenConnection();
            return _oDbConnection;
        }
    }*/
}
