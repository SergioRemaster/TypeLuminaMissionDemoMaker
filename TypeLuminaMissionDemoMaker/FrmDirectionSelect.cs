using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypeLuminaMissionDemoMaker.MissionData;
using TypeLuminaMissionDemoMaker.MissionData.Enums;

namespace TypeLuminaMissionDemoMaker
{
    public partial class FrmDirectionSelect : Form
    {
        private CommandData commandData = new CommandData();

        public FrmDirectionSelect(CommandData commandData)
        {
            InitializeComponent();
            this.commandData = commandData;
        }

        private void PcbUpLeft_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.UpLeft;
            Close();
        }

        private void PcbUp_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.Up;
            Close();
        }

        private void PcbUpRight_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.UpRight;
            Close();
        }

        private void PcbLeft_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.Left;
            Close();
        }

        private void PcbNoDir_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.None;
            Close();
        }

        private void PcbRight_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.Right;
            Close();
        }

        private void PcbDownLeft_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.DownLeft;
            Close();
        }

        private void PcbDown_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.Down;
            Close();
        }

        private void PcbDownRight_Click(object sender, EventArgs e)
        {
            commandData.DirectionCode = EDirectionCode.DownRight;
            Close();
        }
    }
}
