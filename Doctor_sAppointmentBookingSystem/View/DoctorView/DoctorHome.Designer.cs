namespace Doctor_sAppointmentBookingSystem.View.DoctorView
{
    partial class DoctorHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorHome));
            this.panelDisplay = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDoctorHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPatient = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelDisplayDoctor = new System.Windows.Forms.Panel();
            this.panelDisplay.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.SystemColors.Control;
            this.panelDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelDisplay.ColumnCount = 2;
            this.panelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.panelDisplay.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDisplay.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.panelDisplay.Controls.Add(this.panelDisplayDoctor, 1, 0);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplay.Location = new System.Drawing.Point(0, 0);
            this.panelDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.RowCount = 1;
            this.panelDisplay.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelDisplay.Size = new System.Drawing.Size(1178, 744);
            this.panelDisplay.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.32106F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.67894F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(300, 744);
            this.tableLayoutPanel4.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(17, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(265, 195);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(94, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btnDoctorHome, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.btnPatient, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnClose, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.btnLogOut, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 255);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 7;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(300, 426);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // btnDoctorHome
            // 
            this.btnDoctorHome.Activecolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoctorHome.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctorHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDoctorHome.BorderRadius = 0;
            this.btnDoctorHome.ButtonText = "     Home";
            this.btnDoctorHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoctorHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoctorHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorHome.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoctorHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoctorHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoctorHome.Iconimage")));
            this.btnDoctorHome.Iconimage_right = null;
            this.btnDoctorHome.Iconimage_right_Selected = null;
            this.btnDoctorHome.Iconimage_Selected = null;
            this.btnDoctorHome.IconMarginLeft = 20;
            this.btnDoctorHome.IconMarginRight = 0;
            this.btnDoctorHome.IconRightVisible = true;
            this.btnDoctorHome.IconRightZoom = 0D;
            this.btnDoctorHome.IconVisible = true;
            this.btnDoctorHome.IconZoom = 60D;
            this.btnDoctorHome.IsTab = false;
            this.btnDoctorHome.Location = new System.Drawing.Point(6, 46);
            this.btnDoctorHome.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnDoctorHome.Name = "btnDoctorHome";
            this.btnDoctorHome.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDoctorHome.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoctorHome.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDoctorHome.selected = false;
            this.btnDoctorHome.Size = new System.Drawing.Size(288, 54);
            this.btnDoctorHome.TabIndex = 5;
            this.btnDoctorHome.Text = "     Home";
            this.btnDoctorHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDoctorHome.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDoctorHome.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorHome.Click += new System.EventHandler(this.btnDoctorHome_Click);
            // 
            // btnPatient
            // 
            this.btnPatient.Activecolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPatient.BorderRadius = 0;
            this.btnPatient.ButtonText = "     Patient";
            this.btnPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatient.DisabledColor = System.Drawing.Color.Gray;
            this.btnPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPatient.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPatient.Iconimage")));
            this.btnPatient.Iconimage_right = null;
            this.btnPatient.Iconimage_right_Selected = null;
            this.btnPatient.Iconimage_Selected = null;
            this.btnPatient.IconMarginLeft = 20;
            this.btnPatient.IconMarginRight = 0;
            this.btnPatient.IconRightVisible = true;
            this.btnPatient.IconRightZoom = 0D;
            this.btnPatient.IconVisible = true;
            this.btnPatient.IconZoom = 70D;
            this.btnPatient.IsTab = false;
            this.btnPatient.Location = new System.Drawing.Point(6, 116);
            this.btnPatient.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPatient.Name = "btnPatient";
            this.btnPatient.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPatient.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPatient.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPatient.selected = false;
            this.btnPatient.Size = new System.Drawing.Size(288, 54);
            this.btnPatient.TabIndex = 4;
            this.btnPatient.Text = "     Patient";
            this.btnPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatient.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatient.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatient.Click += new System.EventHandler(this.btnPatient_Click);
            // 
            // btnClose
            // 
            this.btnClose.Activecolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.BorderRadius = 0;
            this.btnClose.ButtonText = "     Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledColor = System.Drawing.Color.Gray;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClose.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClose.Iconimage")));
            this.btnClose.Iconimage_right = null;
            this.btnClose.Iconimage_right_Selected = null;
            this.btnClose.Iconimage_Selected = null;
            this.btnClose.IconMarginLeft = 20;
            this.btnClose.IconMarginRight = 0;
            this.btnClose.IconRightVisible = true;
            this.btnClose.IconRightZoom = 0D;
            this.btnClose.IconVisible = true;
            this.btnClose.IconZoom = 60D;
            this.btnClose.IsTab = false;
            this.btnClose.Location = new System.Drawing.Point(6, 256);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClose.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.selected = false;
            this.btnClose.Size = new System.Drawing.Size(288, 54);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "     Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Activecolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "     Logout";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Iconimage")));
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 20;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 60D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(6, 186);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.OnHovercolor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnLogOut.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogOut.selected = false;
            this.btnLogOut.Size = new System.Drawing.Size(288, 54);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "     Logout";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogOut.Textcolor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.TextFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnLogout_Click);
            // 
            // panelDisplayDoctor
            // 
            this.panelDisplayDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplayDoctor.Location = new System.Drawing.Point(300, 0);
            this.panelDisplayDoctor.Margin = new System.Windows.Forms.Padding(0);
            this.panelDisplayDoctor.Name = "panelDisplayDoctor";
            this.panelDisplayDoctor.Size = new System.Drawing.Size(878, 744);
            this.panelDisplayDoctor.TabIndex = 2;
            // 
            // DoctorHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.panelDisplay);
            this.Name = "DoctorHome";
            this.Text = "DoctorHome";
            this.panelDisplay.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Bunifu.Framework.UI.BunifuFlatButton btnClose;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoctorHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnPatient;
        private System.Windows.Forms.Panel panelDisplayDoctor;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
    }
}