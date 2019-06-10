using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GestionIstaLibrary.Model
{
    
  public  class UserModel :PersonModel 
    {

        public string  UserName { get; set; }
        public string  PassWord { get; set; }
        public bool IsAdmin { get; private set; }


        public UserModel()
        {
            
        }

        public UserModel(int PersonID, string FirstName, string LastName, string UserName, string PassWord, bool IsAdmin)
            :base(PersonID, FirstName, LastName)
        {
            this.UserName = UserName;
            this.IsAdmin = IsAdmin;
            this.PassWord = PassWord;
        }


    }
}
