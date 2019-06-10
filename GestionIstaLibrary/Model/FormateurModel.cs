using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionIstaLibrary.Model
{
  public  class FormateurModel : PersonModel
    {
        public static string ImageFolder;
        public Sexe FormateurSexe { get; private set; }
        public DateTime DateOfBithDay { get; set; }
        public FormateurModel()
        {

        }


        public FormateurModel(int PersonID, string FirstName, string LastName ,Sexe FormateurSexe,DateTime DateOfBithDay)
              : base(PersonID, FirstName, LastName)
        {
            this.FormateurSexe = FormateurSexe;
            this.DateOfBithDay = DateOfBithDay;
        }
    }
}
