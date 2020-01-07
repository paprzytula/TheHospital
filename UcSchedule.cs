using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace THUI
{
    public partial class UcSchedule : UserControl
    {
        private static UcSchedule _instance;
        public static UcSchedule Instance {
            get {
                if (_instance==null)
                {
                    _instance= new UcSchedule();
                }
                return _instance;
            }
        }
        public UcSchedule()
        {
            InitializeComponent();
        }

        
    }
}
