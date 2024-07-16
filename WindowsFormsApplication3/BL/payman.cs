using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class payman
    {
        //public DataTable get_paymant()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("select_paymnt", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public void add_paymant(int id, string namee)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[2];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 500);
        //    parm[1].Value = namee;

        //    DAL.executecommand("insert_paymint", parm);
        //    DAL.cloes();
        //}
        //public void update_paymant(int id, string namee)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[2];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 500);
        //    parm[1].Value = namee;

        //    DAL.executecommand("update_paym", parm);
        //    DAL.cloes();
        //}



        public class PaymentService
        {
            private DAL.data_access_layar DAL;

            public PaymentService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_paymant()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("select_paymnt", null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // يمكنك معالجة الاستثناء هنا أو إعادة إلقاءه بمعالجة خاصة.
                }
                finally
                {
                    DAL.cloes();
                }
                return dt;
            }

            public void add_paymant(int id, string namee)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[2];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 500);
                    parameters[1].Value = namee;

                    DAL.executecommand("insert_paymint", parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // يمكنك معالجة الاستثناء هنا أو إعادة إلقاءه بمعالجة خاصة.
                }
                finally
                {
                    DAL.cloes();
                }
            }

            public void update_paymant(int id, string namee)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[2];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 500);
                    parameters[1].Value = namee;

                    DAL.executecommand("update_paym", parameters);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // يمكنك معالجة الاستثناء هنا أو إعادة إلقاءه بمعالجة خاصة.
                }
                finally
                {
                    DAL.cloes();

                }
            }
        }

    }
}
