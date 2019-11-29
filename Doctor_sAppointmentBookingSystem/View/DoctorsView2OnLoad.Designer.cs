namespace Doctor_sAppointmentBookingSystem.View
{
    partial class DoctorsView2OnLoad
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPatientSearch = new System.Windows.Forms.Button();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgvPatientList = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpPatientSort = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnPatientGet = new System.Windows.Forms.Button();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dgvPatientList, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(292, 484);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel4.Controls.Add(this.btnPatientSearch, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(30, 414);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 50);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnPatientSearch
            // 
            this.btnPatientSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatientSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPatientSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientSearch.Location = new System.Drawing.Point(139, 10);
            this.btnPatientSearch.Name = "btnPatientSearch";
            this.btnPatientSearch.Size = new System.Drawing.Size(85, 30);
            this.btnPatientSearch.TabIndex = 1;
            this.btnPatientSearch.Text = "Search";
            this.btnPatientSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.txtSearch.HintForeColor = System.Drawing.Color.Empty;
            this.txtSearch.HintText = "";
            this.txtSearch.isPassword = false;
            this.txtSearch.LineFocusedColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtSearch.LineIdleColor = System.Drawing.Color.CadetBlue;
            this.txtSearch.LineMouseHoverColor = System.Drawing.Color.LightSeaGreen;
            this.txtSearch.LineThickness = 3;
            this.txtSearch.Location = new System.Drawing.Point(6, 5);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(119, 40);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvPatientList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPatientList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatientList.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvPatientList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatientList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatientList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatientList.DoubleBuffered = true;
            this.dgvPatientList.EnableHeadersVisualStyles = false;
            this.dgvPatientList.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvPatientList.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvPatientList.Location = new System.Drawing.Point(33, 53);
            this.dgvPatientList.Name = "dgvPatientList";
            this.dgvPatientList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPatientList.RowHeadersWidth = 62;
            this.dgvPatientList.Size = new System.Drawing.Size(226, 358);
            this.dgvPatientList.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel5.Controls.Add(this.dtpPatientSort, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnPatientGet, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(30, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(232, 50);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // dtpPatientSort
            // 
            this.dtpPatientSort.BackColor = System.Drawing.Color.PowderBlue;
            this.dtpPatientSort.BorderRadius = 0;
            this.dtpPatientSort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPatientSort.ForeColor = System.Drawing.Color.White;
            this.dtpPatientSort.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpPatientSort.FormatCustom = null;
            this.dtpPatientSort.Location = new System.Drawing.Point(4, 5);
            this.dtpPatientSort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpPatientSort.Name = "dtpPatientSort";
            this.dtpPatientSort.Size = new System.Drawing.Size(141, 40);
            this.dtpPatientSort.TabIndex = 0;
            this.dtpPatientSort.Value = new System.DateTime(2019, 11, 27, 0, 16, 28, 951);
            // 
            // btnPatientGet
            // 
            this.btnPatientGet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPatientGet.BackColor = System.Drawing.Color.CadetBlue;
            this.btnPatientGet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientGet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPatientGet.Location = new System.Drawing.Point(153, 10);
            this.btnPatientGet.Name = "btnPatientGet";
            this.btnPatientGet.Size = new System.Drawing.Size(75, 30);
            this.btnPatientGet.TabIndex = 1;
            this.btnPatientGet.Text = "GET";
            this.btnPatientGet.UseVisualStyleBackColor = false;
            // 
            // DoctorsView2OnLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 484);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorsView2OnLoad";
            this.Text = "DoctorsView2OnLoad";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientList)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnPatientSearch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvPatientList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Bunifu.Framework.UI.BunifuDatepicker dtpPatientSort;
        private System.Windows.Forms.Button btnPatientGet;
    }
}