using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionIstaLibrary.Model;
using System.Data.SqlClient;
using GestionIstaLibrary.Opertion;
using System.Configuration;
using System.Data;

namespace GestionIstaLibrary.Controllers
{
   public class SqlDataAccess : DataConnection
    {
  




        SQLOpertion opre;

       public UserModel GetUser(string UserName, string PassWord)
        {
            UserModel  model=null;
            opre = new SQLOpertion(ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString);
            DataTable dt= opre.GetDataTabel("GetUser", new SqlParameter("@userName", UserName), new SqlParameter("@password", PassWord));
            if(dt!=null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                int id = Convert.ToInt16(dr[0]);
                model = new UserModel(id, dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), Convert.ToBoolean(dr[5]));
            }
            return model;
        }

        public List<StagiaireModel> GetAllStagiaire()
        {
            List<StagiaireModel> List = new List<StagiaireModel>();
            DataTable dt = opre.GetDataTabel("GetAllStagiaire");
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt16(dr[0]);
               StagiaireModel model = new StagiaireModel(id, dr[1].ToString(), dr[2].ToString(), dr[3].ToString()=="F"?Sexe.F:Sexe.M, Convert.ToDateTime(dr[4].ToString()));
                List.Add(model);
            }

            return List;
        }

        public StagiaireModel AddStagire(StagiaireModel stg)
        {
            opre.Excute("", new SqlParameter("", stg.FirstName));
            stg.PersonID = 1;
            return stg;

        }

        public List<FormateurModel> GetAllFormateurs()
        {
            List<FormateurModel> List = new List<FormateurModel>();
            DataTable dt = opre.GetDataTabel("GetAllFormateurs");
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt16(dr[0]);
                FormateurModel model = new FormateurModel(id, dr[1].ToString(), dr[2].ToString(), dr[3].ToString() == "F" ? Sexe.F : Sexe.M, Convert.ToDateTime(dr[4].ToString()));
                List.Add(model);
            }

            return List;
        }
    }
}
