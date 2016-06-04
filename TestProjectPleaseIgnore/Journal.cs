///<summary>
///
/// PROJECT NAME: Journal
/// 
/// PURPOSE: A program that logs journal entries
/// 
/// AUTHOR: Johnathan Gonzalez
/// 
/// </summary>

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;


namespace TPPI
{
    public partial class Journal : Form
    {
        #region GLOBAL VARIABLES

        int activeID = 9; // instance of active record id 
        int totalRows = 0; // instance of total rows in journal database
        const string cString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=journal.accdb;Persist Security Info=True";//connection string
        static OleDbConnection dbConn = new OleDbConnection(cString); //instance of data base connection 
        static OleDbCommand dbCmd = new OleDbCommand(); //instance of data base command
        static OleDbDataAdapter dbAdapter = new OleDbDataAdapter(); //instance of data base adapter
        DataSet ds = new DataSet(); // instance of new dataset
        static DataTable dtJournals = new DataTable();


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
                dbConn.Open(); //open database connection
                loadComboBox(ds); //load combobox with dataset data
                getThenLoadData(qryTblJournals); // load all data into remaining fields              
                getIndex(); // creates list from dataset                
                dbConn.Close(); //close database connection

            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }


        #region UTILITY FUNCTIONS

        /*Gets data and loads to screen*/
        public int getThenLoadData(string query)
        {
            /*1st DB Command*/

            dbCmd = new OleDbCommand(query, dbConn);// instance of db command
            var reader = dbCmd.ExecuteReader(); // variable reader set to command reader
            reader.Read();// reader reads
            txtDate.Text = reader["EntryDate"].ToString();// set date to record data
            cboTopic.SelectedValue = (int)reader["TopicID"];// set combo box to record data
            txtTopic.Text = reader["EntryDetails"].ToString();// set entry description to record data
            activeID = (int)reader["JournalID"];// set active id to record data
            return activeID;


        }


        /*Load combox box data*/
        public void loadComboBox(DataSet ds)// Method takes one agrument ( dataset )
        {
            string qryTblTopics = "SELECT * FROM tblTopics";// SQL query - SELECT everything from topics table
            dbConn = new OleDbConnection(cString);// instance of db connection
            dbAdapter = new OleDbDataAdapter(qryTblTopics, dbConn);// instance of data adapter
            dbConn.Open();// open db connection
            dbAdapter.Fill(ds);// fill data adapter with data set 
            cboTopic.DataSource = ds.Tables[0];// combo box data source set to dataset table index 0 
            cboTopic.DisplayMember = "TopicDescription";// combo box display topic description
            cboTopic.ValueMember = "TopicID";// combo box reference to topic id
            //dbConn.Close();// close db connection
        }

        /*Create dbConnection, dbCommand, open connection, execute query*/
        public static void conCmdExcQry(string query)
        {
            dbConn = new OleDbConnection(cString); // Instantiate db Connection
            dbCmd = new OleDbCommand(query, dbConn);   // Instantiate db Command
            dbConn.Open();  // Open connection
            dbCmd.ExecuteNonQuery(); // Execute SQL query
        }

        /*EXCEPTION METHOD*/
        public static void DataProblem(Exception ex)
        {
            MessageBox.Show("Data problem: " + ex.Message);
            dbConn.Close();
        }

        /*Sets the journal entry date to selected date*/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime result = dateTimePicker1.Value;//create instance of datetime object to date time picker selected value
            txtDate.Text = result.ToString();// set date time text value to result object
        }

        /*GET THE INDEX OF THE JOURNAL ENTRY*/
        public void getIndex()
        {
            string qryTblTopics = "SELECT * FROM tblJournals";// SQL query - SELECT everything from topics table
            dbConn = new OleDbConnection(cString);// instance of db connection
            dbAdapter = new OleDbDataAdapter(qryTblTopics, dbConn);// instance of data adapter
            DataSet dsIndexer = new DataSet();// new instance of data set
            dbAdapter.Fill(dsIndexer);// fill data adapter with data set 
            DataTable dtJournals = dsIndexer.Tables[0];//fill data table with data set table at index 0

            /*CREATES A NEW ENUMERABLE ROW COLLECTION OF TYPE ANNONYMOUS*/
            var myData = dsIndexer.Tables[0].AsEnumerable().Select(r => new
            {
                id = r.Field<int>("JournalID") // creates a coloumn and fills it with data from data set
            });

            var list = myData.ToList(); // turn the enumerable collection into a list
            var id = activeID;   // set variable id to the active id 
            var index = list.FindIndex(a => a.id == id) + 1; // find the index that correlates to the active id
            int totalRows = list.Count(); // get the length of list 

            lblRecordCount.Text = "Record " + index + " of " + totalRows;// record count set to total rows in data source
            list.Clear(); // clear the list
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
                getIndex();
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
                getIndex();
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
                getIndex();
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
                getIndex();
                dbConn.Close();//Close db connection
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        #endregion


        #region Data buttons

        /*OPEN NEW TOPIC WINDOW*/
        private void btnNewTopic_Click(object sender, EventArgs e)
        {
            Topics frm = new Topics();//instantiate topics form
            frm.Show();//show the form
        }

        /*PREPARE INPUT BOXES FOR NEW DATA*/
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            activeID = 0; // Set active id to 0
            lblRecordCount.Text = "Record " + activeID + " of " + totalRows; // Reset record count output
            txtDate.Clear(); // clear date field
            txtTopic.Clear(); // clear topic field
        }

        /*SAVE / UPDATE ENTRY DATA*/
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (activeID == 0)
                {
                    string qryInsert = "INSERT INTO tblJournals (EntryDate, EntryDetails, TopicID) VALUES (\"" + txtDate.Text + "\", \"" + txtTopic.Text + "\", " + cboTopic.SelectedValue + " )";// SQL query inserts into journals table entry date, entry details, and topic
                    conCmdExcQry(qryInsert);//creates db connection, db command, and executes query
                    dbConn.Close();//closes db connection
                    btnLast_Click(null, null);
                }
                else
                {
                    string qryUpdate = "UPDATE tblJournals " +
                        "SET EntryDate=\"" + txtDate.Text + "\", EntryDetails=\"" + txtTopic.Text + "\", TopicID=" + cboTopic.SelectedValue +
                        " WHERE JournalID = " + activeID;//SQL query - updates journals table with date, details, and topic
                    conCmdExcQry(qryUpdate);//creates db connection, db command, and executes query
                    activeID--;//decrease active id by 1
                    btnNext_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        /*DELETE DATA ENTRY*/
        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            try
            {
                string qryDelete = "DELETE FROM tblJournals WHERE JournalID = " + activeID;// SQL query - DELETE from journals table where journal id equals active id
                conCmdExcQry(qryDelete);// create db connection, db command then execute query
                dbConn.Close();
                btnLast_Click(null, null);
            }
            catch (Exception ex)
            {
                DataProblem(ex);
            }
        }

        #endregion
    }


}
