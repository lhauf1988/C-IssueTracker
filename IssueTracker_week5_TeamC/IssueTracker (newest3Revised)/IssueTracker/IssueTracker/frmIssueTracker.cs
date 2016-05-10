//Pos409
//1/12/2016
//Lucas Hauf, Joey Almeida
//this project was made so that a user could enter an issue into the application for review, and to organize and fix the issues

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 
using System.IO;

namespace IssueTracker
{
    public partial class frmIssueTracker : Form
    {
        ArrayList IssueData = new ArrayList();//this arraylist stores all the vaules from the form
        private const char DElIMITER = '|';//this will be the mark that seperates the data in the file and arraylist
        private int index;//this will keep the postion of the list so that new Ids can be issued at the end of the list and grid
        private string FileLocation = "C:\\Users\\lucas\\Desktop\\IssueTracker (newest3Revised)\\IssueTracker (newest3Revised)\\IssueTracker\\IssueTrackerData.txt";//<--replace this line with the address of the included text file

        public frmIssueTracker()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();//close application
        }
        private void frmIssueTracker_Load(object sender, EventArgs e)
        {
            lblIssueId.Enabled = false;
            cmbError.Enabled = false;
            cmbPriority.Enabled = false;
            rbtnClose.Enabled = false;
            rbtnOpen.Enabled = false;
            txtDescription.Enabled = false;
            lblCreatedDate.Enabled = false;
            lblCreatedBy.Enabled = false;
            lblModifiedDate.Enabled = false;
            lblModifiedBy.Enabled = false;
            cmbError.Items.Add("Software");
            cmbError.Items.Add("Hardware");
            cmbError.Items.Add("Application");
            cmbError.Items.Add("Data Source");
            cmbPriority.Items.Add("Low");
            cmbPriority.Items.Add("Moderate");
            cmbPriority.Items.Add("High");
            index = 0;
            btnAdd.Enabled = false;
            ReadIssueData(FileLocation);
            IssueData.TrimToSize();

            AddToGrid();
            //int row = dgvIssueList.RowCount;


            //index = int.Parse(dgvIssueList.Rows[row].Cells[0].Value.ToString()) + 1;



        }
        private void btnNew_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(index.ToString());
            index = IssueData.Capacity + 1;
            lblIssueId.Enabled = true;
            lblIssueId.Text = index.ToString();
            cmbError.Enabled = true;
            cmbError.Text = "";
            cmbPriority.Enabled = true;
            cmbPriority.Text = "";
            rbtnClose.Enabled = true;
            rbtnClose.Checked = false;
            rbtnOpen.Enabled = true;
            rbtnOpen.Checked = false;
            txtDescription.Enabled = true;
            txtDescription.Text = "";
            lblCreatedDate.Enabled = true;
            lblCreatedBy.Enabled = true;
            lblCreatedBy.Text = lblUser.Text;
            lblModifiedDate.Enabled = true;
            lblModifiedBy.Enabled = true;
            lblModifiedBy.Text = lblUser.Text;
            lblCreatedDate.Text = DateTime.Now.ToShortDateString();
            lblModifiedDate.Text = DateTime.Now.ToShortDateString();
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            AddToGrid();
            btnAdd.Enabled = false;


        }
        private void Add()
        {

            SaveDeleteEdit Issues = new SaveDeleteEdit();

            Issues.setIssueNumber(index);
            Issues.setErrorCatagory(cmbError.Text);
            Issues.setPriority(cmbPriority.Text);
            if (rbtnOpen.Checked == true)
            {
                Issues.setStatus("Open");
            }
            else
            {
                Issues.setStatus("Close");
            }
            Issues.setDescription(txtDescription.Text);
            Issues.setCreatedBy(lblCreatedBy.Text);
            Issues.setDateCreated(DateTime.Parse(lblCreatedDate.Text));
            Issues.setLastModified(DateTime.Parse(lblModifiedDate.Text));
            Issues.setModifiedBy(lblModifiedBy.Text);
            IssueData.Add(Issues);
        }
        DataTable Grid = new DataTable();
        private void AddToGrid()
        {
            DataTable Grid = new DataTable();
            SaveDeleteEdit Issues = new SaveDeleteEdit();
            Grid.Columns.Add("Issue Number", typeof(int));
            Grid.Columns.Add("Error Catagory", typeof(string));
            Grid.Columns.Add("Priority", typeof(string));
            Grid.Columns.Add("Status", typeof(string));
            Grid.Columns.Add("Description", typeof(string));
            Grid.Columns.Add("Date Created", typeof(DateTime));
            Grid.Columns.Add("Created By", typeof(string));
            Grid.Columns.Add("Date Modified", typeof(DateTime));
            Grid.Columns.Add("Modified By", typeof(String));
            
            cmbxSort.Items.Add("Application");
            cmbxSort.Items.Add("Database");
            cmbxSort.Items.Add("Software");
            cmbxSort.Items.Add("Hardware");
            cmbxSort.Items.Add("Low");
            cmbxSort.Items.Add("Medium");
            cmbxSort.Items.Add("High");
            cmbxSort.Items.Add("Critical");
            cmbxSort.Items.Add("Open");
            cmbxSort.Items.Add("Closed");
            cmbxSort.Items.Add("All");
            IssueData.TrimToSize();
            for (int i = 0; i < IssueData.Capacity; i++)
            {
                Issues = (SaveDeleteEdit)IssueData[i];

                Grid.Rows.Add(Issues.returnIssueNumber(), Issues.returnErrorCatagory(), Issues.returnPriority(), Issues.returnStatus(), Issues.returnDescription(), Issues.returnDateCreated(), Issues.returnCreatedBy(), Issues.returnLastModified(), Issues.returnModifiedBy());
            }
            this.dgvIssueList.DataSource = null;
            this.dgvIssueList.DataSource = Grid;
            
        }
        private void LoadForm(int pIndex)
        {
            this.lblIssueId.Text = dgvIssueList.Rows[pIndex].Cells[0].Value.ToString();
            this.cmbError.Text = dgvIssueList.Rows[pIndex].Cells[1].Value.ToString();
            this.cmbPriority.Text = dgvIssueList.Rows[pIndex].Cells[2].Value.ToString();
            if (dgvIssueList.Rows[pIndex].Cells[3].Value.ToString() == "Open")
            {
                rbtnOpen.Checked = true;
            }
            else
            {
                rbtnClose.Checked = true;
            }
            this.txtDescription.Text = dgvIssueList.Rows[pIndex].Cells[4].Value.ToString();

            this.lblCreatedDate.Text = DateTime.Parse(dgvIssueList.Rows[pIndex].Cells[5].Value.ToString()).ToShortDateString().ToString();
            this.lblCreatedBy.Text = dgvIssueList.Rows[pIndex].Cells[6].Value.ToString();

            this.lblModifiedDate.Text = DateTime.Parse(dgvIssueList.Rows[pIndex].Cells[7].Value.ToString()).ToShortDateString().ToString();

            this.lblModifiedBy.Text = dgvIssueList.Rows[pIndex].Cells[8].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lblIssueId.Enabled = true;
            lblIssueId.Text = index.ToString();
            cmbError.Enabled = true;
            cmbError.Text = "";
            cmbPriority.Enabled = true;
            cmbPriority.Text = "";
            rbtnClose.Enabled = true;
            rbtnClose.Checked = false;
            rbtnOpen.Enabled = true;
            rbtnOpen.Checked = false;
            txtDescription.Enabled = true;
            txtDescription.Text = "";
            lblCreatedDate.Enabled = true;
            lblCreatedBy.Enabled = true;
            lblCreatedBy.Text = lblUser.Text;
            lblModifiedDate.Enabled = true;
            lblModifiedBy.Enabled = true;
            lblModifiedBy.Text = lblUser.Text;
            lblCreatedDate.Text = DateTime.Now.ToShortDateString();
            lblModifiedDate.Text = DateTime.Now.ToShortDateString();
            btnAdd.Enabled = true;
            int row = this.dgvIssueList.CurrentRow.Index;
            LoadForm(row);
            btnAdd.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int row = this.dgvIssueList.CurrentRow.Index;
            dgvIssueList.Rows[row].Cells[0].Value = lblIssueId.Text;
            dgvIssueList.Rows[row].Cells[1].Value = cmbError.Text;
            dgvIssueList.Rows[row].Cells[2].Value = cmbPriority.Text;
            if (rbtnOpen.Checked == true)
            {
                dgvIssueList.Rows[row].Cells[3].Value = "Open";
            }
            else
            {
                dgvIssueList.Rows[row].Cells[3].Value = "Close";
            }
            dgvIssueList.Rows[row].Cells[4].Value = txtDescription.Text;
            dgvIssueList.Rows[row].Cells[5].Value = this.lblCreatedDate.Text;
            dgvIssueList.Rows[row].Cells[6].Value = this.lblCreatedBy.Text;
            this.lblModifiedDate.Text = DateTime.Now.ToShortDateString();
            dgvIssueList.Rows[row].Cells[7].Value = this.lblModifiedDate.Text;
            this.lblModifiedBy.Text = lblUser.Text;
            dgvIssueList.Rows[row].Cells[8].Value = this.lblModifiedBy.Text;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int row = this.dgvIssueList.CurrentRow.Index;
            IssueData.RemoveAt(row);
            this.dgvIssueList.Rows.RemoveAt(row);
            IssueData.TrimToSize();
            lblIssueId.Enabled = true;
            lblIssueId.Text = index.ToString();
            cmbError.Enabled = true;
            cmbError.Text = "";
            cmbPriority.Enabled = true;
            cmbPriority.Text = "";
            rbtnClose.Enabled = true;
            rbtnClose.Checked = false;
            rbtnOpen.Enabled = true;
            rbtnOpen.Checked = false;
            txtDescription.Enabled = true;
            txtDescription.Text = "";
            lblCreatedDate.Enabled = true;
            lblCreatedBy.Enabled = true;
            lblCreatedBy.Text = "";
            lblModifiedDate.Enabled = true;
            lblModifiedBy.Enabled = true;
            lblModifiedBy.Text = "";
            lblCreatedDate.Text = DateTime.Now.ToShortDateString();
            lblModifiedDate.Text = DateTime.Now.ToShortDateString();
            btnAdd.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {



            var result = MessageBox.Show("Are you sure you want to overwrite all previous data?", "Save", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            if (result == DialogResult.Cancel)//chance to abort the save 
            {
                return;
            }
            else
            {
                SaveIssueData(FileLocation);
                IssueData.Clear();
                IssueData.TrimToSize();
                MessageBox.Show("Data has been saved", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } //verification of save
        }
        private void SaveIssueData(string pFile)
        {

            try
            {
                StreamWriter objWriter = new StreamWriter(pFile);
                string line;

                for (int cnt = 0; cnt < IssueData.Capacity; cnt++)
                {
                    line = null;
                    SaveDeleteEdit Issues = new SaveDeleteEdit();

                    Issues = (SaveDeleteEdit)IssueData[cnt];

                    line = Issues.returnIssueNumber().ToString() + DElIMITER;
                    line += Issues.returnErrorCatagory() + DElIMITER;
                    line += Issues.returnPriority() + DElIMITER;
                    line += Issues.returnStatus() + DElIMITER;
                    line += Issues.returnDescription() + DElIMITER;
                    line += Issues.returnDateCreated().ToString() + DElIMITER;
                    line += Issues.returnCreatedBy() + DElIMITER;
                    line += Issues.returnLastModified().ToString() + DElIMITER;
                    line += Issues.returnModifiedBy() + DElIMITER;

                    objWriter.WriteLine(line);
                }
                // Close the file
                //
                objWriter.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error in wiritng to file:" + pFile + "-" + e.Message, "Write to file Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private Boolean ReadIssueData(string pFileName)
        {
            if (System.IO.File.Exists(pFileName) == true)
            {
                StreamReader reader = new StreamReader(File.OpenRead(pFileName));
                try
                {
                    while (!reader.EndOfStream)
                    {


                        String line = reader.ReadLine();
                        loadIssueData(line);

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while reading: " + ex.Message, "Read Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("File Does Not Exist", "File Existence Error");
                return false;
            }

            return true;
        }

        private void loadIssueData(String pLine)
        {
            SaveDeleteEdit Issue = new SaveDeleteEdit();

            try
            {
                var row = pLine.Split(DElIMITER);
                Issue.setIssueNumber(int.Parse(row[0]));
                Issue.setErrorCatagory(row[1]);
                Issue.setPriority(row[2]);
                Issue.setStatus(row[3]);
                Issue.setDescription(row[4]);
                Issue.setDateCreated(DateTime.Parse(row[5]));
                Issue.setCreatedBy(row[6]);
                Issue.setLastModified(DateTime.Parse(row[7]));
                Issue.setModifiedBy(row[8]);

                IssueData.Add(Issue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while spliting in columns: " + ex.Message, "PopulateArray Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void cmbxQuery_SelectedIndexChanged(object sender, EventArgs e)
        { //Based on what is selcted in the Query selection, the Sort selections will change
            if (cmbxQuery.SelectedIndex == 0)
            {
                cmbxSort.Items.Clear();
                cmbxSort.Items.Add("Application");
                cmbxSort.Items.Add("Database");
                cmbxSort.Items.Add("Software");
                cmbxSort.Items.Add("Hardware");
            }
            else if (cmbxQuery.SelectedIndex == 1)
            {
                cmbxSort.Items.Clear();
                cmbxSort.Items.Add("Low");
                cmbxSort.Items.Add("Medium");
                cmbxSort.Items.Add("High");
                cmbxSort.Items.Add("Critical");
            }
            else if (cmbxQuery.SelectedIndex == 2)
            {
                cmbxSort.Items.Clear();
                cmbxSort.Items.Add("Open");
                cmbxSort.Items.Add("Closed");
            }
            else
            {
                cmbxSort.Items.Clear();
                cmbxSort.Items.Add("All");
            }

        }

        private void cmbxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grid.DefaultView.Sort = cmbxSort.SelectedItem.ToString(); // pulling data from grid to sort
        }

        
   
    

    
    }
}
