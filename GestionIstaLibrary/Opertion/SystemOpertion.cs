using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using GestionIstaLibrary.Model;

namespace GestionIstaLibrary.Opertion
{
    public static class SystemOpertion
    {

        public static void SaveUser(UserModel user)
        {
            File.WriteAllText(ConfigurationManager.ConnectionStrings["UserFile"].ConnectionString, $"{user.PersonID},{user.FirstName},{user.LastName},{user.UserName},{user.PassWord},{user.IsAdmin}");
        }
        public static UserModel GetUser()
        {
            string line = File.ReadAllLines(ConfigurationManager.ConnectionStrings["UserFile"].ConnectionString).FirstOrDefault();
            string[] words = line.Split(',');
            int id = Convert.ToInt16(words[0]);
            return new UserModel(id, words[1], words[2], words[3], words[4], Convert.ToBoolean(words[5]));
        }
    }
}
