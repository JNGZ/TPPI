using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TPPI
{
    class utils
    {
        const string cstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=journal.accdb;Persist Security Info=True";
        static OleDbConnection dbConn = new OleDbConnection(cstring);
        static OleDbCommand dbCmd = new OleDbCommand();
        static OleDbCommand dbCmd2 = new OleDbCommand();
        static OleDbDataAdapter dbAdapter = new OleDbDataAdapter();

        public static DataSet LoadDSForTblTopics(DataSet ds)
        {
            
            string query = "SELECT * FROM tblTopics";
            OleDbConnection dbConn = new OleDbConnection(cstring);
            dbAdapter = new OleDbDataAdapter(query, dbConn);
            dbConn.Open();
            dbAdapter.Fill(ds);
            return ds;


        }



    }
}
