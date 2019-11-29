using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doctor_sAppointmentBookingSystem.View.AdminView;
using Doctor_sAppointmentBookingSystem.View.PatientView;
using Doctor_sAppointmentBookingSystem.View.DoctorView;

namespace Doctor_sAppointmentBookingSystem.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "Admin")
            {
                new Admin().Show();
                this.Hide();
            }
            else if(txtUsername.Text == "Doctor")
            {
                new DoctorHome().Show();
                this.Hide();
            }
            else if(txtUsername.Text == "Patient")
            {
                new PatientHome().Show();
                this.Hide();
            }
            
        }

        private void lblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new PatientSignup().Show();
           
        }
    }
}
