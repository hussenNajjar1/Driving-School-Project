using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class dwra_triner
    {
        //لتعبئة اسماء المتدربين النظري في الكومبو بكس
        //public DataTable get_name_triner()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_name_triner_a", null);
        //    DAL.cloes();
        //    return Dt;
        //}
       
      
        ////اضافة تفاصيل دورة مدربين دورة
        //public void add_dwra_triner(int id, int id_t,string com,string date_s,string date_e)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
        //    parm[0] = new SqlParameter("@id_d", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@id_t", SqlDbType.Int);
        //    parm[1].Value = id_t;

        //    parm[2] = new SqlParameter("@coment", SqlDbType.NVarChar,100);
        //    parm[2].Value = com;

        //    parm[3] = new SqlParameter("@date_s", SqlDbType.Date);
        //    parm[3].Value = date_s;

        //    parm[4] = new SqlParameter("@date_e", SqlDbType.Date);
        //    parm[4].Value = date_e;



        //    DAL.executecommand("insert_dwra_triner", parm);
        //    DAL.cloes();
        //}
       


        ////لتعبئة اسماء الدورات في الكومبو بكس
        //public DataTable get_name_dwra()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_name_d", null);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////لعرض وتحديث البيانات
        //public DataTable get_triner_dwra()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_triner_dwra", null);
        //    DAL.cloes();
        //    return Dt;
        //}
       
        ////تعديل تفاصيل دورة
        
        //public void update_dwra_triner(int id, int id_d,int id_t, string com, string date_s, string date_e)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[6];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@id_d", SqlDbType.Int);
        //    parm[1].Value = id_d;

        //    parm[2] = new SqlParameter("@id_t", SqlDbType.Int);
        //    parm[2].Value = id_t;

        //    parm[3] = new SqlParameter("@coment", SqlDbType.NVarChar,100);
        //    parm[3].Value = com;

        //    parm[4] = new SqlParameter("@daten", SqlDbType.Date);
        //    parm[4].Value = date_s;

        //    parm[5] = new SqlParameter("@datee", SqlDbType.Date);
        //    parm[5].Value = date_e;



        //    DAL.executecommand("ubdate_dwra_triner", parm);
        //    DAL.cloes();
        //}

        ////حذف تفاصيل دورة
        //public void delete_relechn_dwra_triner(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

            
          

        //    DAL.executecommand("delete_relechn_dwra_triner", parm);
        //    DAL.cloes();
        //}


        public class TrinerDwraService
        {
            private DAL.data_access_layar DAL;

            public TrinerDwraService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_name_triner()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_triner_a", null);
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

            public void add_dwra_triner(int id, int id_t, string com, string date_s, string date_e)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[5];
                    parameters[0] = new SqlParameter("@id_d", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@id_t", SqlDbType.Int);
                    parameters[1].Value = id_t;

                    parameters[2] = new SqlParameter("@coment", SqlDbType.NVarChar, 100);
                    parameters[2].Value = com;

                    parameters[3] = new SqlParameter("@date_s", SqlDbType.Date);
                    parameters[3].Value = date_s;

                    parameters[4] = new SqlParameter("@date_e", SqlDbType.Date);
                    parameters[4].Value = date_e;

                    DAL.executecommand("insert_dwra_triner", parameters);
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

            public DataTable get_name_dwra()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_d", null);
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

            public DataTable get_triner_dwra()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_triner_dwra", null);
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

            public void update_dwra_triner(int id, int id_d, int id_t, string com, string date_s, string date_e)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[6];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@id_d", SqlDbType.Int);
                    parameters[1].Value = id_d;

                    parameters[2] = new SqlParameter("@id_t", SqlDbType.Int);
                    parameters[2].Value = id_t;

                    parameters[3] = new SqlParameter("@coment", SqlDbType.NVarChar, 100);
                    parameters[3].Value = com;

                    parameters[4] = new SqlParameter("@daten", SqlDbType.Date);
                    parameters[4].Value = date_s;

                    parameters[5] = new SqlParameter("@datee", SqlDbType.Date);
                    parameters[5].Value = date_e;

                    DAL.executecommand("ubdate_dwra_triner", parameters);
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

            public void delete_relechn_dwra_triner(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_relechn_dwra_triner", parameters);
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
