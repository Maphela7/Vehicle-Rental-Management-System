using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle_Rental_Information_Management_System
{
    public partial class Registercs : Form
    {
        public Registercs()
        {
            InitializeComponent();
            this.ControlBox = false;
            txtFirstname.Focus();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }



        private Dictionary<string, List<String>> provinceCities = new Dictionary<string, List<String>>()
        {
            {
                "KwaZulu-Natal",
                new List<string>
                {
                    "Durban",
                    "Pitermaritzburg",
                    "Richerds Bay",
                    "Newcastle",
                    "Empangeni"
                }
            },
            {
                "Gauteng",
                new List<string> {
                    "Johannesburg",
                    "Pretoria",
                    "Soweto",
                    "Midrand",
                    "Centirion"
                }

            },
            {
                "Western Cape",
                new List<string>
                {
                    "Cape Town",
                    "Stellenbosch",
                    "Paarl",
                    "George",
                    "Worcester"
                }
            },
            {
                "Free State",
                new List<string>
                {
                    "Polokwane",
                    "Tzaneen",
                    "Mokopane",
                    "Thohoyandou"
                }
            },
            {
                "Mpumalang",
                new List<string>
                {
                    "Nelspruit",
                    "Witbank",
                    "Secunda",
                    "Middelburg"
                }
            },
            {
                "Nort West",
                new List<string>
                {
                    "Mahikeng",
                    "Rustenburg",
                    "Klerksdorp",
                    "Potchefstroom"
                }
            },
            {
                "Northern Cape",
                new List<string>
                {
                    "Kimbarly",
                    "Upington",
                    "Kurumane",
                    "Springbok"
                }
            }
        };



        private void Registercs_Load(object sender, EventArgs e)
        {
            cmbProvince.Items.AddRange(provinceCities.Keys.ToArray());

            cmbProvince.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
         
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCity.Items.Clear();
            string selectedProvince = cmbProvince.SelectedItem.ToString();

            if (provinceCities.ContainsKey(selectedProvince))
            {
                cmbCity.Items.AddRange(
                    provinceCities[selectedProvince].ToArray()
                    );
            }

            cmbCity.SelectedIndex = -1;
        }
    }
}
