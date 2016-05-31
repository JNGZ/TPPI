using System;
using System.Windows.Forms;

namespace TPPI
{
    public partial class Topics : Form
    {


        public Topics()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            /*Insert query that inserts new topic into topics table*/
            string qryInsert = "INSERT INTO tblTopics (TopicDescription) VALUES  (\"" + txtNewTopic.Text+ "\")";
            try
            {
                Journal.conCmdExcQry(qryInsert); // creates connection, command and executes the query
                MessageBox.Show(txtNewTopic.Text + " has been added.");              
                this.Close();
            }
            catch(Exception ex)
            {
                Journal.DataProblem(ex);
            }
         
        }
    }
}
