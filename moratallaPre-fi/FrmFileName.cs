using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace moratallaPre_fi
{
    public partial class FrmFileName : Form
    {

        public static String txtFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        public static string SetFileName;

        private void FrmFileName_Load(object sender, EventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {

            SetFileName = txtFileName + ".txt";
            Close();
        }
    }
}
