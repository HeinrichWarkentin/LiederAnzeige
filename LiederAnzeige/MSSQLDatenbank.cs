using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace LiederAnzeige
{
    internal class MSSQLDatenbank
    {
        private string connectionString;
        public MSSQLDatenbank(string pConnectionString)
        {
            connectionString = pConnectionString;
        }
        SqlDataReader TMP_Cached_dataReader;
        public bool checkConnection()
        {
            try
            {
                //--- Do not forget to configure connection pull so that
                //--- establishing a connection will not be expensive 
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand("SELECT @@VERSION", sqlConnection))
                    {
                        List<string> version = returningCommandListString(sqlCommand, 0);
                        if (version != null)
                        {
                            foreach (string item in version)
                            {
                                Debug.WriteLine("SQL-Server-Version: " + item);
                            }
                        }
                        sqlConnection.Close();
                    }
                }
                return true;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
            }
            return false;
        }

        public bool nonReturningCommand(SqlCommand pSqlCommand)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = pSqlCommand)
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.ExecuteNonQuery();
                    }
                    sqlConnection.Close();
                }
                return true;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
                return false;
            }
        }

        public List<string> returningCommandListString(SqlCommand pSqlCommand, int pColumn)
        {
            List<string> listReturnString = new List<string>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = pSqlCommand)
                    {
                        sqlCommand.Connection = sqlConnection;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();

                        while (dataReader.Read())
                        {
                            listReturnString.Add(dataReader.GetString(pColumn));
                        }

                        dataReader.Close();
                    }
                    sqlConnection.Close();
                }
                return listReturnString;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
                return listReturnString;
            }
        }

        public List<int> returningCommandListInt(SqlCommand pSqlCommand, int pColumn)
        {
            List<int> listReturnString = new List<int>();

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = pSqlCommand)
                    {
                        sqlCommand.Connection = sqlConnection;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();

                        while (dataReader.Read())
                        {
                            listReturnString.Add(dataReader.GetInt32(pColumn));
                        }
                        dataReader.Close();
                    }
                    sqlConnection.Close();
                }
                return listReturnString;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
                return listReturnString;
            }
        }

        public AutoCompleteStringCollection returningCommandAutoCompleteCollection(SqlCommand pSqlCommand)
        {
            AutoCompleteStringCollection autoCompleteStringCollection = new AutoCompleteStringCollection();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = pSqlCommand)
                    {
                        sqlCommand.Connection = sqlConnection;
                        SqlDataReader dataReader = sqlCommand.ExecuteReader();

                        while (dataReader.Read())
                        {
                            autoCompleteStringCollection.Add(dataReader.GetString(0));
                        }
                        dataReader.Close();
                    }
                    sqlConnection.Close();
                }
                return autoCompleteStringCollection;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
            }
            return autoCompleteStringCollection;
        }

        public DataTable nonreturningCommandSqlDataAdapter(SqlCommand pSqlCommand)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    pSqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
                    {
                        sqlDataAdapter.SelectCommand = pSqlCommand;
                        sqlDataAdapter.Fill(dataTable);
                    }

                    sqlConnection.Close();
                }
                return dataTable;
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
                return dataTable;
            }
        }

        public void returningCommandmultiColumntoCache(SqlCommand pSqlCommand)
        {

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = pSqlCommand)
                    {
                        sqlCommand.Connection = sqlConnection;
                        TMP_Cached_dataReader = sqlCommand.ExecuteReader();
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
            }
        }

        public List<int> readfromCachedDataInt(int pColumn)
        {
            List<int> listReturnString = new List<int>();
            try
            {
                while (TMP_Cached_dataReader.Read())
                {
                    listReturnString.Add(TMP_Cached_dataReader.GetInt32(pColumn));
                }
                TMP_Cached_dataReader.Close();
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
            }
            return listReturnString;
        }
        public List<string> readfromCachedDataString(int pColumn)
        {
            List<string> listReturnString = new List<string>();
            try
            {
                while (TMP_Cached_dataReader.Read())
                {
                    listReturnString.Add(TMP_Cached_dataReader.GetString(pColumn));
                }
                TMP_Cached_dataReader.Close();
            }
            catch (Exception eX)
            {
                Debug.WriteLine("Exception: " + eX.Message);
            }
            return listReturnString;
        }
    }
}
