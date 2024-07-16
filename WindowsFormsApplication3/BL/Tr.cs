using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Tr

    {

        //لتعبئة اسماء الوكلاء في الكومبو بكس
        public DataTable get_name_agent()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_name_agent", null);
            DAL.cloes();
            return Dt;
        }

        //لجلب اكبر id+1
        public DataTable get_id_max()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_max", null);
            DAL.cloes();
            return Dt;
        }
        //اضافة متدرب 
        public void add_tr(int id, string namee, string name_fa, string knya, string famil, string id_cart, string city_prith, string date_prith, string city, string tayp_rks, string date_add, int name_agent, byte[] imm, string rgs)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[14];
            parm[0] = new SqlParameter("@id_tr", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@name_tr", SqlDbType.NVarChar, 30);
            parm[1].Value = namee;

            parm[2] = new SqlParameter("@name_fa", SqlDbType.NVarChar, 30);
            parm[2].Value = name_fa;

            parm[3] = new SqlParameter("@knya", SqlDbType.NVarChar, 30);
            parm[3].Value = knya;

            parm[4] = new SqlParameter("@famil", SqlDbType.NVarChar, 30);
            parm[4].Value = famil;

            parm[5] = new SqlParameter("@id_cart", SqlDbType.NVarChar, 50);
            parm[5].Value = id_cart;

            parm[6] = new SqlParameter("@city_brith", SqlDbType.NVarChar, 30);
            parm[6].Value = city_prith;

            parm[7] = new SqlParameter("@date_brith", SqlDbType.Date);
            parm[7].Value = date_prith;

            parm[8] = new SqlParameter("@city", SqlDbType.NVarChar, 30);
            parm[8].Value = city;





            parm[9] = new SqlParameter("@type_r", SqlDbType.NVarChar, 30);
            parm[9].Value = tayp_rks;

            parm[10] = new SqlParameter("@date_add", SqlDbType.Date);
            parm[10].Value = date_add;



            parm[11] = new SqlParameter("@id_agent", SqlDbType.Int);
            parm[11].Value = name_agent;

            parm[12] = new SqlParameter("@image_tr", SqlDbType.Image);
            parm[12].Value = imm;

            parm[13] = new SqlParameter("@crs", SqlDbType.NVarChar, 50);
            parm[13].Value = rgs;
            DAL.executecommand("insert_trrr", parm);
            DAL.cloes();
        }
        //للتحقق من عدم تكرار id
        public DataTable veri_id_tr(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            Dt = DAL.selectdata("veri_id_tr", parm);
            DAL.cloes();
            return Dt;
        }
        public DataTable get_tr()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_tr", null);
            DAL.cloes();
            return dt;
        }

        ////////////////////////////////////////////////////////
        public DataTable get_trrrr()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_tr_", null);
            DAL.cloes();
            return dt;
        }
        //اضافة الى رقم الهاتف
        public void insert_ephon(int id, string ea, string eb)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@ea", SqlDbType.NVarChar, 30);
            parm[1].Value = ea;

            parm[2] = new SqlParameter("@eb", SqlDbType.NVarChar, 30);
            parm[2].Value = eb;
            DAL.executecommand("ephon_trr", parm);
            DAL.cloes();
        }
        //حذف متدرب
        public void delete_tr(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            DAL.executecommand("delete_tr", parm);
            DAL.cloes();
        }
        //تعديل بيانات متدرب

        public void update_tr(int id, string namee, string name_fa, string knya, string famil, string id_cart, string city_prith, string date_prith, string city, string tayp_rks, string date_add, int name_agent, byte[] imm, string rgs)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[14];
            parm[0] = new SqlParameter("@id_tr", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@name_tr", SqlDbType.NVarChar, 30);
            parm[1].Value = namee;

            parm[2] = new SqlParameter("@name_fa", SqlDbType.NVarChar, 30);
            parm[2].Value = name_fa;

            parm[3] = new SqlParameter("@knya", SqlDbType.NVarChar, 30);
            parm[3].Value = knya;

            parm[4] = new SqlParameter("@famil", SqlDbType.NVarChar, 30);
            parm[4].Value = famil;

            parm[5] = new SqlParameter("@id_cart", SqlDbType.NVarChar, 50);
            parm[5].Value = id_cart;

            parm[6] = new SqlParameter("@city_brith", SqlDbType.NVarChar, 30);
            parm[6].Value = city_prith;

            parm[7] = new SqlParameter("@date_brith", SqlDbType.Date);
            parm[7].Value = date_prith;

            parm[8] = new SqlParameter("@city", SqlDbType.NVarChar, 30);
            parm[8].Value = city;





            parm[9] = new SqlParameter("@type_r", SqlDbType.NVarChar, 30);
            parm[9].Value = tayp_rks;

            parm[10] = new SqlParameter("@date_add", SqlDbType.Date);
            parm[10].Value = date_add;



            parm[11] = new SqlParameter("@id_agent", SqlDbType.Int);
            parm[11].Value = name_agent;

            parm[12] = new SqlParameter("@image_tr", SqlDbType.Image);
            parm[12].Value = imm;

            parm[13] = new SqlParameter("@cre", SqlDbType.NVarChar, 50);
            parm[13].Value = rgs;
            DAL.executecommand("update_tr", parm);
            DAL.cloes();
        }
        //تعديل الى رقم الهاتف
        public void update_ephon(int id, string ea, string eb)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@id_tr", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@ea", SqlDbType.NVarChar, 30);
            parm[1].Value = ea;

            parm[2] = new SqlParameter("@eb", SqlDbType.NVarChar, 30);
            parm[2].Value = eb;
            DAL.executecommand("update_ephon", parm);
            DAL.cloes();
        }
        //للبحث عن متدرب
        public DataTable serch_tr(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_tr", parm);
            DAL.cloes();
            return Dt;
        }

        //تعديل الى رقم الهاتف
        public void update_erlech(int id_t, int id_d, string eb)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[3];
            parm[0] = new SqlParameter("@id_t", SqlDbType.Int);
            parm[0].Value = id_t;

            parm[1] = new SqlParameter("@id_d", SqlDbType.Int);
            parm[1].Value = id_d;

            parm[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            parm[2].Value = eb;
            DAL.executecommand("ubdet_dwra_tr", parm);
            DAL.cloes();
        }
        //حذف متدرب
        public void delet_re(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            DAL.executecommand("delet_re", parm);
            DAL.cloes();
        }

        //تقرير مديرية النقل
        //public DataTable sport(string id, string fam)
        //{
        //    DAL.data_access_layar DAL = new DAL.data_access_layar();
        //    DataTable Dt = new DataTable();
        //    SqlParameter[] parm = new SqlParameter[2];
        //    parm[0] = new SqlParameter("@name_dwra", SqlDbType.NVarChar, (100));
        //    parm[0].Value = id;
        //    parm[1] = new SqlParameter("@famill", SqlDbType.NVarChar, (50));
        //    parm[1].Value = fam;

        //    Dt = DAL.selectdata("get_select_transportt", parm);
        //    DAL.cloes();
        //    return Dt;
        //}
        public DataTable get_sport()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("get_select_transp", null);
            DAL.cloes();
            return dt;
        }
        public DataTable get_trt()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("report_tr_ol", null);
            DAL.cloes();
            return dt;
        }
        //للبحث عن متدرب
        public DataTable serch_tr_name(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_tr_name", parm);
            DAL.cloes();
            return Dt;
        }
        public DataTable serch_data_tr(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_data_tr", parm);
            DAL.cloes();
            return Dt;
        }
    }
}
