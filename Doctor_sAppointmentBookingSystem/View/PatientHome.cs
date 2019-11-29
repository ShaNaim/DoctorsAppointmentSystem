using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sAppointmentBookingSystem.View
{
    public partial class PatientHome : Form
    {
        public PatientHome()
        {
            InitializeComponent();
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

        private void btnBook_Click(object sender, EventArgs e)
        {
            DoctorBook doctorBook = new DoctorBook();
            doctorBook.TopLevel = false;
            doctorBook.AutoScroll = true;

            doctorBook.FormBorderStyle = FormBorderStyle.None;
            doctorBook.Dock = DockStyle.Fill;

            this.panelDisplayRight.Controls.Clear();
            this.panelDisplayRight.Controls.Add(doctorBook);
            doctorBook.Show();

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            PatientHomeView patientHomeView = new PatientHomeView();
            patientHomeView.TopLevel = false;
            patientHomeView.AutoScroll = true;
            patientHomeView.FormBorderStyle = FormBorderStyle.None;
            patientHomeView.Dock = DockStyle.Fill;

            this.panelDisplayRight.Controls.Clear();
            this.panelDisplayRight.Controls.Add(patientHomeView);
            patientHomeView.Show();
        }
    }
}
