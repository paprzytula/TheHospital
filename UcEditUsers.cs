using System;
using System.Drawing;
using System.Windows.Forms;
using THLIB;

namespace THUI
{
    public partial class UcEditUsers : UserControl
    {
        private static UcEditUsers _instance;

        public static UcEditUsers Instance {
            get {
                if (_instance == null)
                {
                    _instance = new UcEditUsers();
                }
                return _instance;
            }
        }

        public UcEditUsers()
        {
            InitializeComponent();
        }

        private void ValidatePeselBtn_Click(object sender, EventArgs e)
        {
            if (PeselValidator.ValidatePesel(EditPeselTxt.Text) == true)
            {
                ValidatePeselLbl.ForeColor = Color.Green;
                ValidatePeselLbl.Text = "PESEL OK";
            }
            else
            {
                ValidatePeselLbl.ForeColor = Color.Red;
                ValidatePeselLbl.Text = "PESEL niepoprawny.";
            }
        }
    }
}