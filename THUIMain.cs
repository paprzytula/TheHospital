using System;
using System.Windows.Forms;
using THLIB;

namespace THUI
{
    public partial class THUIMain : Form
    {
        public THUIMain()
        {
            InitializeComponent();
        }

        private void THUIMain_Load(object sender, EventArgs e)
        {
            LogoutBtn.Hide();
            ScheduleBtn.Enabled = false;
            EditScheduleBtn.Enabled = false;
            EmployeesListBtn.Enabled = false;
            EditEmployeesBtn.Enabled = false;
            FileOperations.FileExistCheck();
            FileOperations.GetFileFromLocation();
        }

        #region buttons

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            UcSchedule.Instance.Hide();
            UcUsersList.Instance.Hide();
            UcEditUsers.Instance.Hide();

            ShowLogin();
        }

        private void ScheduleBtn_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UcSchedule.Instance))
            {
                panel1.Controls.Add(UcSchedule.Instance);
                UcSchedule.Instance.Dock = DockStyle.Fill;
                UcSchedule.Instance.BringToFront();
                HideLogin();
            }
            else
            {
                UcSchedule.Instance.BringToFront();
                HideLogin();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string id = UsernameTxt.Text;
            string pass = PasswordTxt.Text;
            if (id == "" && pass == "")
            {
                if (!panel1.Controls.Contains(UcSchedule.Instance))
                {
                    panel1.Controls.Add(UcSchedule.Instance);
                    UcSchedule.Instance.Dock = DockStyle.Fill;
                    UcSchedule.Instance.BringToFront();
                    HideLogin();
                    ScheduleBtn.Enabled = true;
                    EmployeesListBtn.Enabled = true;
                    EditEmployeesBtn.Enabled = true;
                }
                else
                {
                    UcSchedule.Instance.BringToFront();
                    UcSchedule.Instance.Show();
                    HideLogin();
                    ScheduleBtn.Enabled = true;
                    EmployeesListBtn.Enabled = true;
                    EditEmployeesBtn.Enabled = true;
                }
            }
            else { MessageBox.Show("Login lub hasło niepoprawne."); }
        }

        private void EmployeesListBtn_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UcUsersList.Instance))
            {
                panel1.Controls.Add(UcUsersList.Instance);
                UcUsersList.Instance.Dock = DockStyle.Fill;
                UcUsersList.Instance.BringToFront();
                HideLogin();
            }
            else
            {
                UcUsersList.Instance.BringToFront();
                HideLogin();
            }
        }

        private void EditEmployeesBtn_Click(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UcEditUsers.Instance))
            {
                panel1.Controls.Add(UcEditUsers.Instance);
                UcEditUsers.Instance.Dock = DockStyle.Fill;
                UcEditUsers.Instance.BringToFront();
                HideLogin();
            }
            else
            {
                UcEditUsers.Instance.BringToFront();
                HideLogin();
            }
        }

        private void EditScheduleBtn_Click(object sender, EventArgs e)
        {// todo add enable users schedule after login
        }

        #endregion buttons

        #region Login Service

        private void HideLogin()
        {
            PasswordTxt.Hide();
            PasswordLbl.Hide();
            UsernameTxt.Hide();
            UsernameLbl.Hide();
            LoginBtn.Hide();
            LogoutBtn.Show();
            ScheduleBtn.Show();
        }

        private void ShowLogin()
        {
            PasswordTxt.Show();
            PasswordLbl.Show();
            UsernameTxt.Show();
            UsernameLbl.Show();
            LoginBtn.Show();
            LogoutBtn.Hide();
        }

        # endregion
    }//end public partial class THUIMain : Form
}// end namespace THUI