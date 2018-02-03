using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEvidence
{
    public partial class Form1 : Form
    {
        ComboBoxesManager cbManager = new ComboBoxesManager();
        DataGridViewsManager dgvManager = new DataGridViewsManager();

        //public int IdCurrentCompany { get; set; }
        //public int IdCurrentDivison { get; set; }
        //public int IdCurrentProject { get; set; }
        //public int IdCurrentDepartment { get; set; }

        private int IdCurrentCompany = 0;
        private int IdCurrentDivison = 0;
        private int IdCurrentProject = 0;
        private int IdCurrentDepartment = 0;

        public Form1()
        {
            InitializeComponent();

            cbManager.SetCbCompanies(ref cbCompanies);
            cbManager.SetCbDivisions(ref cbDivisions);
            cbManager.SetCbProjects(ref cbProjects);
            cbManager.SetCbDepartments(ref cbDepartments);

            dgvManager.SetDgvEmployees(ref dgvEmployees);
            dgvManager.SetDgvCompanyHead(ref dgvCompanyHead);
            dgvManager.SetDgvDivisionHead(ref dgvDivisionHead);
            dgvManager.SetDgvProjectHead(ref dgvProjectHead);
            dgvManager.SetDgvDepartmentHead(ref dgvDepartmentHead);

            cbManager.SetComboBoxes(0, 0, 0, 0);

            dgvManager.PopulateDgvs(IdCurrentCompany, IdCurrentDivison, IdCurrentProject, IdCurrentDepartment);
        }

        private void AssignCbValuesToIdFields()
        {
            if (cbCompanies.SelectedValue != null)
            {
                int.TryParse(cbCompanies.SelectedValue.ToString(), out IdCurrentCompany);
            }
            else
            {
                IdCurrentCompany = 0;
            }

            if (cbDivisions.SelectedValue != null)
            {
                int.TryParse(cbDivisions.SelectedValue.ToString(), out IdCurrentDivison);
            }
            else
            {
                IdCurrentDivison = 0;
            }

            if (cbProjects.SelectedValue != null)
            {
                int.TryParse(cbProjects.SelectedValue.ToString(), out IdCurrentProject);
            }
            else
            {
                IdCurrentProject = 0;
            }

            if (cbDepartments.SelectedValue != null)
            {
                int.TryParse(cbDepartments.SelectedValue.ToString(), out IdCurrentDepartment);
            }
            else
            {
                IdCurrentDepartment = 0;
            }
        }

        private void cbCompanies_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cbCompanies.SelectedValue.ToString(), out IdCurrentCompany);
            cbManager.SetComboBoxes(IdCurrentCompany, 0, 0, 0);
            AssignCbValuesToIdFields();
            dgvManager.PopulateDgvs(IdCurrentCompany, IdCurrentDivison, IdCurrentProject, IdCurrentDepartment);
        }
        
        private void cbDivisions_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cbDivisions.SelectedValue.ToString(), out IdCurrentDivison);
            cbManager.SetComboBoxes(0, IdCurrentDivison, 0, 0);
            AssignCbValuesToIdFields();
            dgvManager.PopulateDgvs(IdCurrentCompany, IdCurrentDivison, IdCurrentProject, IdCurrentDepartment);
        }

        private void cbProjects_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cbProjects.SelectedValue.ToString(), out IdCurrentProject);
            cbManager.SetComboBoxes(0, 0, IdCurrentProject, 0);
            AssignCbValuesToIdFields();
            dgvManager.PopulateDgvs(IdCurrentCompany, IdCurrentDivison, IdCurrentProject, IdCurrentDepartment);
        }

        private void cbDepartments_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool result = int.TryParse(cbDepartments.SelectedValue.ToString(), out IdCurrentDepartment);
            cbManager.SetComboBoxes(0, 0, 0, IdCurrentDepartment);
            AssignCbValuesToIdFields();
            dgvManager.PopulateDgvs(IdCurrentCompany, IdCurrentDivison, IdCurrentProject, IdCurrentDepartment);
        }

        private void dgvEmployees_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManager.dgvEmployees_DataBindingCompleteEvent(sender, e);
        }

        private void dgvCompanyHead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManager.dgvCompanyHead_DataBindingCompleteEvent(sender, e);
        }

        private void dgvDivisionHead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManager.dgvDivisionHead_DataBindingCompleteEvent(sender, e);
        }

        private void dgvProjectHead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManager.dgvProjectHead_DataBindingCompleteEvent(sender, e);
        }

        private void dgvDepartmentHead_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvManager.dgvDepartmentHead_DataBindingCompleteEvent(sender, e);
        }
    }
}
