// Form1.Designer.cs
namespace lab02_2
{
    partial class frmQLSV
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
        /// Required method for Designer support — do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.colStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAvgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMaleCaption = new System.Windows.Forms.Label();
            this.lblFemaleCaption = new System.Windows.Forms.Label();
            this.lblMaleCount = new System.Windows.Forms.Label();
            this.lblFemaleCount = new System.Windows.Forms.Label();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.groupBoxInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(90, 28);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(200, 20);
            this.txtStudentID.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(90, 62);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(200, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(90, 98);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(47, 17);
            this.optMale.TabIndex = 2;
            this.optMale.TabStop = true;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(154, 98);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(39, 17);
            this.optFemale.TabIndex = 3;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(90, 132);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(200, 20);
            this.txtAverageScore.TabIndex = 4;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(90, 166);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(200, 21);
            this.cmbFaculty.TabIndex = 5;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colStudentID,
            this.colFullName,
            this.colGender,
            this.colAvgScore,
            this.colFaculty});
            this.dgvStudent.Location = new System.Drawing.Point(403, 107);
            this.dgvStudent.MultiSelect = false;
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(536, 289);
            this.dgvStudent.TabIndex = 6;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            this.dgvStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellContentClick);
            // 
            // colStudentID
            // 
            this.colStudentID.HeaderText = "MSSV";
            this.colStudentID.Name = "colStudentID";
            this.colStudentID.ReadOnly = true;
            this.colStudentID.Width = 90;
            // 
            // colFullName
            // 
            this.colFullName.HeaderText = "Họ và tên";
            this.colFullName.Name = "colFullName";
            this.colFullName.ReadOnly = true;
            this.colFullName.Width = 180;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Giới tính";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 70;
            // 
            // colAvgScore
            // 
            this.colAvgScore.HeaderText = "Điểm TB";
            this.colAvgScore.Name = "colAvgScore";
            this.colAvgScore.ReadOnly = true;
            this.colAvgScore.Width = 70;
            // 
            // colFaculty
            // 
            this.colFaculty.HeaderText = "Khoa";
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.ReadOnly = true;
            this.colFaculty.Width = 120;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(90, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 33);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(195, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 33);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMaleCaption
            // 
            this.lblMaleCaption.AutoSize = true;
            this.lblMaleCaption.Location = new System.Drawing.Point(623, 427);
            this.lblMaleCaption.Name = "lblMaleCaption";
            this.lblMaleCaption.Size = new System.Drawing.Size(48, 13);
            this.lblMaleCaption.TabIndex = 9;
            this.lblMaleCaption.Text = "Số Nam:";
            // 
            // lblFemaleCaption
            // 
            this.lblFemaleCaption.AutoSize = true;
            this.lblFemaleCaption.Location = new System.Drawing.Point(779, 427);
            this.lblFemaleCaption.Name = "lblFemaleCaption";
            this.lblFemaleCaption.Size = new System.Drawing.Size(40, 13);
            this.lblFemaleCaption.TabIndex = 10;
            this.lblFemaleCaption.Text = "Số Nữ:";
            // 
            // lblMaleCount
            // 
            this.lblMaleCount.AutoSize = true;
            this.lblMaleCount.Location = new System.Drawing.Point(706, 427);
            this.lblMaleCount.Name = "lblMaleCount";
            this.lblMaleCount.Size = new System.Drawing.Size(13, 13);
            this.lblMaleCount.TabIndex = 11;
            this.lblMaleCount.Text = "0";
            // 
            // lblFemaleCount
            // 
            this.lblFemaleCount.AutoSize = true;
            this.lblFemaleCount.Location = new System.Drawing.Point(862, 427);
            this.lblFemaleCount.Name = "lblFemaleCount";
            this.lblFemaleCount.Size = new System.Drawing.Size(13, 13);
            this.lblFemaleCount.TabIndex = 12;
            this.lblFemaleCount.Text = "0";
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.label6);
            this.groupBoxInput.Controls.Add(this.label4);
            this.groupBoxInput.Controls.Add(this.label3);
            this.groupBoxInput.Controls.Add(this.label2);
            this.groupBoxInput.Controls.Add(this.label1);
            this.groupBoxInput.Controls.Add(this.txtStudentID);
            this.groupBoxInput.Controls.Add(this.txtFullName);
            this.groupBoxInput.Controls.Add(this.optMale);
            this.groupBoxInput.Controls.Add(this.optFemale);
            this.groupBoxInput.Controls.Add(this.txtAverageScore);
            this.groupBoxInput.Controls.Add(this.cmbFaculty);
            this.groupBoxInput.Controls.Add(this.btnUpdate);
            this.groupBoxInput.Controls.Add(this.btnDelete);
            this.groupBoxInput.Location = new System.Drawing.Point(12, 107);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Size = new System.Drawing.Size(357, 289);
            this.groupBoxInput.TabIndex = 13;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Thông tin sinh viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Chuyên ngànhL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Điểm TB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã SV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(187, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(617, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "QUẢN LÝ THÔNG TIN SINH VIÊN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(403, 80);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(55, 13);
            this.lblSearch.TabIndex = 15;
            this.lblSearch.Text = "Tìm kiếm: ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(470, 77);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // frmQLSV
            // 
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFemaleCount);
            this.Controls.Add(this.lblMaleCount);
            this.Controls.Add(this.lblFemaleCaption);
            this.Controls.Add(this.lblMaleCaption);
            this.Controls.Add(this.groupBoxInput);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmQLSV";
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.groupBoxInput.ResumeLayout(false);
            this.groupBoxInput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            // 
            // lblFilterFaculty
            // 
            this.lblFilterFaculty = new System.Windows.Forms.Label();
            this.lblFilterFaculty.AutoSize = true;
            this.lblFilterFaculty.Location = new System.Drawing.Point(750, 80);
            this.lblFilterFaculty.Name = "lblFilterFaculty";
            this.lblFilterFaculty.Size = new System.Drawing.Size(69, 13);
            this.lblFilterFaculty.TabIndex = 17;
            this.lblFilterFaculty.Text = "Lọc khoa: ";

            // 
            // cmbFilterFaculty
            // 
            this.cmbFilterFaculty = new System.Windows.Forms.ComboBox();
            this.cmbFilterFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterFaculty.Items.AddRange(new object[] {
    "Tất cả",
    "QTKD",
    "CNTT",
    "NNA"
});
            this.cmbFilterFaculty.Location = new System.Drawing.Point(820, 77);
            this.cmbFilterFaculty.Name = "cmbFilterFaculty";
            this.cmbFilterFaculty.Size = new System.Drawing.Size(120, 21);
            this.cmbFilterFaculty.TabIndex = 18;
            this.cmbFilterFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFilterFaculty_SelectedIndexChanged);

            // THÊM CONTROL VÀO FORM
            this.Controls.Add(this.lblFilterFaculty);
            this.Controls.Add(this.cmbFilterFaculty);

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMaleCaption;
        private System.Windows.Forms.Label lblFemaleCaption;
        private System.Windows.Forms.Label lblMaleCount;
        private System.Windows.Forms.Label lblFemaleCount;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAvgScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFaculty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterFaculty;
        private System.Windows.Forms.ComboBox cmbFilterFaculty;

    }
}
