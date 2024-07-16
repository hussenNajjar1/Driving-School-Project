using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.DAL
{
    class data_access_layar
    {
        //كائن الاتصال 
        SqlConnection sqlconnection;
        

        //  للاتصال مشيد افتراضي
        public data_access_layar()
        {
            sqlconnection = new SqlConnection(@"Data Source =DESKTOP-BC49T7I\MSSQLSERVERR; initial catalog = dilo; Integrated Security = True");
        }

        //اجراء فتح الاتصال
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }
        //اجراء اغلاق الاتصال
        public void cloes()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }
        //لقراءة البيانات من القاعدة
        public DataTable selectdata(string stored_prosedure,SqlParameter[] parm)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_prosedure;
            sqlcmd.Connection = sqlconnection;

            if(parm !=null)
            {
                for(int i=0;i<parm.Length;i++)
                {
                    sqlcmd.Parameters.Add(parm[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        //ارسال البيانات الى القاعدة اضافة تعديل حذف
        public void executecommand(string stored_procedure,SqlParameter[]param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;
            if (param !=null)
            {
                sqlcmd.Parameters.AddRange(param);
            }
            sqlcmd.ExecuteNonQuery();
        }
    
    }
}
