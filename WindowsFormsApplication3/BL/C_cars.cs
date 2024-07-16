using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class C_cars
    {
       
            
            
            
        ////اضافة سيارة
        //public void add_car( string name_car, string typecar, string num_car, string name_mstlm,string jah)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
            

        //    parm[0] = new SqlParameter("@name_car", SqlDbType.NVarChar,50);
        //    parm[0].Value = name_car;

        //    parm[1] = new SqlParameter("@type_car", SqlDbType.NVarChar,30);
        //    parm[1].Value = typecar;

        //    parm[2] = new SqlParameter("@num_car", SqlDbType.NVarChar,20);
        //    parm[2].Value = num_car;

        //    parm[3] = new SqlParameter("@name_mstlm", SqlDbType.NVarChar,30);
        //    parm[3].Value = name_mstlm;

        //    parm[4] = new SqlParameter("@jah", SqlDbType.NVarChar, 50);
        //    parm[4].Value = jah;

        //    DAL.executecommand("insert_tr", parm);
        //    DAL.cloes();
        //}
       
        ////عرض البيانات
        //public DataTable get_car()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("select_car", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////بحث عن البيانات
        //public DataTable serch_car(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar,(50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_car", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////حذف السيارة
        //public void delete_car(string id_car)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id_car", SqlDbType.Int);
        //    parm[0].Value = id_car;

        //    DAL.executecommand("delete_car", parm);
        //    DAL.cloes();
        //}
        ////تعديل بيانات سيارة
        //public void update_car(int id_car, string name_car, string typecar, string num_car, string name_mstlm,string jah)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[6];
        //    parm[0] = new SqlParameter("@id_car", SqlDbType.Int);
        //    parm[0].Value = id_car;

        //    parm[1] = new SqlParameter("@name_car", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name_car;

        //    parm[2] = new SqlParameter("@type_car", SqlDbType.NVarChar, 30);
        //    parm[2].Value = typecar;

        //    parm[3] = new SqlParameter("@num_car", SqlDbType.NVarChar, 20);
        //    parm[3].Value = num_car;

        //    parm[4] = new SqlParameter("@name_mstlm", SqlDbType.NVarChar, 30);
        //    parm[4].Value = name_mstlm;

        //    parm[5] = new SqlParameter("@jah", SqlDbType.NVarChar, 50);
        //    parm[5].Value = jah;

        //    DAL.executecommand("ubdate_car", parm);
        //    DAL.cloes();
        //}
        ////لتعبئة اسماء الجاهزية في الكومبو بكس
        //public DataTable get_name_jhz()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_jah", null);
        //    DAL.cloes();
        //    return Dt;
        //}

        public class CarService
        {
            private DAL.data_access_layar DAL;

            public CarService()
            {
                DAL = new DAL.data_access_layar();
            }

            public void add_car(string name_car, string typecar, string num_car, string name_mstlm, string jah)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[5];

                    parameters[0] = new SqlParameter("@name_car", SqlDbType.NVarChar, 50);
                    parameters[0].Value = name_car;

                    parameters[1] = new SqlParameter("@type_car", SqlDbType.NVarChar, 30);
                    parameters[1].Value = typecar;

                    parameters[2] = new SqlParameter("@num_car", SqlDbType.NVarChar, 20);
                    parameters[2].Value = num_car;

                    parameters[3] = new SqlParameter("@name_mstlm", SqlDbType.NVarChar, 30);
                    parameters[3].Value = name_mstlm;

                    parameters[4] = new SqlParameter("@jah", SqlDbType.NVarChar, 50);
                    parameters[4].Value = jah;

                    DAL.executecommand("insert_tr", parameters);
                 
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

            public DataTable get_car()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("select_car", null);
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

            public DataTable serch_car(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.VarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_car", parameters);
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

            public void delete_car(string id_car)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id_car", SqlDbType.Int);
                    parameters[0].Value = id_car;

                    DAL.executecommand("delete_car", parameters);
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

            public void update_car(int id_car, string name_car, string typecar, string num_car, string name_mstlm, string jah)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[6];
                    parameters[0] = new SqlParameter("@id_car", SqlDbType.Int);
                    parameters[0].Value = id_car;

                    parameters[1] = new SqlParameter("@name_car", SqlDbType.NVarChar, 50);
                    parameters[1].Value = name_car;

                    parameters[2] = new SqlParameter("@type_car", SqlDbType.NVarChar, 30);
                    parameters[2].Value = typecar;

                    parameters[3] = new SqlParameter("@num_car", SqlDbType.NVarChar, 20);
                    parameters[3].Value = num_car;

                    parameters[4] = new SqlParameter("@name_mstlm", SqlDbType.NVarChar, 30);
                    parameters[4].Value = name_mstlm;

                    parameters[5] = new SqlParameter("@jah", SqlDbType.NVarChar, 50);
                    parameters[5].Value = jah;

                    DAL.executecommand("ubdate_car", parameters);
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

            public DataTable GetJahNames()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_jah", null);
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
