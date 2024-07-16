using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication3.BL
{
    class daily
    {
        ////عرض البيانات
        //public DataTable get_dwra()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_name_dwra", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public DataTable get_name_dey()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_day", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public DataTable get_daily()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_daily", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public DataTable get_name_cars()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_name_car", null);
        //    DAL.cloes();
        //    return dt;
        //}
       

        //public DataTable get_name_triner()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_name_triner_dily", null);
        //    DAL.cloes();
        //    return dt;
        //}

        //public DataTable get_name_tr(int id,string dd)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[2];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@typee", SqlDbType.NVarChar,50);
        //    parm[1].Value = dd;

        //    Dt = DAL.selectdata("get_name_tr_dily", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////اضافة مدرب
        //public void insert_daily(int id_tr, int id_triner, int id_car, string val, int id_dey, string date, string check )
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[7];
        //    parm[0] = new SqlParameter("@id_tr", SqlDbType.Int);
        //    parm[0].Value = id_tr;

        //    parm[1] = new SqlParameter("@id_triner", SqlDbType.Int);
        //    parm[1].Value = id_triner;

        //    parm[2] = new SqlParameter("@id_car", SqlDbType.Int);
        //    parm[2].Value = id_car;

        //    parm[3] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
        //    parm[3].Value = val;

        //    parm[4] = new SqlParameter("@id_dey", SqlDbType.Int);
        //    parm[4].Value = id_dey;

        //    parm[5] = new SqlParameter("@date", SqlDbType.Date);
        //    parm[5].Value = date;

        //    parm[6] = new SqlParameter("@chrch", SqlDbType.NVarChar,50);
        //    parm[6].Value = check;

           
        //    DAL.executecommand("insert_daily", parm);
        //    DAL.cloes();
        //}
        ////اضافة مدرب
        //public void update_daily(int id,int id_tr, int id_triner, int id_car, string val, int id_dey, string date, string check)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[8];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@id_tr", SqlDbType.Int);
        //    parm[1].Value = id_tr;

        //    parm[2] = new SqlParameter("@id_triner", SqlDbType.Int);
        //    parm[2].Value = id_triner;

        //    parm[3] = new SqlParameter("@id_car", SqlDbType.Int);
        //    parm[3].Value = id_car;

        //    parm[4] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
        //    parm[4].Value = val;

        //    parm[5] = new SqlParameter("@id_dey", SqlDbType.Int);
        //    parm[5].Value = id_dey;

        //    parm[6] = new SqlParameter("@date", SqlDbType.Date);
        //    parm[6].Value = date;

        //    parm[7] = new SqlParameter("@chrch", SqlDbType.NVarChar, 50);
        //    parm[7].Value = check;


        //    DAL.executecommand("update_daily", parm);
        //    DAL.cloes();
        //}
        //public void delete_daily(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_daily", parm);
        //    DAL.cloes();
        //}
        //public DataTable serch_daily(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.NVarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_daily", parm);
        //    DAL.cloes();
        //    return Dt;
        //}


        public class DailyService
        {
            private DAL.data_access_layar DAL;

            public DailyService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_dwra()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_dwra", null);
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

            public DataTable get_name_dey()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_day", null);
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

            public DataTable get_daily()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_daily", null);
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

            public DataTable get_name_cars()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_car", null);
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

            public DataTable get_name_triner()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_name_triner_dily", null);
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

            public DataTable get_name_tr(int id, string dd)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[2];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@typee", SqlDbType.NVarChar, 50);
                    parameters[1].Value = dd;

                    dt = DAL.selectdata("get_name_tr_dily", parameters);
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

            public void insert_daily(int id_tr, int id_triner, int id_car, string val, int id_dey, string date, string check)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[7];
                    parameters[0] = new SqlParameter("@id_tr", SqlDbType.Int);
                    parameters[0].Value = id_tr;

                    parameters[1] = new SqlParameter("@id_triner", SqlDbType.Int);
                    parameters[1].Value = id_triner;

                    parameters[2] = new SqlParameter("@id_car", SqlDbType.Int);
                    parameters[2].Value = id_car;

                    parameters[3] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
                    parameters[3].Value = val;

                    parameters[4] = new SqlParameter("@id_dey", SqlDbType.Int);
                    parameters[4].Value = id_dey;

                    parameters[5] = new SqlParameter("@date", SqlDbType.Date);
                    parameters[5].Value = date;

                    parameters[6] = new SqlParameter("@chrch", SqlDbType.NVarChar, 50);
                    parameters[6].Value = check;

                    DAL.executecommand("insert_daily", parameters);
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

            public void update_daily(int id, int id_tr, int id_triner, int id_car, string val, int id_dey, string date, string check)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[8];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@id_tr", SqlDbType.Int);
                    parameters[1].Value = id_tr;

                    parameters[2] = new SqlParameter("@id_triner", SqlDbType.Int);
                    parameters[2].Value = id_triner;

                    parameters[3] = new SqlParameter("@id_car", SqlDbType.Int);
                    parameters[3].Value = id_car;

                    parameters[4] = new SqlParameter("@val", SqlDbType.NVarChar, 50);
                    parameters[4].Value = val;

                    parameters[5] = new SqlParameter("@id_dey", SqlDbType.Int);
                    parameters[5].Value = id_dey;

                    parameters[6] = new SqlParameter("@date", SqlDbType.Date);
                    parameters[6].Value = date;

                    parameters[7] = new SqlParameter("@chrch", SqlDbType.NVarChar, 50);
                    parameters[7].Value = check;

                    DAL.executecommand("update_daily", parameters);
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

            public void delete_daily(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_daily", parameters);
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

            public DataTable serch_daily(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.NVarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_daily", parameters);
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
