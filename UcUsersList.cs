using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using THLIB;

namespace THUI
{
    public partial class UcUsersList : UserControl
    {
        private static UcUsersList _instance;
        public static UcUsersList Instance {
            get {
                if (_instance==null)
                {
                    _instance= new UcUsersList();
                }
                return _instance;
            }
        }
        public UcUsersList()
        {
            InitializeComponent();
        }

        private void UcUsersList_Load(object sender, EventArgs e)
        {
            employeeBindingSource.Add(new Employee() { Admin=true,FirstName="Paweł",LastName="Przytuła",Username="admin",Password="admin",JobPosition="Lekarz", Pesel=0});
               employeeBindingSource.Add(new Employee() { Admin=false,FirstName="Adam",LastName="Nowak",Username="lekarz1",Password="admin",JobPosition="Lekarz", Pesel=0});
               employeeBindingSource.Add(new Employee() { Admin=false,FirstName="Zenobia",LastName="Frans",Username="pigula1",Password="admin",JobPosition="Lekarz", Pesel=0});
               employeeBindingSource.Add(new Employee() { Admin=false,FirstName="Teodor",LastName="Kucewicz",Username="lekarz2",Password="admin",JobPosition="Lekarz", Pesel=0});

        }
    }
}
