using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication3.BL
{
    class Dwra
    {
        //عرض البيانات
        //public DataTable get_dwra()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("select_dwra", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////اضافة دورة
        //public void add_dwra(int id, string name, string daten, string datee,int sal)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name;

        //    parm[2] = new SqlParameter("@date_naw", SqlDbType.Date);
        //    parm[2].Value = daten;

        //    parm[3] = new SqlParameter("@date_end", SqlDbType.Date);
        //    parm[3].Value = datee;

        //    parm[4] = new SqlParameter("@sal", SqlDbType.Int);
        //    parm[4].Value = sal;


        //    DAL.executecommand("insert_dwra", parm);
        //    DAL.cloes();
        //}
        ////حذف دورة
        //public void delete_dwra(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_dwra", parm);
        //    DAL.cloes();
        //}
        ////تعديل بيانات دوة
        //public void update_dwra(int id, string name, string daten, string datee,int sal)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name;

        //    parm[2] = new SqlParameter("@daten", SqlDbType.Date);
        //    parm[2].Value = daten;

        //    parm[3] = new SqlParameter("@datee", SqlDbType.Date);
        //    parm[3].Value = datee;

        //    parm[4] = new SqlParameter("@sal", SqlDbType.Int);
        //    parm[4].Value = sal;

        //    DAL.executecommand("ubdate_dwra", parm);
        //    DAL.cloes();
        //}
        ////للتحقق من عدم تكرار id
        //public DataTable veri_id_dwra(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("veri_id_dwra", parm);
        //    DAL.cloes();
        //    return Dt;
        //}

        public class DwraService
        {
            private DAL.data_access_layar DAL;

            public DwraService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_dwra()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("select_dwra", null);
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

            public void add_dwra(int id, string name, string daten, string datee, int sal)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[5];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@namee", SqlDbType.NVarChar, 50);
                    parameters[1].Value = name;

                    parameters[2] = new SqlParameter("@date_naw", SqlDbType.Date);
                    parameters[2].Value = daten;

                    parameters[3] = new SqlParameter("@date_end", SqlDbType.Date);
                    parameters[3].Value = datee;

                    parameters[4] = new SqlParameter("@sal", SqlDbType.Int);
                    parameters[4].Value = sal;

                    DAL.executecommand("insert_dwra", parameters);
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

            public void delete_dwra(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_dwra", parameters);
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

            public void update_dwra(int id, string name, string daten, string datee, int sal)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[5];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
                    parameters[1].Value = name;

                    parameters[2] = new SqlParameter("@daten", SqlDbType.Date);
                    parameters[2].Value = daten;

                    parameters[3] = new SqlParameter("@datee", SqlDbType.Date);
                    parameters[3].Value = datee;

                    parameters[4] = new SqlParameter("@sal", SqlDbType.Int);
                    parameters[4].Value = sal;

                    DAL.executecommand("ubdate_dwra", parameters);
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

            public DataTable veri_id_dwra(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("veri_id_dwra", parameters);
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
        }


    }
}
