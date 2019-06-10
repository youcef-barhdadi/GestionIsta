using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionIstaLibrary.Controllers;

namespace GestionIstaLibrary
{
    public enum ConnectionType
    {
        SqlServer =0,
        SqlFile=1,
        TextFiles=2,
        XmlFiles=3,
        AccessDataBase=4,
        ExcelFiles=5
    }
   public static  class GlobalConfig
    {
        public static DataConnection dataconnction { get;private set; }

        public static void SetConnection(ConnectionType con)
        {
            if (con == ConnectionType.SqlServer)
            {
                dataconnction = new SqlDataAccess();
            }
            if (con == ConnectionType.TextFiles)
            {
                dataconnction = new TextAccess();
            }
                     
        }
 
    }
}
