using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionIstaLibrary.Model
{
  public  class StagiaireModel :PersonModel
    {
        public Sexe StagiaireSexe { get; private set; }
        public DateTime DateOfBithDay { get; set; }
        public StagiaireModel()
        {

        }


        public StagiaireModel(int PersonID, string FirstName, string LastName, Sexe StagiaireSexe, DateTime DateOfBithDay)
               : base(PersonID, FirstName, LastName)
        {
            this.StagiaireSexe = StagiaireSexe;
            this.DateOfBithDay = DateOfBithDay;
        }
    }
}
