using System;
using System.Windows.Forms;

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
            ScheduleBtn.Hide();
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
                }
                else
                {
                    UcSchedule.Instance.BringToFront();
                    UcSchedule.Instance.Show();
                    HideLogin();
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
        }

        private void EditScheduleBtn_Click(object sender, EventArgs e)
        {
        }
        #endregion

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