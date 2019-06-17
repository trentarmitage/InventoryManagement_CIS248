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
            // TODO: This line of code loads data into the 'inventoryData.Inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.inventoryData.Inventory);


        }

        private void ActiveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //this.inventoryTableAdapter.FillByActive(this.inventoryData.Inventory);
        }

        private void ActiveCheckBox_Click(object sender, EventArgs e)
        {
            if (activeCheckBox.Checked)
            {
                this.inventoryTableAdapter.FillByActive(this.inventoryData.Inventory);
            }
            else
                this.inventoryTableAdapter.Fill(this.inventoryData.Inventory);
        }
    }
}
