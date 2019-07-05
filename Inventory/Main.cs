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
    public partial class Main : Form
    {
        public Main()
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
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);


            /*
            string query = "Select * FROM Inventory";
            OleDbConnection inventory = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=data\\Inventory.accdb");
            OleDbCommand selectCMD = new OleDbCommand("Select * FROM Inventory", inventory);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(query, inventory);
            DataSet ds = new DataSet();
            inventory.Open();
            dataadapter.Fill(ds, "Inventory");
            inventory.Close();
            inventoryDataGridView.DataSource = ds;
            inventoryDataGridView.DataMember = "Inventory";
            */


            
        }

        private void FillByDeptToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillByDept(this.inventoryDataSet.Inventory, departmentToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventoryTableAdapter.FillByEmp(this.inventoryDataSet.Inventory, toolStripTextBox1.Text);
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


            this.inventoryTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, dateTimePicker1.Value, dateTimePicker2.Value, checkBox1.Checked);
            
            this.inventoryTableAdapter.Update(this.inventoryDataSet.Inventory);
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);

        }

        private void InventoryDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = inventoryDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
    
}
