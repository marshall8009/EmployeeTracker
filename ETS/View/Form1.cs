using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//...
using Model;
using Controller;

namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //reload values into datagrid
        #region
        private void Reload()
        {
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectAll();
            switch (result.Status)
            {
                case ResultEnum.Success:
                    dataGridView1.DataSource = result.Data;
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot display employees at this time.");
                    break;
            }
        }
        #endregion

        //load employee names
        #region
        private void LoadEmpList()
        {
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectAllSortedByFirstName();
            switch (result.Status)
            {
                case ResultEnum.Success:
                    lstEmployeeList.DataSource = result.Data;
                    lstEmployeeList.DisplayMember = "Name";

                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot display employees at this time.");
                    break;
            }
        }
        #endregion

        //form load
        #region
        private void Form1_Load(object sender, EventArgs e)
        {
            Reload();
            LoadEmpList();
            dtbUpdateDob.MaxDate = DateTime.Now;
            dtpDOB.MaxDate = DateTime.Now;
            dtbWorkDate.MaxDate = DateTime.Now;
        }
        #endregion

        //clear textbox values
        #region
        public void ClearValues()
        {
            txtEmpId.Clear();
            txtUpdateFirstName.Clear();
            txtUpdateLastName.Clear();
            dtbUpdateDob.Text = DateTime.Today.ToString();
            txtUpdateEmail.Clear();
            txtUpdatePhone.Clear();
        }
        #endregion

        //add employee
        #region
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //validation
            if (!ValidationHelper.LettersOnly(txtFirstName.Text) &&
                !ValidationHelper.LettersOnly(txtLastName.Text))
            {
                MessageBox.Show("Please enter a valid first or last name consisting of letters only");
                return;
            }
            else if (!ValidationHelper.IsEmail(txtEmail.Text))
            {
                MessageBox.Show("Please enter valid email");
                return;
            }
            else if (!ValidationHelper.NumberWithDashOrDecimal(txtPhone.Text))
            {
                MessageBox.Show("Please enter a vaild phone number");
                return;
            }
            //read input
            Employee emp = new Employee();
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Email = txtEmail.Text;
            emp.Phone = txtPhone.Text;
            emp.DOB = DateTime.Parse(dtpDOB.Text);

            //pass to the controller
            EmployeeController controller = new EmployeeController();
            ResultEnum result = controller.Add(emp);

            //show output
            switch (result)
            {
                case ResultEnum.Success:
                    MessageBox.Show("Employee Added.");
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot add employee");
                    break;
            }
        }
        #endregion

        //search employee by id
        #region
        private void btnSearchId_Click(object sender, EventArgs e)
        {
            //validation
            if (!ValidationHelper.NumberOnly(txtSelectId.Text))
            {
                MessageBox.Show("Please enter a valid id number");
                return;
            }

            //read input
            int id = int.Parse(txtSelectId.Text);

            //pass to controller
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectById(id);

            switch (result.Status)
            {
                case ResultEnum.Success:
                    txtEmpId.Text = result.Data[0].EmpID.ToString();
                    txtUpdateFirstName.Text = result.Data[0].FirstName;
                    txtUpdateLastName.Text = result.Data[0].LastName;
                    txtUpdateEmail.Text = result.Data[0].Email;
                    txtUpdatePhone.Text = result.Data[0].Phone;
                    dtbUpdateDob.Text = result.Data[0].DOB.ToString();
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot retrieve employee information");
                    break;
            }
        }
        #endregion

        //search employee by email
        #region
        private void btnEmailSearch_Click(object sender, EventArgs e)
        {
            //validation
            if (!ValidationHelper.IsEmail(txtEmailSearch.Text))
            {
                MessageBox.Show("Please enter a valid email");
                return;
            }

            //read input
            string email = txtEmailSearch.Text;

            //pass to controller
            EmployeeController controller = new EmployeeController();
            Result<Employee> result = controller.SelectByEmail(email);

            switch (result.Status)
            {
                case ResultEnum.Success:
                    dataGridView1.DataSource = result.Data;
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot dispaly employee oinfo.");
                    break;
            }
        }
        #endregion

        //update employee
        #region
        public void btnUpdate_Click(object sender, EventArgs e)
        {
            //validation
            if (!ValidationHelper.LettersOnly(txtUpdateFirstName.Text) && 
                !ValidationHelper.LettersOnly(txtUpdateLastName.Text))  
            {
                MessageBox.Show("Please enter letters only");
                return;
            }
            else if (!ValidationHelper.IsEmail(txtUpdateEmail.Text))
            {
                MessageBox.Show("Please enter valid email");
                return;
            }
            else if (!ValidationHelper.NumberWithDashOrDecimal(txtUpdatePhone.Text))
            {
                MessageBox.Show("Please enter vaild input");
                return;
            }

            //read input
            Employee emp = new Employee();
            emp.EmpID = int.Parse(txtEmpId.Text);
            emp.FirstName = txtUpdateFirstName.Text;
            emp.LastName = txtUpdateLastName.Text;
            emp.Email = txtUpdateEmail.Text;
            emp.DOB = DateTime.Parse(dtbUpdateDob.Text);
            emp.Phone = txtUpdatePhone.Text;

            //pass to controller
            EmployeeController controller = new EmployeeController();
            ResultEnum result = controller.Update(emp);

            //show output
            switch (result)
            {
                case ResultEnum.Success:
                    MessageBox.Show("Employee updated.");
                    ClearValues();
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Error - cannot update employee");
                    break;
            }
        }
        #endregion

        //refresh list of employees
        #region
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Reload();
        }
        #endregion

        //show employees in listbox
        #region
        private void lstEmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = (Employee)lstEmployeeList.SelectedItem;
            txtIdEmp.Text = emp.EmpID.ToString();

        }
        #endregion

        //Record employee hours
        #region
        private void btnRecordHours_Click(object sender, EventArgs e)
        {
            //validation
            if (!ValidationHelper.NumberWithDashOrDecimal(txtHours.Text))
            {
                MessageBox.Show("Please enter the amount of hours employee has worked.");
                return;
            }
            
            //read input
            EmpHours empHours = new EmpHours();
            empHours.EmpID = int.Parse(txtIdEmp.Text);
            empHours.WorkDate = DateTime.Parse(dtbWorkDate.Text);
            empHours.Hours = decimal.Parse(txtHours.Text);

            //pass to controller
            EmpHoursController controller = new EmpHoursController();
            ResultEnum result = controller.AddHours(empHours);

            //show output
            switch (result)
            {
                case ResultEnum.Success:
                    MessageBox.Show("Hours added.");
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot add hours");
                    break;
            }

        }
        #endregion

        //display employee total hours
        #region
        private void btnDisplay_Click(object sender, EventArgs e)
        {

            //validation
            if (!ValidationHelper.NumberOnly(txtIdDisplay.Text))
            {
                MessageBox.Show("Please enter a valid id number");
                return;
            }
            //read input
            int id = int.Parse(txtIdDisplay.Text);

            //pass to controller

            //call emphours controller for hours info
            EmpHoursController controller = new EmpHoursController();
            Result<EmpHours> result = controller.DisplayWorkInfo(id);

            //call employee controller to retrieve employee name
            EmployeeController controller1 = new EmployeeController();
            Result<Employee> result1 = controller1.SelectById(id);

            Employee emp = new Employee();
            switch (result.Status)
            {
                case ResultEnum.Success:
                    if (result.Data.Count == 0)
                    {
                        if (result1.Data.Count == 0)
                        {
                            lblEmployeeName.Text = "Employee does not exist.";
                            lblTotalHours.Text = "No recorded hours.";
                            break;
                        }
                        lblEmployeeName.Text = result1.Data[0].ToString();
                        lblTotalHours.Text = "No recorded hours.";
                        break;
                    }
                    txtIdDisplay.Text = result.Data[0].EmpID.ToString();
                    lblEmployeeName.Text = result1.Data[0].ToString();
                    decimal total = 0;
                    foreach (var item in result.Data)
                    {
                        total += item.Hours;
                    }
                    lblTotalHours.Text = total.ToString();
                    break;
                case ResultEnum.Fail:
                    MessageBox.Show("Cannot display employee info.");
                    break;

            }
        }
        #endregion

        //refresh employee list for recording hours
        #region
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadEmpList();
        }
        #endregion
    }
}
