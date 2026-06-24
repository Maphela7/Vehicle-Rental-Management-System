using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Information_Management_System
{
    public partial class AddVehicle : Form
    {
         

        public AddVehicle(String type)
        {
            InitializeComponent();
            prepareForm(type);
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void prepareForm(String type)
        {
            if(type == "Add")
            {
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
            }else if(type == "Update")
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
            }

        }

        private void AddVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
