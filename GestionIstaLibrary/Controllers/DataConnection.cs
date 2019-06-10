using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionIstaLibrary.Model;

namespace GestionIstaLibrary.Controllers
{
    public interface DataConnection
    {
        /// <summary>
        /// return UserModel if UserName and passWord correct 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="PassWord"></param>
        /// <returns></returns>
        UserModel GetUser(string UserName, string PassWord);
        List<StagiaireModel> GetAllStagiaire();
        StagiaireModel AddStagire(StagiaireModel stg);
        List<FormateurModel> GetAllFormateurs();

    }
}
