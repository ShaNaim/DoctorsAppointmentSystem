using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sAppointmentBookingSystem.View.DoctorView
{
    public partial class DoctorHome : Form
    {

        
        public DoctorHome()
        {
            InitializeComponent();
        }

      

        private void btnDoctorHome_Click(object sender, EventArgs e)
        {
            DoctorHomeView doctorHomeView = new DoctorHomeView();
            doctorHomeView.TopLevel = false;
            doctorHomeView.AutoScroll = true;
            doctorHomeView.FormBorderStyle = FormBorderStyle.None;
            doctorHomeView.Dock = DockStyle.Fill;


            this.panelDisplayDoctor.Controls.Clear();
            this.panelDisplayDoctor.Controls.Add(doctorHomeView);
            doctorHomeView.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Logout ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            DoctorHomePatientView doctorHomePatientView = new DoctorHomePatientView();
            doctorHomePatientView.TopLevel = false;
            doctorHomePatientView.AutoScroll = true;
            doctorHomePatientView.FormBorderStyle = FormBorderStyle.None;
            doctorHomePatientView.Dock = DockStyle.Fill;


            this.panelDisplayDoctor.Controls.Clear();
            this.panelDisplayDoctor.Controls.Add(doctorHomePatientView);
            doctorHomePatientView.Show();

        }
    }
}
