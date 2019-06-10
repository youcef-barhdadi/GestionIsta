using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionIstaLibrary.Model
{
  public  abstract class PersonModel
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImagePath { get; set; }

        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
        /// <summary>
        /// Create Peseon Objet
        /// </summary>
        public PersonModel()
        {

        }
        public PersonModel(int PersonID, string FirstName, string LastName)
        {
            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

 
        

    }
}
