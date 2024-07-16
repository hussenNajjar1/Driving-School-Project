using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Exports
    {
        //لتعبئة  سبب الدفع في الكومبو بكس
        //public DataTable get_name_rate()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_name_reate", null);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////لجلب البيانات وتحديثها في جدول الصادرات
        //public DataTable get_exports()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_ex", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public void add_export(string namee, decimal amount_d, decimal amount_t, string rete,string id_m, string city, string data_ex,string mmm)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[8];
        //    parm[0] = new SqlParameter("@name_ex", SqlDbType.NVarChar,100);
        //    parm[0].Value = namee;

        //    parm[1] = new SqlParameter("@amont_d", SqlDbType.Decimal, 10-2);
        //    parm[1].Value = amount_d;

        //    parm[2] = new SqlParameter("@amont_t", SqlDbType.Decimal, 10-2);
        //    parm[2].Value = amount_t;

        //    parm[3] = new SqlParameter("@rate_ex", SqlDbType.NVarChar, 100);
        //    parm[3].Value = rete;

        //    parm[4] = new SqlParameter("@id_m", SqlDbType.Int);
        //    parm[4].Value = id_m;

        //    parm[5] = new SqlParameter("@city_ex", SqlDbType.NVarChar,100);
        //    parm[5].Value = city;

        //    parm[6] = new SqlParameter("@date_ex", SqlDbType.Date);
        //    parm[6].Value = data_ex;

        //    parm[7] = new SqlParameter("@mm", SqlDbType.NVarChar,100);
        //    parm[7].Value = mmm;
        //    DAL.executecommand("insert_exports", parm);
        //    DAL.cloes();
        //}
        //public void updet_expors(string id,string namee, decimal amount_d, decimal amount_t, string rete, string id_m, string city, string data_ex, string mmm)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[9];
        //    parm[0] = new SqlParameter("@id_ex", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@name_ex", SqlDbType.NVarChar, 100);
        //    parm[1].Value = namee;

        //    parm[2] = new SqlParameter("@amont_d", SqlDbType.Decimal, 10-2);
        //    parm[2].Value = amount_d;

        //    parm[3] = new SqlParameter("@amont_t", SqlDbType.Decimal, 10-2);
        //    parm[3].Value = amount_t;

        //    parm[4] = new SqlParameter("@rate_ex", SqlDbType.NVarChar, 100);
        //    parm[4].Value = rete;

        //    parm[5] = new SqlParameter("@id_d", SqlDbType.Int);
        //    parm[5].Value = id_m;

        //    parm[6] = new SqlParameter("@city_ex", SqlDbType.NVarChar, 100);
        //    parm[6].Value = city;

        //    parm[7] = new SqlParameter("@date_ex", SqlDbType.Date);
        //    parm[7].Value = data_ex;

        //    parm[8] = new SqlParameter("@mmm", SqlDbType.NVarChar, 100);
        //    parm[8].Value = mmm;
        //    DAL.executecommand("updeat_export", parm);
        //    DAL.cloes();
        //}
        ////حذف وصل وارد
        //public void delete_ex(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_exports", parm);
        //    DAL.cloes();
        //}
        ////للتحقق من عدم تكرار id
        //public DataTable veri_id_ex(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("veri_id_ex", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////جلب مجموع الصادرات
        //public DataTable get_sum()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("ch_export", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////للبحث عن صادر
        //public DataTable serch_ex(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_ex", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////للبحث عن متدرب
        //public DataTable sum_serch_ex(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("sum_serch_ex", parm);
        //    DAL.cloes();
        //    return Dt;
        //}

        ////للبحث عن صادر
        //public DataTable check(decimal id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@amount", SqlDbType.Decimal, 10 - 2);
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("ch", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////جلب مجموع الواردات
        //public DataTable get_sum_export()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("ch_export", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////جلب مجموع الواردات
        //public DataTable get_sum_import()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("ch", null);
        //    DAL.cloes();
        //    return dt;
        //}


        public class ExportService
        {
            private DAL.data_access_layar DAL;

            public ExportService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_name_rate()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_reate", null);
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

            public DataTable get_exports()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_ex", null);
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

            public void add_export(string namee, decimal amount_d, decimal amount_t, string rete, string id_m, string city, string data_ex, string mmm)
            {
                try
                {

                    DAL.data_access_layar DAL = new DAL.data_access_layar();
                    DAL.open();
                    SqlParameter[] parm = new SqlParameter[8];
                    parm[0] = new SqlParameter("@name_ex", SqlDbType.NVarChar, 100);
                    parm[0].Value = namee;

                    parm[1] = new SqlParameter("@amont_d", SqlDbType.Decimal, 10 - 2);
                    parm[1].Value = amount_d;

                    parm[2] = new SqlParameter("@amont_t", SqlDbType.Decimal, 10 - 2);
                    parm[2].Value = amount_t;

                    parm[3] = new SqlParameter("@rate_ex", SqlDbType.NVarChar, 100);
                    parm[3].Value = rete;

                    parm[4] = new SqlParameter("@id_m", SqlDbType.Int);
                    parm[4].Value = id_m;

                    parm[5] = new SqlParameter("@city_ex", SqlDbType.NVarChar, 100);
                    parm[5].Value = city;

                    parm[6] = new SqlParameter("@date_ex", SqlDbType.Date);
                    parm[6].Value = data_ex;

                    parm[7] = new SqlParameter("@mm", SqlDbType.NVarChar, 100);
                    parm[7].Value = mmm;
                    DAL.executecommand("insert_exports", parm);
                    DAL.cloes();
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

            public void updet_expors(string id, string namee, decimal amount_d, decimal amount_t, string rete, string id_m, string city, string data_ex, string mmm)
            {
                try
                {
                    DAL.data_access_layar DAL = new DAL.data_access_layar();
                    DAL.open();
                    SqlParameter[] parm = new SqlParameter[9];
                    parm[0] = new SqlParameter("@id_ex", SqlDbType.Int);
                    parm[0].Value = id;

                    parm[1] = new SqlParameter("@name_ex", SqlDbType.NVarChar, 100);
                    parm[1].Value = namee;

                    parm[2] = new SqlParameter("@amont_d", SqlDbType.Decimal, 10 - 2);
                    parm[2].Value = amount_d;

                    parm[3] = new SqlParameter("@amont_t", SqlDbType.Decimal, 10 - 2);
                    parm[3].Value = amount_t;

                    parm[4] = new SqlParameter("@rate_ex", SqlDbType.NVarChar, 100);
                    parm[4].Value = rete;

                    parm[5] = new SqlParameter("@id_d", SqlDbType.Int);
                    parm[5].Value = id_m;

                    parm[6] = new SqlParameter("@city_ex", SqlDbType.NVarChar, 100);
                    parm[6].Value = city;

                    parm[7] = new SqlParameter("@date_ex", SqlDbType.Date);
                    parm[7].Value = data_ex;

                    parm[8] = new SqlParameter("@mmm", SqlDbType.NVarChar, 100);
                    parm[8].Value = mmm;
                    DAL.executecommand("updeat_export", parm);
                    DAL.cloes();
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

            public void delete_ex(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_exports", parameters);
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

            public DataTable veri_id_ex(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("veri_id_ex", parameters);
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

            public DataTable get_sum()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("ch_export", null);
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

            public DataTable serch_ex(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.VarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_ex", parameters);
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

            //public DataTable sum_serch_ex(decimal amount)
            //{
            //    DataTable dt = new DataTable();
            //    try
            //    {
            //        DAL.open();
            //        SqlParameter[] parameters = new SqlParameter[1];
            //        parameters[0] = new SqlParameter("@amount", SqlDbType.Decimal, 10, 2);
            //        parameters[0].Value = amount;

            //        dt = DAL.selectdata("ch", parameters);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("An error occurred: " + ex.Message);
            //        // يمكنك معالجة الاستثناء هنا أو إعادة إلقاءه بمعالجة خاصة.
            //    }
            //    finally
            //    {
            //        DAL.cloes();
            //    }
            //    return dt;
            //}

            public DataTable sum_serch_ex(string id)
            {
                DAL.data_access_layar DAL = new DAL.data_access_layar();
                DataTable Dt = new DataTable();
                SqlParameter[] parm = new SqlParameter[1];
                parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
                parm[0].Value = id;
                Dt = DAL.selectdata("sum_serch_ex", parm);
                DAL.cloes();
                return Dt;
            }

            public DataTable get_sum_export()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("ch_export", null);
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

            public DataTable get_sum_import()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("ch", null);
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


            public DataTable check(decimal id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@amount", SqlDbType.Decimal, 10 - 2);
            parm[0].Value = id;
            Dt = DAL.selectdata("ch", parm);
            DAL.cloes();
            return Dt;
        }
        }

    }
}
