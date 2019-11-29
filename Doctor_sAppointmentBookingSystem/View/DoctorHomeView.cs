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
    public partial class DoctorHomeView : Form
    {
        public DoctorHomeView()
        {
            InitializeComponent();
        }

        public void loadDocView()
        {
            DoctorsView2OnLoad doctorsView2OnLoad = new DoctorsView2OnLoad();
            doctorsView2OnLoad.TopLevel = false;
            doctorsView2OnLoad.AutoScroll = true;
            doctorsView2OnLoad.FormBorderStyle = FormBorderStyle.None;
            doctorsView2OnLoad.Dock = DockStyle.Fill;


            this.pnlRightDisplay.Controls.Clear();
            this.pnlRightDisplay.Controls.Add(doctorsView2OnLoad);
            doctorsView2OnLoad.Show();
        }
        public void loadDocView2()
        {
            DoctorsView2 doctorsView2 = new DoctorsView2();
            doctorsView2.TopLevel = false;
            doctorsView2.AutoScroll = true;
            doctorsView2.FormBorderStyle = FormBorderStyle.None;
            doctorsView2.Dock = DockStyle.Fill;


            this.pnlRightDisplay.Controls.Clear();
            this.pnlRightDisplay.Controls.Add(doctorsView2);
            doctorsView2.Show();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            loadDocView2();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            loadDocView();
        }

        private void DoctorHomeView_Load(object sender, EventArgs e)
        {
            loadDocView();
        }
    }
}
