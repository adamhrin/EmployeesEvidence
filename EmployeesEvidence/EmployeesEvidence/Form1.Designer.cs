using System;
using System.Windows.Forms;

namespace EmployeesEvidence
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.cbDivisions = new System.Windows.Forms.ComboBox();
            this.cbProjects = new System.Windows.Forms.ComboBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblProject = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.dgvCompanyHead = new System.Windows.Forms.DataGridView();
            this.dgvDivisionHead = new System.Windows.Forms.DataGridView();
            this.lblCompanyHead = new System.Windows.Forms.Label();
            this.lblDivisionHead = new System.Windows.Forms.Label();
            this.lblProjectHead = new System.Windows.Forms.Label();
            this.dgvProjectHead = new System.Windows.Forms.DataGridView();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDepartmentHead = new System.Windows.Forms.Label();
            this.dgvDepartmentHead = new System.Windows.Forms.DataGridView();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.titleDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivisionHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "press";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmployees.AutoGenerateColumns = false;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvEmployees.DataSource = this.employeeBindingSource;
            this.dgvEmployees.Location = new System.Drawing.Point(12, 270);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvEmployees.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.Size = new System.Drawing.Size(682, 196);
            this.dgvEmployees.TabIndex = 1;
            this.dgvEmployees.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvEmployees_DataBindingComplete);
            // 
            // cbCompanies
            // 
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(12, 25);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(121, 21);
            this.cbCompanies.TabIndex = 2;
            this.cbCompanies.SelectionChangeCommitted += new System.EventHandler(this.cbCompanies_SelectionChangeCommitted);
            // 
            // cbDivisions
            // 
            this.cbDivisions.FormattingEnabled = true;
            this.cbDivisions.Location = new System.Drawing.Point(139, 25);
            this.cbDivisions.Name = "cbDivisions";
            this.cbDivisions.Size = new System.Drawing.Size(121, 21);
            this.cbDivisions.TabIndex = 2;
            this.cbDivisions.SelectionChangeCommitted += new System.EventHandler(this.cbDivisions_SelectionChangeCommitted);
            // 
            // cbProjects
            // 
            this.cbProjects.FormattingEnabled = true;
            this.cbProjects.Location = new System.Drawing.Point(266, 25);
            this.cbProjects.Name = "cbProjects";
            this.cbProjects.Size = new System.Drawing.Size(121, 21);
            this.cbProjects.TabIndex = 2;
            this.cbProjects.SelectionChangeCommitted += new System.EventHandler(this.cbProjects_SelectionChangeCommitted);
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(393, 25);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(121, 21);
            this.cbDepartments.TabIndex = 2;
            this.cbDepartments.SelectionChangeCommitted += new System.EventHandler(this.cbDepartments_SelectionChangeCommitted);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(9, 9);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(51, 13);
            this.lblCompany.TabIndex = 3;
            this.lblCompany.Text = "Company";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(136, 9);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 3;
            this.lblDivision.Text = "Division";
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(263, 9);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 3;
            this.lblProject.Text = "Project";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(390, 9);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // dgvCompanyHead
            // 
            this.dgvCompanyHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompanyHead.AutoGenerateColumns = false;
            this.dgvCompanyHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanyHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1,
            this.emailDataGridViewTextBoxColumn1});
            this.dgvCompanyHead.DataSource = this.employeeBindingSource;
            this.dgvCompanyHead.Location = new System.Drawing.Point(13, 74);
            this.dgvCompanyHead.Name = "dgvCompanyHead";
            this.dgvCompanyHead.Size = new System.Drawing.Size(681, 45);
            this.dgvCompanyHead.TabIndex = 4;
            this.dgvCompanyHead.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCompanyHead_DataBindingComplete);
            // 
            // dgvDivisionHead
            // 
            this.dgvDivisionHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDivisionHead.AutoGenerateColumns = false;
            this.dgvDivisionHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDivisionHead.ColumnHeadersVisible = false;
            this.dgvDivisionHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn2,
            this.firstnameDataGridViewTextBoxColumn2,
            this.surnameDataGridViewTextBoxColumn2,
            this.phoneDataGridViewTextBoxColumn2,
            this.emailDataGridViewTextBoxColumn2});
            this.dgvDivisionHead.DataSource = this.employeeBindingSource;
            this.dgvDivisionHead.Location = new System.Drawing.Point(12, 138);
            this.dgvDivisionHead.Name = "dgvDivisionHead";
            this.dgvDivisionHead.Size = new System.Drawing.Size(682, 25);
            this.dgvDivisionHead.TabIndex = 5;
            this.dgvDivisionHead.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDivisionHead_DataBindingComplete);
            // 
            // lblCompanyHead
            // 
            this.lblCompanyHead.AutoSize = true;
            this.lblCompanyHead.Location = new System.Drawing.Point(9, 58);
            this.lblCompanyHead.Name = "lblCompanyHead";
            this.lblCompanyHead.Size = new System.Drawing.Size(92, 13);
            this.lblCompanyHead.TabIndex = 6;
            this.lblCompanyHead.Text = "Head of Company";
            // 
            // lblDivisionHead
            // 
            this.lblDivisionHead.AutoSize = true;
            this.lblDivisionHead.Location = new System.Drawing.Point(9, 122);
            this.lblDivisionHead.Name = "lblDivisionHead";
            this.lblDivisionHead.Size = new System.Drawing.Size(85, 13);
            this.lblDivisionHead.TabIndex = 7;
            this.lblDivisionHead.Text = "Head of Division";
            // 
            // lblProjectHead
            // 
            this.lblProjectHead.AutoSize = true;
            this.lblProjectHead.Location = new System.Drawing.Point(9, 166);
            this.lblProjectHead.Name = "lblProjectHead";
            this.lblProjectHead.Size = new System.Drawing.Size(81, 13);
            this.lblProjectHead.TabIndex = 8;
            this.lblProjectHead.Text = "Head of Project";
            // 
            // dgvProjectHead
            // 
            this.dgvProjectHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProjectHead.AutoGenerateColumns = false;
            this.dgvProjectHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjectHead.ColumnHeadersVisible = false;
            this.dgvProjectHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn3,
            this.firstnameDataGridViewTextBoxColumn3,
            this.surnameDataGridViewTextBoxColumn3,
            this.phoneDataGridViewTextBoxColumn3,
            this.email});
            this.dgvProjectHead.DataSource = this.employeeBindingSource;
            this.dgvProjectHead.Location = new System.Drawing.Point(12, 182);
            this.dgvProjectHead.Name = "dgvProjectHead";
            this.dgvProjectHead.Size = new System.Drawing.Size(679, 25);
            this.dgvProjectHead.TabIndex = 9;
            this.dgvProjectHead.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvProjectHead_DataBindingComplete);
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // lblDepartmentHead
            // 
            this.lblDepartmentHead.AutoSize = true;
            this.lblDepartmentHead.Location = new System.Drawing.Point(9, 210);
            this.lblDepartmentHead.Name = "lblDepartmentHead";
            this.lblDepartmentHead.Size = new System.Drawing.Size(103, 13);
            this.lblDepartmentHead.TabIndex = 10;
            this.lblDepartmentHead.Text = "Head of Department";
            // 
            // dgvDepartmentHead
            // 
            this.dgvDepartmentHead.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDepartmentHead.AutoGenerateColumns = false;
            this.dgvDepartmentHead.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartmentHead.ColumnHeadersVisible = false;
            this.dgvDepartmentHead.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn4,
            this.firstnameDataGridViewTextBoxColumn4,
            this.surnameDataGridViewTextBoxColumn4,
            this.phoneDataGridViewTextBoxColumn4,
            this.emailDataGridViewTextBoxColumn3});
            this.dgvDepartmentHead.DataSource = this.employeeBindingSource;
            this.dgvDepartmentHead.Location = new System.Drawing.Point(12, 226);
            this.dgvDepartmentHead.Name = "dgvDepartmentHead";
            this.dgvDepartmentHead.Size = new System.Drawing.Size(679, 25);
            this.dgvDepartmentHead.TabIndex = 11;
            this.dgvDepartmentHead.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDepartmentHead_DataBindingComplete);
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(9, 254);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(58, 13);
            this.lblEmployees.TabIndex = 12;
            this.lblEmployees.Text = "Employees";
            // 
            // titleDataGridViewTextBoxColumn4
            // 
            this.titleDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn4.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn4.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn4.Name = "titleDataGridViewTextBoxColumn4";
            // 
            // firstnameDataGridViewTextBoxColumn4
            // 
            this.firstnameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn4.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn4.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn4.Name = "firstnameDataGridViewTextBoxColumn4";
            // 
            // surnameDataGridViewTextBoxColumn4
            // 
            this.surnameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn4.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn4.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn4.Name = "surnameDataGridViewTextBoxColumn4";
            // 
            // phoneDataGridViewTextBoxColumn4
            // 
            this.phoneDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn4.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn4.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn4.Name = "phoneDataGridViewTextBoxColumn4";
            // 
            // emailDataGridViewTextBoxColumn3
            // 
            this.emailDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn3.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn3.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn3.Name = "emailDataGridViewTextBoxColumn3";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(EmployeesEvidence.Employee);
            // 
            // titleDataGridViewTextBoxColumn3
            // 
            this.titleDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn3.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn3.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn3.Name = "titleDataGridViewTextBoxColumn3";
            // 
            // firstnameDataGridViewTextBoxColumn3
            // 
            this.firstnameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn3.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn3.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn3.Name = "firstnameDataGridViewTextBoxColumn3";
            // 
            // surnameDataGridViewTextBoxColumn3
            // 
            this.surnameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn3.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn3.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn3.Name = "surnameDataGridViewTextBoxColumn3";
            // 
            // phoneDataGridViewTextBoxColumn3
            // 
            this.phoneDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn3.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn3.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn3.Name = "phoneDataGridViewTextBoxColumn3";
            // 
            // titleDataGridViewTextBoxColumn2
            // 
            this.titleDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn2.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn2.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn2.Name = "titleDataGridViewTextBoxColumn2";
            // 
            // firstnameDataGridViewTextBoxColumn2
            // 
            this.firstnameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn2.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn2.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn2.Name = "firstnameDataGridViewTextBoxColumn2";
            // 
            // surnameDataGridViewTextBoxColumn2
            // 
            this.surnameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn2.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn2.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn2.Name = "surnameDataGridViewTextBoxColumn2";
            // 
            // phoneDataGridViewTextBoxColumn2
            // 
            this.phoneDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn2.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn2.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn2.Name = "phoneDataGridViewTextBoxColumn2";
            // 
            // emailDataGridViewTextBoxColumn2
            // 
            this.emailDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn2.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn2.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn2.Name = "emailDataGridViewTextBoxColumn2";
            // 
            // titleDataGridViewTextBoxColumn1
            // 
            this.titleDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn1.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn1.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn1.Name = "titleDataGridViewTextBoxColumn1";
            // 
            // firstnameDataGridViewTextBoxColumn1
            // 
            this.firstnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn1.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn1.HeaderText = "firstname";
            this.firstnameDataGridViewTextBoxColumn1.Name = "firstnameDataGridViewTextBoxColumn1";
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "phone";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataSource = typeof(EmployeesEvidence.Company);
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataSource = typeof(EmployeesEvidence.Company);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 483);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.dgvDepartmentHead);
            this.Controls.Add(this.lblDepartmentHead);
            this.Controls.Add(this.dgvProjectHead);
            this.Controls.Add(this.lblProjectHead);
            this.Controls.Add(this.lblDivisionHead);
            this.Controls.Add(this.lblCompanyHead);
            this.Controls.Add(this.dgvDivisionHead);
            this.Controls.Add(this.dgvCompanyHead);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.cbProjects);
            this.Controls.Add(this.cbDivisions);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanyHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDivisionHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjectHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartmentHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private System.Windows.Forms.ComboBox cbDivisions;
        private System.Windows.Forms.ComboBox cbProjects;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvCompanyHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvDivisionHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label lblCompanyHead;
        private System.Windows.Forms.Label lblDivisionHead;
        private System.Windows.Forms.Label lblProjectHead;
        private System.Windows.Forms.DataGridView dgvProjectHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.Label lblDepartmentHead;
        private System.Windows.Forms.DataGridView dgvDepartmentHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblEmployees;
    }
}

