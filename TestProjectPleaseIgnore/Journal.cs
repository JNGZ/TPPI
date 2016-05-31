///<summary>
///======================================================================
///
/// PROJECT NAME: Journal
/// 
/// PURPOSE: A program that logs journal entries
/// 
/// AUTHOR: Johnathan Gonzalez
/// 
/// ======================================================================
/// </summary>

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;


namespace TPPI
{
    public partial class Journal : Form
    {
        #region GLOBAL VARIABLES

        int activeID = 1; // instance of active record id 
        int totalRows = 0; // instance of total rows in journal database
        const string cstring = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=journal.accdb;Persist Security Info=True";//connection string
        static OleDbConnection dbConn = new OleDbConnection(cstring); //instance of data base connection 
        static OleDbCommand dbCmd = new OleDbCommand(); //instance of data base command
        static OleDbDataAdapter dbAdapter = new OleDbDataAdapter(); //instance of data base adapter
        DataSet ds = new DataSet(); // instance of new dataset

        #endregion

        /*CLASS CONSTRUCTOR*/
        public Journal()
        {
            InitializeComponent();
        }

        /*LOAD FUNCTION*/
        public void Journal_Load(object sender, EventArgs e)
        {            
            string qryTblJournals = "SELECT * FROM tblJournals"; //get everthing from journals table

                try
                {
                    loadComboBox(ds); //load combobox with dataset data
                    dbConn.Open(); //open database connection
                    getThenLoadData(qryTblJournals); // load all data into remaining fields
                    getRecordCount();//load record count data
                    dbConn.Close(); //close database connection
                }
                catch (Exception ex)
                {
                    DataProblem(ex);
                }
        }


        #region UTILITY FUNCTIONS

        /*Gets data and loads to screen*/
        public void getThenLoadData(string query)
        {
            /*1st DB Command*/
            dbCmd = new OleDbCommand(query, dbConn);
            var reader = dbCmd.ExecuteReader();
            reader.Read();
            txtDate.Text = reader["EntryDate"].ToString();
            cboTopic.SelectedValue = (int)reader["TopicID"];
            txtTopic.Text = reader["EntryDetails"].ToString();
            activeID = (int)reader["JournalID"];
        }

        /*Gets record count data and sets to screen*/
        public void getRecordCount()
        {
            string qryQRYJournalTotals = "SELECT * FROM qryJournalTotals";
            dbCmd = new OleDbCommand(qryQRYJournalTotals, dbConn);
            var reader = dbCmd.ExecuteReader();
            reader.Read();
            totalRows = (int)reader["TotalJournals"];
            lblRecordCount.Text = "Record " + activeID + " of " + totalRows;
        }

        /*Load combox box data*/
        public void loadComboBox(DataSet ds)
        {
            string qryTblTopics = "SELECT * FROM tblTopics";
            OleDbConnection dbConn = new OleDbConnection(cstring);
            dbAdapter = new OleDbDataAdapter(qryTblTopics, dbConn);
            dbConn.Open();
            dbAdapter.Fill(ds);
            cboTopic.DataSource = ds.Tables[0];
            cboTopic.DisplayMember = "TopicDescription";
            cboTopic.ValueMember = "TopicID";
        }
        
        /*Create dbConnection, dbCommand, open connection, execute query*/
        public static void conCmdExcQry(string query)
        {
            OleDbConnection dbConn = new OleDbConnection(cstring); // Instantiate db Connection
            OleDbCommand dbCmd = new OleDbCommand(query, dbConn);   // Instantiate db Command
            dbConn.Open();  // Open connection
            dbCmd.ExecuteNonQuery(); // Execute SQL query
        }

        #endregion


        #region Navigation buttons

