using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication3.BL
{
    class Rejestery
    {
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
        //لجلب اكبر id+1
        public DataTable get_id_max()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_max_regestry", null);
            DAL.cloes();
            return Dt;
        }
        //لتعبئة اسماء المتدربين في الكومبو بكس
        public DataTable get_name_tr()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_name_t", null);
            DAL.cloes();
            return Dt;
        }
        //لتعبئة اسماء المدربين في الكومبو بكس
        public DataTable get_name_triner()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_name_trinerr", null);
            DAL.cloes();
            return Dt;
        }
        //لتعبئة اسماء الدورات في الكومبو بكس
        public DataTable get_name_dwra()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_name_d", null);
            DAL.cloes();
            return Dt;
        }
        //لتعبئة اسماء نوع التسجيل في الكومبو بكس
        public DataTable get_name_tsgel()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_name_tsgel", null);
            DAL.cloes();
            return Dt;
        }
        //لجلب البيانات وتحديثها
        public DataTable get_regestry()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_regesrty", null);
            DAL.cloes();
            return Dt;
        }
        //اضافة تفاصيل التسجيل
        public void add_regestry(int name_tr, int name_dwra, string typee, string data)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[4];
            parm[0] = new SqlParameter("@id_t", SqlDbType.Int);
            parm[0].Value = name_tr;

            parm[1] = new SqlParameter("@id_d", SqlDbType.Int);
            parm[1].Value = name_dwra;

            parm[2] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            parm[2].Value = typee;

            parm[3] = new SqlParameter("@date_regestry", SqlDbType.Date);
            parm[3].Value = data;



            DAL.executecommand("insert_reg", parm);
            DAL.cloes();
        }

        //تعديل تفاصيل التسجيل
        public void update_regestry(int id, int name_tr, int name_dwra, string typee, string data)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[5];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@id_t", SqlDbType.Int);
            parm[1].Value = name_tr;

            parm[2] = new SqlParameter("@id_d", SqlDbType.Int);
            parm[2].Value = name_dwra;

            parm[3] = new SqlParameter("@type", SqlDbType.NVarChar, 50);
            parm[3].Value = typee;

            parm[4] = new SqlParameter("@date_regestryy", SqlDbType.Date);
            parm[4].Value = data;



            DAL.executecommand("update_reg", parm);
            DAL.cloes();
        }
        //حذف تفاصيل التسجيل
        public void delete_reg(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;



            DAL.executecommand("delete_reg", parm);
            DAL.cloes();
        }
        //للبحث عن تفاصيل تسجيل متدرب
        public DataTable serch_ex(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.NVarChar, (100));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_reg", parm);
            DAL.cloes();
            return Dt;
        }
        //  باسم للبحث عن تفاصيل تسجيل متدرب
        public DataTable serch_ex_name(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.NVarChar, (100));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_reg_name", parm);
            DAL.cloes();
            return Dt;
        }

  
        }

}
