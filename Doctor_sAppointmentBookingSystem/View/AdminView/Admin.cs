using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_sAppointmentBookingSystem.View.AdminView
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientInfo patientInfo = new PatientInfo();
            patientInfo.TopLevel = false;
            patientInfo.AutoScroll = true;
            patientInfo.FormBorderStyle = FormBorderStyle.None;
            patientInfo.Dock = DockStyle.Fill;

            this.panelDisplayRight.Controls.Clear();
            this.panelDisplayRight.Controls.Add(patientInfo);
            patientInfo.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorInfo doctorInfo = new DoctorInfo();
            doctorInfo.TopLevel = false;
            doctorInfo.AutoScroll = true;
            doctorInfo.FormBorderStyle = FormBorderStyle.None;
            doctorInfo.Dock = DockStyle.Fill;

            this.panelDisplayRight.Controls.Clear();
            this.panelDisplayRight.Controls.Add(doctorInfo);
            doctorInfo.Show();
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
            if (MessageBox.Show("Are you sure to close the Application ?", "Confarmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            DepartmentView departmentView = new DepartmentView();
            departmentView.TopLevel = false;
            departmentView.AutoScroll = true;
            departmentView.FormBorderStyle = FormBorderStyle.None;
            departmentView.Dock = DockStyle.Fill;

            this.panelDisplayRight.Controls.Clear();
            this.panelDisplayRight.Controls.Add(departmentView);
            departmentView.Show();
        }
    }
}