        /*NAVIGATE TO FIRST JOURNAL ENTRY*/
        private void btnFirst_Click(object sender, EventArgs e)
        {
            string qryFirst = "SELECT * FROM tblJournals";    //  Gets everything from Journals table (tblJournals)      

            try
            {
                dbConn.Open();  // Open database connection              
                getThenLoadData(qryFirst); /*METHOD TO PARSE THE QUERIES AND RETURN DATA*/
                getRecordCount(); // gets record count and sets to screen
                dbConn.Close(); // Close database connection
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*NAVIGATE TO LAST JOURNAL ENTRY*/
        private void btnLast_Click(object sender, EventArgs e)
        {
            string qryLast = "SELECT * FROM tblJournals ORDER BY JournalID DESC";    //  Gets everything from Journals table (tblJournals)   
            try
            {
                dbConn.Open();// Open database connection                   
                getThenLoadData(qryLast); /*METHODS TO PARSE THE QUERIES AND RETURN DATA*/
                getRecordCount(); // gets record count and sets to screen
                dbConn.Close();// Close database connection
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*NAVIGATE TO PREVIOUS SEQUENTIAL ENTRY*/
        private void btnPrev_Click(object sender, EventArgs e)
        {
            string qryPrev = "SELECT * FROM tblJournals WHERE JournalID < " + activeID + " ORDER BY JournalID DESC";    //Select everything from journals table where the journal ID is less than the active id. IN DESCENDING ORDER.
            try
            {
                dbConn.Open();  //Open db Connection
                getThenLoadData(qryPrev); //Get data from db and load to all relevant fields
                getRecordCount(); // gets record count and sets to screen
                dbConn.Close(); //Close the db Connection
            }
            catch (Exception ex)
            {
                DataProblem(ex);    
            }
        }

        /*NAVIGATE TO NEXT SEQUENTIAL ENTRY*/
        private void btnNext_Click(object sender, EventArgs e)
        {
            string qryNext = "SELECT * FROM tblJournals WHERE JournalID > " + activeID + " ORDER BY JournalID ASC";// SQL query that gets all data from journals table where journal id is greater than current id ORDER BY ASCENDING.
            try
            {
                dbConn.Open();//Open db Connection
                getThenLoadData(qryNext);//Get data from db and load to all relevant fields 
                getRecordCount(); // gets record count and sets to screen
                dbConn.Close();//Close db connection
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*EXCEPTION METHOD*/
        public static void DataProblem(Exception ex)
        {
            MessageBox.Show("Data problem: " + ex.Message);
            dbConn.Close();
        }

        #endregion


        #region Data buttons

        /*OPEN NEW TOPIC WINDOW*/
        private void btnNewTopic_Click(object sender, EventArgs e)
        {
            Topics frm = new Topics();
            frm.Show();
        }

        /*SET UP DATA INPUT BOXES FOR NEW DATA*/
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            activeID = 0;
            lblRecordCount.Text = "Record " + activeID + " of " + totalRows;
            txtDate.Clear();
            txtTopic.Clear();
        }

        /*SAVE / UPDATE ENTRY DATA*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeID == 0)
                {
                    string qryInsert = "INSERT INTO tblJournals (EntryDate, EntryDetails, TopicID) VALUES (\"" + txtDate.Text + "\", \"" + txtTopic.Text + "\", " + cboTopic.SelectedValue + " )";
                    conCmdExcQry(qryInsert);
                    dbConn.Close();
                    btnLast_Click(null, null);
                }
                else
                {
                    string qryUpdate = "UPDATE tblJournals " +
                        "SET EntryDate=\"" + txtDate.Text + "\", EntryDetails=\"" + txtTopic.Text + "\", TopicID=" + cboTopic.SelectedValue +
                        " WHERE JournalID = " + activeID;
                    conCmdExcQry(qryUpdate);
                    activeID--;
                    btnNext_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*DELETE DATA ENTRY*/
        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            try
            {
                string qryDelete = "DELETE FROM tblJournals WHERE JournalID = " + activeID;
                conCmdExcQry(qryDelete);
                btnLast_Click(null, null);
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*Sets the journal entry date to selected date*/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;
            txtDate.Text = result.ToString();
        }

        #endregion


    }
}
