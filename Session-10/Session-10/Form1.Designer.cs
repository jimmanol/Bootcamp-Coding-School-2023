namespace Session_10 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grvStudents = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUndergraduate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUniversity = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colShowID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bsStudents = new System.Windows.Forms.BindingSource(this.components);
            this.btnOK = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grvCourses = new System.Windows.Forms.DataGridView();
            this.grvSchedule = new System.Windows.Forms.DataGridView();
            this.grvGrades = new System.Windows.Forms.DataGridView();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).BeginInit();
            this.SuspendLayout();
            // 
            // grvStudents
            // 
            this.grvStudents.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colSurname,
            this.colAge,
            this.colUndergraduate,
            this.colGender,
            this.colUniversity,
            this.colShowID});
            this.grvStudents.Location = new System.Drawing.Point(12, 60);
            this.grvStudents.Name = "grvStudents";
            this.grvStudents.RowTemplate.Height = 25;
            this.grvStudents.Size = new System.Drawing.Size(810, 209);
            this.grvStudents.TabIndex = 0;
            this.grvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvStudents_CellContentClick_1);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 120;
            // 
            // colSurname
            // 
            this.colSurname.DataPropertyName = "Surname";
            this.colSurname.HeaderText = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Width = 200;
            // 
            // colAge
            // 
            this.colAge.DataPropertyName = "Age";
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Width = 60;
            // 
            // colUndergraduate
            // 
            this.colUndergraduate.DataPropertyName = "Undergraduate";
            this.colUndergraduate.HeaderText = "Undergraduate";
            this.colUndergraduate.Name = "colUndergraduate";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colGender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colUniversity
            // 
            this.colUniversity.DataPropertyName = "UniversityID";
            this.colUniversity.HeaderText = "University";
            this.colUniversity.Name = "colUniversity";
            // 
            // colShowID
            // 
            this.colShowID.HeaderText = "";
            this.colShowID.Name = "colShowID";
            this.colShowID.Text = "Show ID";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(703, 31);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grvCourses
            // 
            this.grvCourses.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCourses.Location = new System.Drawing.Point(858, 60);
            this.grvCourses.Name = "grvCourses";
            this.grvCourses.RowTemplate.Height = 25;
            this.grvCourses.Size = new System.Drawing.Size(496, 209);
            this.grvCourses.TabIndex = 3;
            this.grvCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvCourses_CellContentClick);
            // 
            // grvSchedule
            // 
            this.grvSchedule.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSchedule.Location = new System.Drawing.Point(12, 310);
            this.grvSchedule.Name = "grvSchedule";
            this.grvSchedule.RowTemplate.Height = 25;
            this.grvSchedule.Size = new System.Drawing.Size(446, 226);
            this.grvSchedule.TabIndex = 4;
            this.grvSchedule.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvSchedule_CellContentClick);
            // 
            // grvGrades
            // 
            this.grvGrades.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvGrades.Location = new System.Drawing.Point(858, 310);
            this.grvGrades.Name = "grvGrades";
            this.grvGrades.RowTemplate.Height = 25;
            this.grvGrades.Size = new System.Drawing.Size(496, 226);
            this.grvGrades.TabIndex = 5;
            this.grvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvGrades_CellContentClick);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(478, 394);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(155, 48);
            this.btnLoad.TabIndex = 6;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(667, 394);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 48);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1392, 610);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grvGrades);
            this.Controls.Add(this.grvSchedule);
            this.Controls.Add(this.grvCourses);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.grvStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvSchedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvGrades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grvStudents;
        private Button btnOK;
        private Button btnRefresh;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewTextBoxColumn colAge;
        private DataGridViewCheckBoxColumn colUndergraduate;
        private DataGridViewComboBoxColumn colGender;
        private DataGridViewComboBoxColumn colUniversity;
        private DataGridViewButtonColumn colShowID;
        private BindingSource bsStudents;
        private DataGridView grvCourses;
        private DataGridView grvSchedule;
        private DataGridView grvGrades;
        private Button btnLoad;
        private Button btnSave;
    }
}