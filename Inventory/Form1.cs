using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
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


        private void ExitButton_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDataSet1.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet1.Inventory);

            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

        }

        private void fillByEmpToolStripButton_Click(object sender, EventArgs e)
        {

            try
            {
                this.inventoryTableAdapter.FillByEmp(this.inventoryDataSet.Inventory, employeeToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void fillByDeptToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillByDept(this.inventoryDataSet.Inventory, departmentToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
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
                this.inventoryTableAdapter.UpdateQuery(itemTxtBox.Text, empTxtBox.Text, deptTxtBox.Text, snTxtBox.Text, itemTagTxtBox.Text, installDateTimePicker.Value, replaceDateTimePicker.Value, checkboxValue, id);
                this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
                this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
            }
        }

        private void InventoryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            itemTxtBox.Text = inventoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            bool checkboxValue;
            if (activeCheckBox.Checked)
            {
                checkboxValue = true;
            }
            else
            {
                checkboxValue = false;
            }

            this.inventoryTableAdapter.Insert(itemTxtBox.Text, empTxtBox.Text, deptTxtBox.Text, snTxtBox.Text, itemTagTxtBox.Text, installDateTimePicker.Value, replaceDateTimePicker.Value, checkboxValue);
            this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

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
            // Refresh the data
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);
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

            // ID

            if (inventoryDataGridView.CurrentCell != null)
            {
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
            }

        }
    }

}
