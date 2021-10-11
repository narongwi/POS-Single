using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
namespace BJCBCPOS.Services.Helpers {
    public class Connector {
        public Connector() { }
        public Connector(string _connectionString) {
            ConnectionString = _connectionString;
        }
        public string ConnectionString { get; set; }

        /// <summary>
        /// Get Single Data Value
        /// </summary>
        /// <param name="commandText">select top 1 Id from table where id=@Id</param>
        /// <param name="parameters">new KeyValuePair<string, object>("@Id", 5)</param>
        /// <returns>integer</returns>
        public int GetInt(string commandText,params SqlParams[] parameters) {
            int result = -1;
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();

                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = commandText;
                        foreach(SqlParams parameter in parameters)
                            command.Parameters.AddWithValue(parameter.name,parameter.value);

                        result = command.ExecuteScalar().toInt();
                        //using(SqlDataReader dataReader = command.ExecuteReader())
                        //    if(dataReader.HasRows)
                        //        while(dataReader.Read())
                        //            result = dataReader.GetInt32(0);
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        /// <summary>
        /// Get double Data Value
        /// </summary>
        /// <param name="commandText">select top 1 price from table where id=@Id</param>
        /// <param name="parameters">new KeyValuePair<string, object>("@Id", 5)</param>
        /// <returns>decimal</returns>
        public double GetDbl(string commandText,params SqlParams[] parameters) {
            double result = -1;
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();
                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = commandText;
                        foreach(SqlParams parameter in parameters)
                            command.Parameters.AddWithValue(parameter.name,parameter.value);

                        result = command.ExecuteScalar().toDouble();
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }


        /// <summary>
        /// Get string Data Value
        /// </summary>
        /// <param name="commandText">select top 1 name from table where id=@Id</param>
        /// <param name="parameters">new KeyValuePair<string, object>("@Id", 5)</param>
        /// <returns>string</returns>
        public string GetStr(string commandText,params SqlParams[] parameters) {
            string result = string.Empty;

            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();

                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = commandText;
                        foreach(SqlParams parameter in parameters)
                            command.Parameters.AddWithValue(parameter.name,parameter.value);

                        result = command.ExecuteScalar().ToString();
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Get DataTable Object
        /// </summary>
        /// <param name="commandText">select * from table where category=@cat</param>
        /// <param name="parameters">new KeyValuePair<string, object>("@cat", 5)</param>
        /// <returns>System.Data.DataTable</returns>
        public DataTable GetDtb(string commandText,params SqlParams[] parameters) {
            DataTable result = new DataTable();
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText,connection)) {
                        foreach(SqlParams parameter in parameters)
                            dataAdapter.SelectCommand.Parameters.AddWithValue(parameter.name,parameter.value);
                        dataAdapter.Fill(result);
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Get DataTable Object
        /// </summary>
        /// <param name="commandText">select * from table where category=@cat</param>
        /// <param name="parameters">new KeyValuePair<string, object>("@cat", 5)</param>
        /// <returns>System.Data.DataTable</returns>
        public DataSet GetDts(string commandText,params SqlParams[] parameters) {
            DataSet result = new DataSet();
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();
                    using(SqlDataAdapter dataAdapter = new SqlDataAdapter(commandText,connection)) {
                        foreach(SqlParams parameter in parameters)
                            dataAdapter.SelectCommand.Parameters.AddWithValue(parameter.name,parameter.value);
                        dataAdapter.Fill(result);
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }
        public bool ExcSql(string commandText,params SqlParams[] parameters) {
            bool result = false;
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();
                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = commandText;
                        foreach(SqlParams parameter in parameters)
                            command.Parameters.AddWithValue(parameter.name,parameter.value);

                        command.ExecuteNonQuery();
                        result = true;
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == System.Data.ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }
        public bool ExcSqlAsync(string commandText,params SqlParams[] parameters) {
            bool result;
            using(SqlConnection connection = new SqlConnection(ConnectionString)) {
                try {
                    connection.Open();
                    using(SqlCommand command = connection.CreateCommand()) {
                        command.CommandText = commandText;
                        foreach(SqlParams parameter in parameters)
                            command.Parameters.AddWithValue(parameter.name,parameter.value);

                        command.ExecuteNonQuery();
                        result = true;
                    }
                } catch(Exception e) {
                    throw e;
                } finally {
                    if(connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

        public bool ExcTxAsync(params SqlCommand[] commands) {
            bool result;
            using(var connection = new SqlConnection(ConnectionString)) {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                try {
                    foreach(SqlCommand cmd in commands) {
                        cmd.Connection = connection;
                        cmd.Transaction = transaction;
                        cmd.ExecuteNonQuery();
                    }
                    transaction.Commit();
                    result = true;
                } catch(Exception e) {
                    transaction.Rollback();
                    throw e;
                } finally {
                    if(connection.State == ConnectionState.Open)
                        connection.Close();
                }
            }
            return result;
        }

    }
}