using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();            
        }

        // Updates & Fills the datagridview
        public void UpdateData()
        {
            this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the form, triggers Form Closing
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
            // fill Departmentlists drop source, add Departments as needed
            var departmentsList = new List<string> { "All", "GIS", "IT" };
            deptComboBox.ComboBox.DataSource = departmentsList;

        }

        private void fillByEmpToolStripButton_Click(object sender, EventArgs e)
        {

            try {
                this.inventoryTableAdapter.FillByEmp(this.inventoryDataSet.Inventory, empToolStripTextBox.Text);
            }
            catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


       
        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            //Save file below
            this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //Grab ID from Field or showdialog maybe? Then do the dirty work.
            if (inventoryDataGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select a field to update!");
            }
            else
            {
                int id = Convert.ToInt32(inventoryDataGridView.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value);
                bool checkboxValue;
                if (activeCheckBox.Checked)
                {
                    checkboxValue = true;
                }
                else
                {
                    checkboxValue = false;
                }                                           
                // Updates selected fields in DataGridView
                this.inventoryTableAdapter.UpdateQuery(itemTxtBox.Text, empTxtBox.Text, deptTxtBox.Text, snTxtBox.Text, itemTagTxtBox.Text, installDateTimePicker.Value, replaceDateTimePicker.Value, checkboxValue, notesTextbox.Text, id);
                UpdateData();
            }
        }

        private void InventoryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //i forgot
            itemTxtBox.Text = inventoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            // Find value of activeCheckbox, convert to bool
            bool checkboxValue;
            if (activeCheckBox.Checked)
            { checkboxValue = true;}
            else
            {checkboxValue = false;}

            // Inserts new fields into table adapter, updates data
            this.inventoryTableAdapter.Insert(itemTxtBox.Text, empTxtBox.Text, deptTxtBox.Text, snTxtBox.Text, itemTagTxtBox.Text, installDateTimePicker.Value, replaceDateTimePicker.Value, checkboxValue, notesTextbox.Text);
            UpdateData();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Form Closing event to make sure user has saved, prevent accidently closing
            // Murachs C# 2015 Page 316
            string message = "Are you sure you want to close the program? Unsaved data will be lost. \n \n" +
                             "Do you wish to save?";
            DialogResult button = MessageBox.Show(message, "Inventory", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (button == DialogResult.Yes)
            {
                this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
            }
            if (button == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            // Refresh button, update & fill 
            UpdateData();
        }

        private void InventoryDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if click is on new row or header row
            if (e.RowIndex == inventoryDataGridView.NewRowIndex || e.RowIndex < 0)
                return;

            //Check if click is on specific column 
            if (e.ColumnIndex == inventoryDataGridView.Columns["dataGridViewDeleteButton"].Index)
            {
                //Put some logic here, for example to remove row from your binding list.
                inventoryBindingSource.RemoveAt(e.RowIndex);
            }
        }

        private void InventoryDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (inventoryDataGridView.CurrentCell != null)
            {
                // Fills input to current selected row
                int id = Convert.ToInt32(inventoryDataGridView.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value);
                idTextbox.Text = inventoryDataGridView.CurrentRow.Cells["iDDataGridViewTextBoxColumn"].Value.ToString();
                itemTxtBox.Text = inventoryDataGridView.CurrentRow.Cells[1].Value.ToString();
                empTxtBox.Text = inventoryDataGridView.CurrentRow.Cells[2].Value.ToString();
                deptTxtBox.Text = inventoryDataGridView.CurrentRow.Cells[3].Value.ToString();
                snTxtBox.Text = inventoryDataGridView.CurrentRow.Cells[4].Value.ToString();
                itemTagTxtBox.Text = inventoryDataGridView.CurrentRow.Cells[5].Value.ToString();
                var date1 = inventoryDataGridView.CurrentRow.Cells[6].Value;
                if (!(date1 is DBNull))
                {
                    installDateTimePicker.Value = Convert.ToDateTime(inventoryDataGridView.CurrentRow.Cells[6].Value);
                }

                var date2 = inventoryDataGridView.CurrentRow.Cells[7].Value;
                if (!(date2 is DBNull))
                {
                    installDateTimePicker.Value = Convert.ToDateTime(inventoryDataGridView.CurrentRow.Cells[7].Value);
                }


                // Active
                bool checkboxDGV = Convert.ToBoolean(inventoryDataGridView.CurrentRow.Cells[8].Value.ToString());
                if (checkboxDGV == true)
                {
                    activeCheckBox.Checked = true;
                }
                else
                {
                    activeCheckBox.Checked = false;
                }

                // Get Notes field
                notesTextbox.Text = this.inventoryTableAdapter.GetNotesQuery(id) ;
            }

        }
        
        private void DeptComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (deptComboBox.SelectedItem.ToString() == "All")
            {
                UpdateData();
            }
            else
            {
                this.inventoryTableAdapter.FillByDept(this.inventoryDataSet.Inventory, deptComboBox.SelectedItem.ToString());
            }
        }

        // Export the DGV to a .CSV file
        private void ExportButton_Click(object sender, EventArgs e)
        {
            inventoryDataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            inventoryDataGridView.RowHeadersVisible = false;
            inventoryDataGridView.SelectAll();

            DataObject dataObject = inventoryDataGridView.GetClipboardContent();
            File.WriteAllText("Data/export.csv", dataObject.GetData("Csv") as string);

            MessageBox.Show("Export complete");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            // Resets fields
            idTextbox.Text = "";
            itemTxtBox.Text = "";
            empTxtBox.Text = "";
            deptTxtBox.Text = "";
            itemTagTxtBox.Text = "";
            snTxtBox.Text = "";
            notesTextbox.Text = "";
            installDateTimePicker.Value = DateTime.Now;
            replaceDateTimePicker.Value = DateTime.Now;
        }

        private void TagToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillByTag(this.inventoryDataSet.Inventory, tagToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }

}
