using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Agent
    {
        ////اضافة وكيل
        //public void add_agent(int id_agent, string name_agent, string ephon, string loc, string jop)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
        //    parm[0] = new SqlParameter("@id_agent", SqlDbType.Int);
        //    parm[0].Value = id_agent;

        //    parm[1] = new SqlParameter("@name_agent", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name_agent;

        //    parm[2] = new SqlParameter("@ephon", SqlDbType.NVarChar, 30);
        //    parm[2].Value = ephon;

        //    parm[3] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
        //    parm[3].Value = loc;

        //    parm[4] = new SqlParameter("@jop", SqlDbType.NVarChar, 50);
        //    parm[4].Value = jop;

        //    DAL.executecommand("insert_agent", parm);
        //    DAL.cloes();
        //}
        ////تحديث بيانات وكيل
        //public DataTable get_agent()
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable dt = new DataTable();
        //    dt = DAL.selectdata("select_agent", null);
        //    DAL.cloes();
        //    return dt;
        //}
        ////حذف وكيل
        //public void delete_agent(string id_ag)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id_agent", SqlDbType.Int);
        //    parm[0].Value = id_ag;

        //    DAL.executecommand("delete_agent", parm);
        //    DAL.cloes();
        //}
        ////بحث عن وكيل
        //public DataTable serch_agent(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("serch_agent", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////للتحقق من عدم تكرار المفتاح الرئيسي
        //public DataTable veri_id(string id)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[1];
        //    parm[0] = new SqlParameter("@id", SqlDbType.Int);
        //    parm[0].Value = id;
        //    Dt = DAL.selectdata("veri_id", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        ////تعديل وكيل
        //public void updet_agent(int id_agent, string name_agent, string ephon, string loc, string jop)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DAL.open();
        //    SqlParameter[] parm = new SqlParameter[5];
        //    parm[0] = new SqlParameter("@id_agent", SqlDbType.Int);
        //    parm[0].Value = id_agent;

        //    parm[1] = new SqlParameter("@name_agent", SqlDbType.NVarChar, 50);
        //    parm[1].Value = name_agent;

        //    parm[2] = new SqlParameter("@ephon", SqlDbType.NVarChar, 30);
        //    parm[2].Value = ephon;

        //    parm[3] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
        //    parm[3].Value = loc;

        //    parm[4] = new SqlParameter("@jop", SqlDbType.NVarChar, 50);
        //    parm[4].Value = jop;

        //    DAL.executecommand("update_agent", parm);
        //    DAL.cloes();
        //}





        public class AgentService
        {
            private DAL.data_access_layar DAL;

            public AgentService()
            {
                DAL = new DAL.data_access_layar();
              
            }

            public void AddAgent(int id_agent, string name_agent, string ephon, string loc, string jop)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[5];

                    parameters[0] = new SqlParameter("@id_agent", SqlDbType.Int);
                    parameters[0].Value = id_agent;

                    parameters[1] = new SqlParameter("@name_agent", SqlDbType.NVarChar, 50);
                    parameters[1].Value = name_agent;

                    parameters[2] = new SqlParameter("@ephon", SqlDbType.NVarChar, 30);
                    parameters[2].Value = ephon;

                    parameters[3] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
                    parameters[3].Value = loc;

                    parameters[4] = new SqlParameter("@jop", SqlDbType.NVarChar, 50);
                    parameters[4].Value = jop;

                    DAL.executecommand("insert_agent", parameters);
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

            public DataTable GetAgents()
            {
                DataTable dt = new DataTable();
                try
                {
              
                    dt = DAL.selectdata("select_agent", null);
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

            public void DeleteAgent(string id_ag)
            {
                try
                {
                    DAL.open();
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id_agent", SqlDbType.Int);
                    parameters[0].Value = id_ag;

                    DAL.executecommand("delete_agent", parameters);
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

            public DataTable SearchAgent(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@serch", SqlDbType.VarChar, 50);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("serch_agent", parameters);
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

            public DataTable VerifyID(string id)
            {
                DataTable dt = new DataTable();
                try
                {
                    SqlParameter[] parameters = new SqlParameter[1];
                    parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                    parameters[0].Value = id;

                    dt = DAL.selectdata("veri_id", parameters);
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

            public void UpdateAgent(int id_agent, string name_agent, string ephon, string loc, string jop)
            {
                try
                {
                    DAL.cloes();
                    SqlParameter[] parameters = new SqlParameter[5];

                    parameters[0] = new SqlParameter("@id_agent", SqlDbType.Int);
                    parameters[0].Value = id_agent;

                    parameters[1] = new SqlParameter("@name_agent", SqlDbType.NVarChar, 50);
                    parameters[1].Value = name_agent;

                    parameters[2] = new SqlParameter("@ephon", SqlDbType.NVarChar, 30);
                    parameters[2].Value = ephon;

                    parameters[3] = new SqlParameter("@loc", SqlDbType.NVarChar, 50);
                    parameters[3].Value = loc;

                    parameters[4] = new SqlParameter("@jop", SqlDbType.NVarChar, 50);
                    parameters[4].Value = jop;

                    DAL.executecommand("update_agent", parameters);
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
