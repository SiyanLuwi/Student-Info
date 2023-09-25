namespace Student_Info
{
    partial class frmStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            lblID = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblMiddleName = new Label();
            lblAddress = new Label();
            lblCourse = new Label();
            lblYear = new Label();
            txtID = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            txtMname = new TextBox();
            txtAddress = new TextBox();
            cbCourse = new ComboBox();
            cbYear = new ComboBox();
            btnNew = new Button();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnCancel = new Button();
            listView1 = new ListView();
            chID = new ColumnHeader();
            chLast = new ColumnHeader();
            chFirst = new ColumnHeader();
            chMiddle = new ColumnHeader();
            chAddress = new ColumnHeader();
            chCourse = new ColumnHeader();
            chYear = new ColumnHeader();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblID.Location = new Point(26, 28);
            lblID.Name = "lblID";
            lblID.Size = new Size(92, 21);
            lblID.TabIndex = 0;
            lblID.Text = "Student ID;";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLastName.Location = new Point(26, 92);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(101, 21);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "LAST NAME:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFirstName.Location = new Point(26, 155);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(105, 21);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "FIRST NAME:";
            // 
            // lblMiddleName
            // 
            lblMiddleName.AutoSize = true;
            lblMiddleName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMiddleName.Location = new Point(26, 220);
            lblMiddleName.Name = "lblMiddleName";
            lblMiddleName.Size = new Size(122, 21);
            lblMiddleName.TabIndex = 0;
            lblMiddleName.Text = "MIDDLE NAME:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblAddress.Location = new Point(26, 279);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(83, 21);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "ADDRESS:";
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblCourse.Location = new Point(26, 338);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(74, 21);
            lblCourse.TabIndex = 0;
            lblCourse.Text = "COURSE:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblYear.Location = new Point(26, 393);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(52, 21);
            lblYear.TabIndex = 0;
            lblYear.Text = "YEAR:";
            // 
            // txtID
            // 
            txtID.Location = new Point(135, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(209, 23);
            txtID.TabIndex = 1;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(133, 90);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(211, 23);
            txtLname.TabIndex = 1;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(135, 153);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(209, 23);
            txtFname.TabIndex = 1;
            // 
            // txtMname
            // 
            txtMname.Location = new Point(154, 218);
            txtMname.Name = "txtMname";
            txtMname.Size = new Size(190, 23);
            txtMname.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(133, 281);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(211, 23);
            txtAddress.TabIndex = 1;
            // 
            // cbCourse
            // 
            cbCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(133, 336);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(211, 23);
            cbCourse.TabIndex = 2;
            // 
            // cbYear
            // 
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(133, 391);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(211, 23);
            cbYear.TabIndex = 2;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.DarkSalmon;
            btnNew.Location = new Point(26, 448);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(119, 48);
            btnNew.TabIndex = 3;
            btnNew.Text = "NEW";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSalmon;
            btnSave.Location = new Point(165, 448);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 48);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkSalmon;
            btnUpdate.Location = new Point(26, 527);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(119, 48);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSalmon;
            btnDelete.Location = new Point(165, 527);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(119, 48);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSalmon;
            btnEdit.Location = new Point(308, 448);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 48);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkSalmon;
            btnCancel.Location = new Point(308, 527);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chID, chLast, chFirst, chMiddle, chAddress, chCourse, chYear });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HideSelection = true;
            listView1.HoverSelection = true;
            listView1.Location = new Point(445, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(719, 597);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // chID
            // 
            chID.Text = "ID";
            chID.Width = 30;
            // 
            // chLast
            // 
            chLast.Text = "LAST NAME";
            chLast.Width = 100;
            // 
            // chFirst
            // 
            chFirst.Text = "First Name";
            chFirst.Width = 120;
            // 
            // chMiddle
            // 
            chMiddle.Text = "Middle Name";
            chMiddle.Width = 100;
            // 
            // chAddress
            // 
            chAddress.Text = "Address";
            chAddress.Width = 150;
            // 
            // chCourse
            // 
            chCourse.Text = "Course";
            chCourse.Width = 150;
            // 
            // chYear
            // 
            chYear.Text = "Year";
            // 
            // frmStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1187, 626);
            Controls.Add(listView1);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(cbYear);
            Controls.Add(cbCourse);
            Controls.Add(txtAddress);
            Controls.Add(txtMname);
            Controls.Add(txtFname);
            Controls.Add(txtLname);
            Controls.Add(txtID);
            Controls.Add(lblYear);
            Controls.Add(lblCourse);
            Controls.Add(lblAddress);
            Controls.Add(lblMiddleName);
            Controls.Add(lblFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblID);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmStudent";
            Text = "Student Information";
            Load += frmStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblLastName;
        private Label lblFirstName;
        private Label lblMiddleName;
        private Label lblAddress;
        private Label lblCourse;
        private Label lblYear;
        private TextBox txtID;
        private TextBox txtLname;
        private TextBox txtFname;
        private TextBox txtMname;
        private TextBox txtAddress;
        private ComboBox cbCourse;
        private ComboBox cbYear;
        private Button btnNew;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnCancel;
        private ListView listView1;
        private ColumnHeader chID;
        private ColumnHeader chLast;
        private ColumnHeader chFirst;
        private ColumnHeader chMiddle;
        private ColumnHeader chAddress;
        private ColumnHeader chCourse;
        private ColumnHeader chYear;
    }
}