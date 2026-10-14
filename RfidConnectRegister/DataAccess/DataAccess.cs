using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using RfidConnectRegister.BussinessLogic.Classes;

// ReSharper disable once CheckNamespace
namespace RfidConnectRegister.DataAccess
{
    internal class DataAccess
    {
        private string _connectionString = string.Empty;
        public DataAccess(string connectionString)
        {
            _connectionString = connectionString;
        }
        public int CmdSqlExecuteNonQuery(SqlCommand cmd)
        {
            var result = 0;
            try
            {
            //    var con = new SqlConnection {ConnectionString = "Data Source=imohammadi-pc;Initial Catalog=RFIDConnect_DB;Persist Security Info=True;User ID=sa;Password=11" };
                var con = new SqlConnection { ConnectionString = _connectionString };
                con.Open();
                cmd.Connection = con;
                result = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 3201)
                {
                    MessageBox.Show(@" شما دسترسی لازم برای انجام عمل پشتیبان گیری را ندارید. لطفا با پشتیبانی تماس بگیرید",@"خطا",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                if (ex.Number == 102)
                {
                    MessageBox.Show(@" متن نوشته شده دارای مشکل می باشد ", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 2714)
                {
                    MessageBox.Show(@" آبجکت مورد نظر هم اکنون در دیتابیس موجود است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 1913)
                {
                    MessageBox.Show(@" شاخص یا قید مورد نظر هم اکنون در دیتابیس موجود است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 2812)
                {
                    MessageBox.Show(@"دستور نوشته شده معتبر نیست", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 2715)
                {
                    MessageBox.Show(@"نوع پارامتر نوشته شده اشتباه است", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 1911)
                {
                    MessageBox.Show(@"ستون مورد نظر در جدول یا نمایه مورد نظر موجود نیست", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (ex.Number == 4902)
                {
                    MessageBox.Show(@"آبجکت مورد نظر یا در دیتابیس موجود نیست و یا شما دسترسی لازم را به آن ندارید", @"خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }
            catch (Exception exception)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(exception);
            }
            
            return result;
        }

        public int CmdSqlExecuteNonQueryWithTransaction(List<SqlCommand> listCommands)
        {
            var result = 1;
            var con = new SqlConnection { ConnectionString = _connectionString};
            con.Open();
            var sqlTran = con.BeginTransaction();

            try
            {
                foreach (var command in listCommands)
                {
                    var myCommand = new SqlCommand { CommandText = command.CommandText };
                    myCommand.Parameters.Clear();
                    for (var i = 0; i < command.Parameters.Count; i++)
                    {
                        myCommand.Parameters.AddWithValue(command.Parameters[i].ParameterName,
                            command.Parameters[i].Value);
                    }

                    myCommand.Connection = con;
                    myCommand.Transaction = sqlTran;
                    Debug.WriteLine(command.CommandText);
                    myCommand.ExecuteNonQuery();
                }
                sqlTran.Commit();
            }
            catch (Exception exception)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(exception);
                sqlTran.Rollback();
                result = 0;
            }
            finally
            {
                con.Close();
            }
            return result;
        }

        public DataTable SqlDataAdapter(SqlCommand cmd)
        {
            var dt = new DataTable();
            try
            {
                var con = new SqlConnection { ConnectionString = _connectionString };
                con.Open();
                cmd.Connection = con;
                var adapter = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
            }
            catch (Exception exception)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(exception);
            }
            return dt;
        }

        public SqlParameter[] SqlDataReaders(SqlCommand cmd)
        {
            SqlParameter[] result = null;
            try
            {
                var con = new SqlConnection
                {
                    ConnectionString = _connectionString
                };

                cmd.Connection = con;
                con.Open();
                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    result = new SqlParameter[reader.FieldCount];
                    for (var i = 0; i < reader.FieldCount; i++)
                    {
                        result[i] = new SqlParameter(reader.GetName(i), reader.GetValue(i));
                    }
                }

                reader.Close();
                con.Close();
            }
            catch (Exception exception)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(exception);
                result = null;
            }

            return result;
        }
    }
}
