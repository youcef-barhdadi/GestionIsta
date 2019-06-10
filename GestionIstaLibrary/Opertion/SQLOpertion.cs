using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace GestionIstaLibrary.Opertion
{
    public class SQLOpertion
    {

        private SqlConnection conx;
        private string ConxString;
        private SqlCommand cmd;
        public SQLOpertion(string ConxString)
        {
            this.ConxString = ConxString;
            conx = new SqlConnection(ConxString);
        }

        private void OpenConx()
        {
            if (conx.State != System.Data.ConnectionState.Open)
                conx.Open();
        }

        private void CloseConx()
        {
            if (conx.State != System.Data.ConnectionState.Closed)
                conx.Close();
        }

        public DataTable GetDataTabel(string ProcName, params SqlParameter[] param)
        {
            if (ProcName == "")
            {
                throw new ArgumentException("ProcName IS empty");
            }
            OpenConx();
            cmd = conx.CreateCommand();
            cmd.CommandText = ProcName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null && param.Count() > 0)
            {
                foreach (SqlParameter item in param)
                {
                    cmd.Parameters.Add(item);
                }
            }
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            CloseConx();
            return dt;





        }

        public int Excute(string ProcName, params SqlParameter[] param)
        {
            OpenConx();
            cmd = conx.CreateCommand();
            cmd.CommandText = ProcName;
            cmd.CommandType = CommandType.StoredProcedure;
            if (param != null && param.Count() > 0)
            {
                foreach (SqlParameter item in param)
                {
                    cmd.Parameters.Add(item);
                }
            }
            int i= cmd.ExecuteNonQuery();
            CloseConx();
            return i;
        }

    }
}
