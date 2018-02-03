using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesEvidence
{
    public class ComboBoxesManager
    {
        private ComboBox CbCompanies = null;
        private ComboBox CbDivisions = null;
        private ComboBox CbProjects = null;
        private ComboBox CbDepartments = null;

        public ComboBoxesManager()
        {
        }

        public void SetCbCompanies(ref ComboBox cbCompanies)
        {
            this.CbCompanies = cbCompanies;
        }

        public void SetCbDivisions(ref ComboBox cbDivisions)
        {
            this.CbDivisions = cbDivisions;
        }

        public void SetCbProjects(ref ComboBox cbProjects)
        {
            this.CbProjects = cbProjects;
        }

        public void SetCbDepartments(ref ComboBox cbDepartments)
        {
            this.CbDepartments = cbDepartments;
        }

        /**
         * Metoda nastavi alebo obmedzi combo boxy pre vybraty poduzol
         * @param CVal - hodnota nastavena v cb Companies
         * @param DiVal - hodnota nastavena v cd Divisions
         * @param PVal - hodnota nastavena v cb Projects
         * @param DeVal - hodnota nastavena v cb Departments
         */
        public void SetComboBoxes(int CVal, int DiVal, int PVal, int DeVal)
        {
            using (EmployeesDbEntities1 context = new EmployeesDbEntities1())
            {
                if (CVal == 0 && DiVal == 0 && PVal == 0 && DeVal == 0)
                {
                    InitializeComboBoxes();
                }
                // NASTAVENE COMPANY 
                else if (CVal != 0 && DiVal == 0 && PVal == 0 && DeVal == 0)
                {
                    Company selectedCompany = context.Companies.FirstOrDefault(r => r.id_company == CVal);
                    List<Division> divisions = selectedCompany.Divisions.ToList();
                    SetCbDivisionsContent(divisions, "init");

                    List<Project> projects = new List<Project>();
                    foreach (Division division in divisions)
                    {
                        projects.AddRange(division.Projects.ToList());
                    }
                    SetCbProjectsContent(projects, "init");


                    List<Department> departments = new List<Department>();
                    foreach (Project project in projects)
                    {
                        departments.AddRange(project.Departments.ToList());
                    }
                    SetCbDepartmentsContent(departments, "init");
                }
                // NASTAVENE DIVISION
                else if (CVal == 0 && DiVal != 0 && PVal == 0 && DeVal == 0)
                {
                    Division selectedDivision = context.Divisions.FirstOrDefault(r => r.id_division == DiVal);

                    CbCompanies.SelectedValue = selectedDivision.id_company;

                    List<Project> projects = selectedDivision.Projects.ToList();
                    SetCbProjectsContent(projects, "init");

                    List<Department> departments = new List<Department>();
                    foreach (Project project in projects)
                    {
                        departments.AddRange(project.Departments.ToList());
                    }
                    SetCbDepartmentsContent(departments, "init");
                }
                // NASTAVENE PROJECT
                else if (CVal == 0 && DiVal == 0 && PVal != 0 && DeVal == 0)
                {
                    Project selectedProject = context.Projects.FirstOrDefault(r => r.id_project == PVal);

                    CbDivisions.SelectedValue = selectedProject.id_division;

                    Division toBeSelectedDivision = context.Divisions.FirstOrDefault(r => r.id_division == selectedProject.id_division);
                    CbCompanies.SelectedValue = toBeSelectedDivision.id_company;
                    
                    List<Department> departments = selectedProject.Departments.ToList();
                    SetCbDepartmentsContent(departments, "init");
                }
                // NASTAVENE DEPARTMENT
                else if (CVal == 0 && DiVal == 0 && PVal == 0 && DeVal != 0)
                {
                    Department selectedDepartment = context.Departments.FirstOrDefault(r => r.id_department == DeVal);

                    CbProjects.SelectedValue = selectedDepartment.id_project;

                    Project toBeSelectedProject = context.Projects.FirstOrDefault(r => r.id_project == selectedDepartment.id_project);
                    CbDivisions.SelectedValue = toBeSelectedProject.id_division;

                    Division toBeSelectedDivision = context.Divisions.FirstOrDefault(r => r.id_division == toBeSelectedProject.id_division);
                    CbCompanies.SelectedValue = toBeSelectedDivision.id_company;
                }
            }
        }

        private void InitializeComboBoxes()
        {
            using (EmployeesDbEntities1 context = new EmployeesDbEntities1())
            {
                var dataSourceComp = context.Companies.ToList<Company>();
                SetCbCompaniesContent(dataSourceComp, "init");

                var dataSourceDiv = context.Divisions.ToList<Division>();
                SetCbDivisionsContent(dataSourceDiv, "init");

                var dataSourceProj = context.Projects.ToList<Project>();
                SetCbProjectsContent(dataSourceProj, "init");

                var dataSourceDep = context.Departments.ToList<Department>();
                SetCbDepartmentsContent(dataSourceDep, "init");
            }
        }

        private void SetCbCompaniesContent(List<Company> dataSource, string v)
        {
            CbCompanies.DataSource = dataSource;
            CbCompanies.DisplayMember = "name";
            CbCompanies.ValueMember = "id_company";
            if (v == "init")
            {
                CbCompanies.SelectedItem = null;
                CbCompanies.Text = "--Select--";
            }
        }

        private void SetCbDivisionsContent(List<Division> dataSourceDiv, string v)
        {
            CbDivisions.DataSource = dataSourceDiv;
            CbDivisions.DisplayMember = "name";
            CbDivisions.ValueMember = "id_division";
            if (v == "init")
            {
                CbDivisions.SelectedItem = null;
                CbDivisions.Text = "--Select--";
            }
        }

        private void SetCbProjectsContent(List<Project> dataSourceProj, string v)
        {
            CbProjects.DataSource = dataSourceProj;
            CbProjects.DisplayMember = "name";
            CbProjects.ValueMember = "id_project";
            if (v == "init")
            {
                CbProjects.SelectedItem = null;
                CbProjects.Text = "--Select--";
            }
        }

        private void SetCbDepartmentsContent(List<Department> dataSourceDep, string v)
        {
            CbDepartments.DataSource = dataSourceDep;
            CbDepartments.DisplayMember = "name";
            CbDepartments.ValueMember = "id_department";
            if (v == "init")
            {
                CbDepartments.SelectedItem = null;
                CbDepartments.Text = "--Select--";
            }
        }
    }
}
