using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            // TODO: This line of code loads data into the 'inventoryDataSet.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryDataSet.Inventory);      
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
    }
    
}
