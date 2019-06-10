using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionIstaLibrary.Model;
using GestionIstaLibrary.Opertion;

namespace GestionIstaLibrary.Controllers
{
    class TextAccess : DataConnection
    {
        public StagiaireModel AddStagire(StagiaireModel stg)
        {
            throw new NotImplementedException();
        }

        public List<FormateurModel> GetAllFormateurs()
        {
            throw new NotImplementedException();
        }

        public List<StagiaireModel> GetAllStagiaire()
        {
            TextOpertion text = new TextOpertion();
            return text.GetAllStagitre();
        }

        public UserModel GetUser(string UserName, string PassWord)
        {
            TextOpertion text = new TextOpertion();
            List<UserModel> list = text.GetUsers();
            if (list.Count == 0)
                return null;
            UserModel user = list.Where(a => a.UserName == UserName && PassWord == a.PassWord).FirstOrDefault();
            return user;
        }
    }
}
