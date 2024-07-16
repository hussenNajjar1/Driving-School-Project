using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication3.BL
{
    //class Users
    //{
        ////لجلب البيانات وتحديثها
        //public DataTable get_user()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_users", null);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////اضافة تفاصيل التسجيل
        //public void add_user(string name_user, string epon, string loc, string username,string password,string typee)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[6];
        //    parm[0] = new SqlParameter("@namee", SqlDbType.NVarChar,50);
        //    parm[0].Value = name_user;

        //    parm[1] = new SqlParameter("@ephon", SqlDbType.NVarChar,50);
        //    parm[1].Value = epon;
         
        //    parm[2] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
        //    parm[2].Value = loc;

        //    parm[3] = new SqlParameter("@username", SqlDbType.NVarChar,50);
        //    parm[3].Value = username;

        //    parm[4] = new SqlParameter("@passwordd", SqlDbType.NVarChar,50);
        //    parm[4].Value = password;

        //    parm[5] = new SqlParameter("@type_user", SqlDbType.NVarChar,50);
        //    parm[5].Value = typee;

            



        //    DAL.executecommand("insert_into", parm);
        //    DAL.cloes();
        //}

        ////اضافة تفاصيل التسجيل
        //public void update_user(string id,string name_user, string epon, string loc, string username, string password, string typee)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[7];

        //    parm[0] = new SqlParameter("@id", SqlDbType.NVarChar, 50);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name_user;

        //    parm[2] = new SqlParameter("@ephon", SqlDbType.NVarChar, 50);
        //    parm[2].Value = epon;

        //    parm[3] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
        //    parm[3].Value = loc;

        //    parm[4] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
        //    parm[4].Value = username;

        //    parm[5] = new SqlParameter("@passwordd", SqlDbType.NVarChar, 50);
        //    parm[5].Value = password;

        //    parm[6] = new SqlParameter("@type_user", SqlDbType.NVarChar, 50);
        //    parm[6].Value = typee;


        //    DAL.executecommand("update_users", parm);
        //    DAL.cloes();
        //}
        //public void delete_user(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_users", parm);
        //    DAL.cloes();
        //}

  public class Users
    {
        private readonly string connectionString;

        public Users(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable get_user()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM Users";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dataTable);
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
                return dataTable;
            }
        }

        public void add_user(string name, string ephon, string loc, string username, string password, string type)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO Users (name, ephon, loc, username, password, type) VALUES (@name, @ephon, @loc, @username, @password, @type)";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@name", name));
                        command.Parameters.Add(new SqlParameter("@ephon", ephon));
                        command.Parameters.Add(new SqlParameter("@loc", loc));
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@password", password));
                        command.Parameters.Add(new SqlParameter("@type", type));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        public void update_user(string id, string name, string ephon, string loc, string username, string password, string type)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE Users SET name = @name, ephon = @ephon, loc = @loc, username = @username, password = @password, type = @type WHERE id = @id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@id", id));
                        command.Parameters.Add(new SqlParameter("@name", name));
                        command.Parameters.Add(new SqlParameter("@ephon", ephon));
                        command.Parameters.Add(new SqlParameter("@loc", loc));
                        command.Parameters.Add(new SqlParameter("@username", username));
                        command.Parameters.Add(new SqlParameter("@password", password));
                        command.Parameters.Add(new SqlParameter("@type", type));

                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        public void delete_user(string id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM Users WHERE id = @id";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.Add(new SqlParameter("@id", id));
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    HandleError(ex);
                }
            }
        }

        private void HandleError(Exception ex)
        {
            // يمكنك هنا معالجة الأخطاء أو تسجيلها.
            throw ex;
        }
    }
}


    

