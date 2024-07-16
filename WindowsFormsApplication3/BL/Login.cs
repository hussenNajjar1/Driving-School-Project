using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Login
    {
        public DataTable login_user(string id, string namee)
        {
            //try
            //{

            //    DAL.data_access_layar DAL = new DAL.data_access_layar();
            //    DataTable Dt = new DataTable();
            //    SqlParameter[] parm = new SqlParameter[2];
            //    parm[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            //    parm[0].Value = id;

            //    parm[1] = new SqlParameter("@passwordd", SqlDbType.NVarChar, 50);
            //    parm[1].Value = namee;

            //    Dt = DAL.selectdata("check_user", parm);
            //    DAL.cloes();
            //    return Dt;
            //}

            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            try
            {
                DAL.data_access_layar DAL = new DAL.data_access_layar();
                DataTable Dt = new DataTable();
                SqlParameter[] parm = new SqlParameter[2];

                parm[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
                parm[0].Value = id;

                parm[1] = new SqlParameter("@passwordd", SqlDbType.NVarChar, 50);
                parm[1].Value = namee;

                Dt = DAL.selectdata("check_user", parm);  
                return Dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null; // قم بإرجاع قيمة مناسبة (مثل null) في حالة الخطأ أو يمكنك إلقاء الاستثناء مرة أخرى إذا كان ذلك مناسبًا.
            }



        }
    }
}
