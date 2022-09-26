using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeLuminaMissionDemoMaker
{
    public partial class FrmInsertNumber : Form
    {
        private int pos = -1;

        public FrmInsertNumber(int setMaxNum)
        {
            InitializeComponent();
            NumPosition.Maximum = setMaxNum;
        }

        public int Pos { get => pos; set => pos = value; }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            pos = (int)NumPosition.Value;
            Close();
        }
    }
}
