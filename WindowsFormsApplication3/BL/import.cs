using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class import
    {
        //public void add_import(int id, decimal amount_full, decimal amount, string setll, string coment,string date_add,int id_tr)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[7];
        //    parm[0] = new SqlParameter("@id_m", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@amount_full", SqlDbType.Decimal,10-2);
        //    parm[1].Value = amount_full;

        //    parm[2] = new SqlParameter("@amount_paid", SqlDbType.Decimal,10-2);
        //    parm[2].Value = amount;

        //    parm[3] = new SqlParameter("@settle", SqlDbType.NVarChar, 50);
        //    parm[3].Value = setll;

           

        //    parm[4] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
        //    parm[4].Value = coment;

        //    parm[5] = new SqlParameter("@date_add", SqlDbType.Date);
        //    parm[5].Value = date_add;

        //    parm[6] = new SqlParameter("@id_tr", SqlDbType.Int);
        //    parm[6].Value = id_tr;
        //    DAL.executecommand("insert_imm", parm);
        //    DAL.cloes();
        //}
        ////لجلب البيانات وتحديثها في جدول الواردات
        //public DataTable get_import()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("select_import", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public void updet_import(int id, string amount_full, string amount, string setll, string coment, string date_add, int id_tr)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[6];
        //    parm[0] = new SqlParameter("@id_m", SqlDbType.Int);
        //    parm[0].Value = id;

        //    parm[1] = new SqlParameter("@amount_full", SqlDbType.NVarChar,50);
        //    parm[1].Value = amount_full;

        //    parm[2] = new SqlParameter("@amount_paid", SqlDbType.NVarChar,50);
        //    parm[2].Value = amount;

        //    parm[3] = new SqlParameter("@settle", SqlDbType.NVarChar, 50);
        //    parm[3].Value = setll;

        //    parm[4] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
        //    parm[4].Value = coment;

        //    parm[5] = new SqlParameter("@date_add", SqlDbType.Date);
        //    parm[5].Value = date_add;

           
        //    DAL.executecommand("updeat_importe", parm);
        //    DAL.cloes();
        //}
        ////حذف وصل وارد
        //public void delete_tr(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;

        //    DAL.executecommand("delete_import", parm);
        //    DAL.cloes();
        //}
        ////لجلب اكبر id+1
        //public DataTable get_id_max()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("get_max_import", null);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////للتحقق من عدم تكرار id
        //public DataTable veri_id_import(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("veri_id_import", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        //public DataTable summm()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    Dt = DAL.selectdata("sum_im", null);
        //    DAL.cloes();
        //    return Dt;
        //}
        


        //public DataTable data_tr()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("get_data_tr", null);
        //    DAL.cloes();
        //    return dt;
        //}
        //public DataTable summmmmmmmm()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("insert_sum", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////للبحث عن وارد
        //public DataTable serch_import(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_import", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        //public DataTable serch_data_tr(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_data_tr", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        //public DataTable get_sal_dwra(int sal)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@aaa", SqlDbType.Int);
        //    parm[0].Value = sal;
        //    Dt = DAL.selectdata("sal_dwra", parm);
        //    DAL.cloes();
        //    return Dt;
        //}


        public class ImportService
        {
            private DAL.data_access_layar DAL;

            public ImportService()
            {
                DAL = new DAL.data_access_layar();
            }

            public void add_import(int id, decimal amount_full, decimal amount, string setll, string coment, string date_add, int id_tr)
            {
                try
                {
                    DAL.data_access_layar DAL = new DAL.data_access_layar();
                    DAL.open();
                    SqlParameter[] parm = new SqlParameter[7];
                    parm[0] = new SqlParameter("@id_m", SqlDbType.Int);
                    parm[0].Value = id;

                    parm[1] = new SqlParameter("@amount_full", SqlDbType.Decimal, 10 - 2);
                    parm[1].Value = amount_full;

                    parm[2] = new SqlParameter("@amount_paid", SqlDbType.Decimal, 10 - 2);
                    parm[2].Value = amount;

                    parm[3] = new SqlParameter("@settle", SqlDbType.NVarChar, 50);
                    parm[3].Value = setll;



                    parm[4] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
                    parm[4].Value = coment;

                    parm[5] = new SqlParameter("@date_add", SqlDbType.Date);
                    parm[5].Value = date_add;

                    parm[6] = new SqlParameter("@id_tr", SqlDbType.Int);
                    parm[6].Value = id_tr;
                    DAL.executecommand("insert_imm", parm);
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

            public DataTable get_import()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("select_import", null);
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

            public void updet_import(int id, string amount_full, string amount, string setll, string coment, string date_add, int id_tr)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[6];
                    parameters[0] = new SqlParameter("@id_m", SqlDbType.Int);
                    parameters[0].Value = id;

                    parameters[1] = new SqlParameter("@amount_full", SqlDbType.NVarChar, 50);
                    parameters[1].Value = amount_full;

                    parameters[2] = new SqlParameter("@amount_paid", SqlDbType.NVarChar, 50);
                    parameters[2].Value = amount;

                    parameters[3] = new SqlParameter("@settle", SqlDbType.NVarChar, 50);
                    parameters[3].Value = setll;

                    parameters[4] = new SqlParameter("@comment", SqlDbType.NVarChar, 50);
                    parameters[4].Value = coment;

                    parameters[5] = new SqlParameter("@date_add", SqlDbType.Date);
                    parameters[5].Value = date_add;

                    DAL.executecommand("updeat_importe", parameters);
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

            public void delete_tr(string id)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    DAL.executecommand("delete_import", parameters);
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

            public DataTable get_id_max()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_max_import", null);
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

            public DataTable veri_id_import(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("veri_id_import", parameters);
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

            public DataTable summm()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("sum_im", null);
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

            public DataTable data_tr()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("get_data_tr", null);
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

            public DataTable summmmmmmmm()
            {
                DataTable dt = new DataTable();
                try
                {
                    dt = DAL.selectdata("insert_sum", null);
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

            public DataTable serch_import(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.VarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_import", parameters);
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

            public DataTable serch_data_tr(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.VarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_data_tr", parameters);
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

            public DataTable get_sal_dwra(int sal)
            {
                DataTable dt = new DataTable();
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@aaa", SqlDbType.Int);
                    parameters[0].Value = sal;

                    dt = DAL.selectdata("sal_dwra", parameters);
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
