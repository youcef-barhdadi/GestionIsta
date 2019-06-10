using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using GestionIstaLibrary.Model;

namespace GestionIstaLibrary.Opertion
{
    class TextOpertion
    {
        string DirectoryPath = "../../TextFiles/";
        private void CraetFiles()
        {
            Directory.CreateDirectory(DirectoryPath+@"\TextFiles");
            File.Create(DirectoryPath + @"TextFiles\UserFile.txt");

        }

        private string[] GetText(string FileName)
        {
            string[] lines  = File.ReadAllLines(DirectoryPath + FileName);
            return lines;
        }
        public List<UserModel> GetUsers()
        {
            string[] lines = GetText("UserFile.txt");
            List < UserModel> usersModel = new List<UserModel>();
            if (lines.Count()==0 && lines == null)
                return null;
            foreach (string line in lines)
            {
                string[] user = line.Split(',');
                int id = Convert.ToInt16(user[0]);
                usersModel.Add(new UserModel(id, user[1], user[2], user[3], user[4], Convert.ToBoolean(user[5])));
            }
            return usersModel;
        }
        public List<StagiaireModel> GetAllStagitre()
        {

             string[] lines = GetText("StagireFile.txt");
            List<StagiaireModel> List = new List<StagiaireModel>();
            foreach (string line in lines)
            {
                string[] stg = line.Split(',');
                int id = Convert.ToInt16(stg[0]);
                StagiaireModel model = new StagiaireModel(id, stg[1].ToString(), stg[2].ToString(), stg[3].ToString() == "F" ? Sexe.F : Sexe.M, Convert.ToDateTime(stg[4].ToString()));
                List.Add(model);
            }
            return List;
        }
        public List<FormateurModel> GetAllFormateurs()
        {

            string[] lines = GetText("FormateurFile.txt");
            List<FormateurModel> List = new List<FormateurModel>();
            foreach (string line in lines)
            {
                string[] stg = line.Split(',');
                int id = Convert.ToInt16(stg[0]);
                FormateurModel model = new FormateurModel(id, stg[1].ToString(), stg[2].ToString(), stg[3].ToString() == "F" ? Sexe.F : Sexe.M, Convert.ToDateTime(stg[4].ToString()));
                List.Add(model);
            }
            return List;
        }



    }
}
