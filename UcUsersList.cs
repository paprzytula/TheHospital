using System;
using System.Windows.Forms;
using THLIB;
using static THLIB.FileOperations;

namespace THUI
{
    public partial class UcUsersList : UserControl
    {
        private static UcUsersList _instance;

        public static UcUsersList Instance {
            get {
                if (_instance == null)
                {
                    _instance = new UcUsersList();
                }
                return _instance;
            }
        }

        public UcUsersList()
        {
            InitializeComponent();
        }

       

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void SearchFileBtn_Click(object sender, EventArgs e)
        {
            GetFileFromLocation();
        }
    }
}