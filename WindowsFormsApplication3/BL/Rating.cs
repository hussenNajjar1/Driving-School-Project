using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Rating
    {
        //public DataTable get_dwra()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_name_dwra", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public DataTable get_name_tr(int id, string dd)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[2];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@typee", SqlDbType.NVarChar, 50);
        //    parm[1].Value = dd;

        //    Dt = DAL.selectdata("get_name_tr_dily", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////اضافة مدرب
        //public void insert_ratings(int id_regstry, string thero, string parc, string attend, string cona, string pur)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[6];
        //    parm[0] = new SqlParameter("@id_regestry", SqlDbType.Int);
        //    parm[0].Value = id_regstry;

        //    parm[1] = new SqlParameter("@theorticalExaminationonRate", SqlDbType.NVarChar,50);
        //    parm[1].Value = thero;

        //    parm[2] = new SqlParameter("@parctiacalExamintionRate", SqlDbType.NVarChar,50);
        //    parm[2].Value = parc;

        //    parm[3] = new SqlParameter("@attendanceRate", SqlDbType.NVarChar, 50);
        //    parm[3].Value = attend;

        //    parm[4] = new SqlParameter("@conachNothes", SqlDbType.NVarChar,50);
        //    parm[4].Value = cona;

        //    parm[5] = new SqlParameter("@purifcation", SqlDbType.NVarChar,50);
        //    parm[5].Value = pur;

        //    DAL.executecommand("insert_rating", parm);
        //    DAL.cloes();
        //}
        //public DataTable get_ratings()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_ratings", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////تعديل مدرب
        //public void update_ratings(int id,int id_regstry, string thero, string parc, string attend, string cona, string pur)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[7];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@id_regestry", SqlDbType.Int);
        //    parm[1].Value = id_regstry;

        //    parm[2] = new SqlParameter("@theorticalExaminationonRate", SqlDbType.NVarChar, 50);
        //    parm[2].Value = thero;

        //    parm[3] = new SqlParameter("@parctiacalExamintionRate", SqlDbType.NVarChar, 50);
        //    parm[3].Value = parc;

        //    parm[4] = new SqlParameter("@attendanceRate", SqlDbType.NVarChar, 50);
        //    parm[4].Value = attend;

        //    parm[5] = new SqlParameter("@conachNothes", SqlDbType.NVarChar, 50);
        //    parm[5].Value = cona;

        //    parm[6] = new SqlParameter("@purifcation", SqlDbType.NVarChar, 50);
        //    parm[6].Value = pur;

        //    DAL.executecommand("update_ratings", parm);
        //    DAL.cloes();
        //}
        ////حذف متدرب
        //public void delet_ratings(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_ratings", parm);
        //    DAL.cloes();
        //}
        //public DataTable serch_rating(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.NVarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_rtings", parm);
        //    DAL.cloes();
        //    return Dt;
        //}



        public class RatingService

         {

            public DataTable get_name_tr(int id, string dd)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[2];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@typee", SqlDbType.NVarChar, 50);
            parm[1].Value = dd;

            Dt = DAL.selectdata("get_name_tr_dily", parm);
            DAL.cloes();
            return Dt;
        }

            private DAL.data_access_layar DAL;

            public RatingService()
            {
                DAL = new DAL.data_access_layar();
            }

            public DataTable get_dwra()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_ratings", null);
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

            public void insert_ratings(int id_registry, string theoretical, string practical, string attendance, string coachNotes, string purification)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[6];
                    parameters[0] = new SqlParameter("@id_regestry", SqlDbType.Int);
                    parameters[0].Value = id_registry;

                    parameters[1] = new SqlParameter("@theorticalExaminationonRate", SqlDbType.NVarChar, 50);
                    parameters[1].Value = theoretical;

                    parameters[2] = new SqlParameter("@parctiacalExamintionRate", SqlDbType.NVarChar, 50);
                    parameters[2].Value = practical;

                    parameters[3] = new SqlParameter("@attendanceRate", SqlDbType.NVarChar, 50);
                    parameters[3].Value = attendance;

                    parameters[4] = new SqlParameter("@conachNothes", SqlDbType.NVarChar, 50);
                    parameters[4].Value = coachNotes;

                    parameters[5] = new SqlParameter("@purifcation", SqlDbType.NVarChar, 50);
                    parameters[5].Value = purification;

                    DAL.executecommand("insert_rating", parameters);
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

            public void update_ratings(int id, int id_registry, string theoretical, string practical, string attendance, string coachNotes, string purification)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[7];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@id_regestry", SqlDbType.Int);
                    parameters[1].Value = id_registry;

                    parameters[2] = new SqlParameter("@theorticalExaminationonRate", SqlDbType.NVarChar, 50);
                    parameters[2].Value = theoretical;

                    parameters[3] = new SqlParameter("@parctiacalExamintionRate", SqlDbType.NVarChar, 50);
                    parameters[3].Value = practical;

                    parameters[4] = new SqlParameter("@attendanceRate", SqlDbType.NVarChar, 50);
                    parameters[4].Value = attendance;

                    parameters[5] = new SqlParameter("@conachNothes", SqlDbType.NVarChar, 50);
                    parameters[5].Value = coachNotes;

                    parameters[6] = new SqlParameter("@purifcation", SqlDbType.NVarChar, 50);
                    parameters[6].Value = purification;

                    DAL.executecommand("update_ratings", parameters);
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

            public void delet_ratings(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_ratings", parameters);
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

            public DataTable serch_rating(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.NVarChar, 50);
                    parameters[0].Value = id;
                    dt = DAL.selectdata("serch_rtings", parameters);
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
