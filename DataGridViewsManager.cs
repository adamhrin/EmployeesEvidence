using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEvidence
{
    public class DataGridViewsManager
    {
        private DataGridView DgvEmployees = null;
        private DataGridView DgvCompanyHead = null;
        private DataGridView DgvDivisionHead = null;
        private DataGridView DgvProjectHead = null;
        private DataGridView DgvDepartmentHead = null;

        public DataGridViewsManager()
        {
        }

        public void SetDgvEmployees(ref DataGridView dgvEmployees)
        {
            this.DgvEmployees = dgvEmployees;
        }

        public void SetDgvCompanyHead(ref DataGridView dgvCompanyHead)
        {
            this.DgvCompanyHead = dgvCompanyHead;
        }

        public void SetDgvDivisionHead(ref DataGridView dgvDivisionHead)
        {
            this.DgvDivisionHead = dgvDivisionHead;
        }

        public void SetDgvProjectHead(ref DataGridView dgvProjectHead)
        {
            this.DgvProjectHead = dgvProjectHead;
        }

        public void SetDgvDepartmentHead(ref DataGridView dgvDepartmentHead)
        {
            this.DgvDepartmentHead = dgvDepartmentHead;
        }


        public void PopulateDgvs(int idCurrentCompany, int idCurrentDivison, int idCurrentProject, int idCurrentDepartment)
        {
            using (EmployeesDbEntities1 context = new EmployeesDbEntities1())
            {
                List<Employee> companyHead = new List<Employee>();
                List<Employee> divisionHead = new List<Employee>();
                List<Employee> projectHead = new List<Employee>();
                List<Employee> departmentHead = new List<Employee>();
                List<Employee> employees = new List<Employee>();

                // NASTAVENIE HEADOV
                if (idCurrentCompany == 0)
                {
                    DgvCompanyHead.DataSource = null;
                }
                else
                {
                    companyHead.Add(context.Companies.FirstOrDefault(r => r.id_company == idCurrentCompany).Employee);
                    DgvCompanyHead.DataSource = companyHead;
                }

                if (idCurrentDivison == 0)
                {
                    DgvDivisionHead.DataSource = null;
                }
                else
                {
                    divisionHead.Add(context.Divisions.FirstOrDefault(r => r.id_division == idCurrentDivison).Employee);
                    DgvDivisionHead.DataSource = divisionHead;
                }

                if (idCurrentProject == 0)
                {
                    DgvProjectHead.DataSource = null;
                }
                else
                {
                    projectHead.Add(context.Projects.FirstOrDefault(r => r.id_project == idCurrentProject).Employee);
                    DgvProjectHead.DataSource = projectHead;
                }

                if (idCurrentDepartment == 0)
                {
                    DgvDepartmentHead.DataSource = null;
                }
                else
                {
                    departmentHead.Add(context.Departments.FirstOrDefault(r => r.id_department == idCurrentDepartment).Employee);
                    DgvDepartmentHead.DataSource = departmentHead;
                }

                // NASTAVENIE EMPLOYEES
                if (idCurrentCompany != 0 && idCurrentDivison == 0 && idCurrentProject == 0 && idCurrentDepartment == 0)
                {
                    Company company = context.Companies.FirstOrDefault(r => r.id_company == idCurrentCompany);
                    List<Division> divisions = company.Divisions.ToList();
                    List<Project> projects = new List<Project>();
                    foreach (Division division in divisions)
                    {
                        projects.AddRange(division.Projects.ToList());
                    }
                    List<Department> departments = new List<Department>();
                    foreach (Project project in projects)
                    {
                        departments.AddRange(project.Departments.ToList());
                    }
                    foreach (Department department in departments)
                    {
                        employees.AddRange(department.Employees.ToList());
                    }
                    DgvEmployees.DataSource = employees;
                }
                else if (idCurrentDivison != 0 && idCurrentProject == 0 && idCurrentDepartment == 0)
                {
                    Division division = context.Divisions.FirstOrDefault(r => r.id_division == idCurrentDivison);
                    List<Project> projects = division.Projects.ToList();
                    List<Department> departments = new List<Department>();
                    foreach (Project project in projects)
                    {
                        departments.AddRange(project.Departments.ToList());
                    }
                    foreach (Department department in departments)
                    {
                        employees.AddRange(department.Employees.ToList());
                    }
                    DgvEmployees.DataSource = employees;
                }
                else if (idCurrentProject != 0 && idCurrentDepartment == 0)
                {
                    Project project = context.Projects.FirstOrDefault(r => r.id_project == idCurrentProject);
                    List<Department> departments = project.Departments.ToList();
                    foreach (Department department in departments)
                    {
                        employees.AddRange(department.Employees.ToList());
                    }
                    DgvEmployees.DataSource = employees;
                }
                else if (idCurrentDepartment != 0)
                {
                    Department department = context.Departments.FirstOrDefault(r => r.id_department == idCurrentDepartment);
                    DgvEmployees.DataSource = department.Employees.ToList();
                }
                else
                {
                    DgvEmployees.DataSource = null;
                }
            }
        }
        
        public void PopulateDgvEmployees()
        {
            using (EmployeesDbEntities1 context = new EmployeesDbEntities1())
            {
                DgvEmployees.DataSource = context.Employees.ToList<Employee>();
            }
        }

        public void PopulateDgvHeads()
        {
            using (EmployeesDbEntities1 context = new EmployeesDbEntities1())
            {
                List<Employee> list = context.Employees.ToList<Employee>();
                List<Employee> one = new List<Employee>();
                one.Add(list[0]);
                DgvCompanyHead.DataSource = one;
                DgvDivisionHead.DataSource = one;
                DgvProjectHead.DataSource = one;
                DgvDepartmentHead.DataSource = one;
            }
        }

        public void dgvEmployees_DataBindingCompleteEvent(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridView gridView = sender as DataGridView;
            gridView.RowHeadersWidth = 55;
            if (null != gridView)
            {
                foreach (DataGridViewRow r in gridView.Rows)
                {
                    gridView.Rows[r.Index].HeaderCell.Value = (r.Index + 1).ToString();
                }
            }
        }

        public void dgvCompanyHead_DataBindingCompleteEvent(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DgvCompanyHead != null)
            {
                DgvCompanyHead.ClearSelection();
                DgvCompanyHead.RowHeadersWidth = 55;
            }
        }

        public void dgvDivisionHead_DataBindingCompleteEvent(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DgvCompanyHead != null)
            {
                DgvDivisionHead.ClearSelection();
                DgvDivisionHead.RowHeadersWidth = 55;
            }
        }

        public void dgvProjectHead_DataBindingCompleteEvent(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DgvCompanyHead != null)
            {
                DgvProjectHead.ClearSelection();
                DgvProjectHead.RowHeadersWidth = 55;
            }
        }

        public void dgvDepartmentHead_DataBindingCompleteEvent(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (DgvCompanyHead != null)
            {
                DgvDepartmentHead.ClearSelection();
                DgvDepartmentHead.RowHeadersWidth = 55;
            }
        }
    }
}
