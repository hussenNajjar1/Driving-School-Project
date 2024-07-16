using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication3.BL
{
    class Trainer
    {//عرض وتحديث بيانات المتدربين
        public DataTable get_triner()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable dt = new DataTable();
            dt = DAL.selectdata("select_triner", null);
            DAL.cloes();
            return dt;
        }
        //اضافة مدرب
        public void add_triner(int id, string namee, string name_fa, string knya, string chhade,string ephon,string date_fa,string city ,string sal,string fam,string stite,string date_add,byte[] im, string crs)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[14];
            parm[0] = new SqlParameter("@id_triner", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@name_triner", SqlDbType.NVarChar, 30);
            parm[1].Value = namee;

            parm[2] = new SqlParameter("@name_fa", SqlDbType.NVarChar, 30);
            parm[2].Value = name_fa;

            parm[3] = new SqlParameter("@knua", SqlDbType.NVarChar, 30);
            parm[3].Value = knya;

            parm[4] = new SqlParameter("@certifcate", SqlDbType.NVarChar, 30);
            parm[4].Value = chhade;

            parm[5] = new SqlParameter("@ephon", SqlDbType.NVarChar, 20);
            parm[5].Value = ephon;

            parm[6] = new SqlParameter("@date_birth", SqlDbType.Date);
            parm[6].Value = date_fa;

            parm[7] = new SqlParameter("@city", SqlDbType.NVarChar, 30);
            parm[7].Value = city;

            parm[8] = new SqlParameter("@sal", SqlDbType.NVarChar,50);
            parm[8].Value = sal;

            parm[9] = new SqlParameter("@famil", SqlDbType.NVarChar, 10);
            parm[9].Value = fam;

            parm[10] = new SqlParameter("@marital_status", SqlDbType.NVarChar, 30);
            parm[10].Value = stite;

            parm[11] = new SqlParameter("@date_add", SqlDbType.Date);
            parm[11].Value = date_add;

            parm[12] = new SqlParameter("@imagee", SqlDbType.Image);
            parm[12].Value = im;

            parm[13] = new SqlParameter("@cre", SqlDbType.NVarChar, 50);
            parm[13].Value = crs;
            DAL.executecommand("insert_triner", parm);
            DAL.cloes();
        }
        //تعديل بيانات متدرب
        public void updaet_triner(int id, string namee, string name_fa, string knya, string chhade, string ephon, string date_fa, string city, string sal, string fam, string stite, string date_add, byte[] im, string crs)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[14];
            parm[0] = new SqlParameter("@id_triner", SqlDbType.Int);
            parm[0].Value = id;

            parm[1] = new SqlParameter("@name_triner", SqlDbType.NVarChar, 30);
            parm[1].Value = namee;

            parm[2] = new SqlParameter("@name_fa", SqlDbType.NVarChar, 30);
            parm[2].Value = name_fa;

            parm[3] = new SqlParameter("@knua", SqlDbType.NVarChar, 30);
            parm[3].Value = knya;

            parm[4] = new SqlParameter("@certifcate", SqlDbType.NVarChar, 30);
            parm[4].Value = chhade;

            parm[5] = new SqlParameter("@ephon", SqlDbType.NVarChar, 20);
            parm[5].Value = ephon;

            parm[6] = new SqlParameter("@date_birth", SqlDbType.Date);
            parm[6].Value = date_fa;

            parm[7] = new SqlParameter("@city", SqlDbType.NVarChar, 30);
            parm[7].Value = city;

            parm[8] = new SqlParameter("@sal", SqlDbType.NVarChar, 50);
            parm[8].Value = sal;

            parm[9] = new SqlParameter("@famil", SqlDbType.NVarChar, 10);
            parm[9].Value = fam;

            parm[10] = new SqlParameter("@marital_status", SqlDbType.NVarChar, 30);
            parm[10].Value = stite;

            parm[11] = new SqlParameter("@date_add", SqlDbType.Date);
            parm[11].Value = date_add;

            parm[12] = new SqlParameter("@imagee", SqlDbType.Image);
            parm[12].Value = im;

            parm[13] = new SqlParameter("@cre", SqlDbType.NVarChar, 50);
            parm[13].Value = crs;


            DAL.executecommand("updaet_triner", parm);
            DAL.cloes();
        }
        //حذف مدرب
        public void delete_triner(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DAL.open();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;

            DAL.executecommand("delete_triner", parm);
            DAL.cloes();
        }
        public DataTable serch_triner(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@serch", SqlDbType.VarChar, (50));
            parm[0].Value = id;
            Dt = DAL.selectdata("serch_triner", parm);
            DAL.cloes();
            return Dt;
        }
        //للتحقق من عدم تكرار id
        public DataTable veri_id_triner(string id)
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            SqlParameter[] parm = new SqlParameter[1];
            parm[0] = new SqlParameter("@id", SqlDbType.Int);
            parm[0].Value = id;
            Dt = DAL.selectdata("veri_idd", parm);
            DAL.cloes();
            return Dt;
        }
        //لجلب اكبر id+1
        public DataTable get_id_max()
        {
            DAL.data_access_layar DAL = new DAL.data_access_layar();
            DataTable Dt = new DataTable();
            Dt = DAL.selectdata("get_max_triner", null);
            DAL.cloes();
            return Dt;
        }
    }
}
