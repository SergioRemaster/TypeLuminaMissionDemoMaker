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

namespace TypeLuminaMissionDemoMaker.CustomControls
{
    public partial class CommandEntry : UserControl
    {
        private CommandData commandData;
        private int listPosition;

        public int ListPosition { get => listPosition;
            set 
            {
                listPosition = value;
                LabPosition.Text = value.ToString();
            }
        }

        public CommandEntry()
        {
            InitializeComponent();
            commandData = new CommandData();

            SetAllButtons();
            SetDirection();
            NumFrames.Value = commandData.Frames;
        }

        public CommandEntry(CommandData commandData, int positionNum)
        {
            InitializeComponent();
            this.commandData = commandData;

            ListPosition = positionNum;
            SetAllButtons();
            SetDirection();
            NumFrames.Value = commandData.Frames;
        }

        private void SetDirection()
        {
            switch (commandData.DirectionCode)
            {
                case EDirectionCode.UpLeft:
                    PcbDirection.Image = Properties.Resources.upleft;
                    break;
                case EDirectionCode.Up:
                    PcbDirection.Image = Properties.Resources.up;
                    break;
                case EDirectionCode.UpRight:
                    PcbDirection.Image = Properties.Resources.upright;
                    break;
                case EDirectionCode.Left:
                    PcbDirection.Image = Properties.Resources.left;
                    break;
                case EDirectionCode.None:
                    PcbDirection.Image = Properties.Resources.nodir;
                    break;
                case EDirectionCode.Right:
                    PcbDirection.Image = Properties.Resources.right;
                    break;
                case EDirectionCode.DownLeft:
                    PcbDirection.Image = Properties.Resources.downleft;
                    break;
                case EDirectionCode.Down:
                    PcbDirection.Image = Properties.Resources.down;
                    break;
                case EDirectionCode.DownRight:
                    PcbDirection.Image = Properties.Resources.downright;
                    break;
            }
        }

        private void SetAllButtons()
        {
            ChangeButton(EButtonCode.A, PcbA, Properties.Resources.a, Properties.Resources.no_a);
            ChangeButton(EButtonCode.B, PcbB, Properties.Resources.b, Properties.Resources.no_b);
            ChangeButton(EButtonCode.C, PcbC, Properties.Resources.c, Properties.Resources.no_c);
            ChangeButton(EButtonCode.D, PcbD, Properties.Resources.d, Properties.Resources.no_d);
        }

        private void ChangeButton(EButtonCode buttonCode, PictureBox pictureBox, Image pictureEnabled, Image pictureDisabled)
        {
            if (commandData.ButtonCode.HasFlag(buttonCode))
                pictureBox.Image = pictureEnabled;
            else
                pictureBox.Image = pictureDisabled;
        }

        private void ChangeFlag(EButtonCode buttonCode)
        {
            if (commandData.ButtonCode.HasFlag(buttonCode))
                commandData.ButtonCode -= buttonCode;
            else
                commandData.ButtonCode ^= buttonCode;
        }

        private void PcbB_Click(object sender, EventArgs e)
        {
            ChangeFlag(EButtonCode.B);
            ChangeButton(EButtonCode.B, PcbB, Properties.Resources.b, Properties.Resources.no_b);
        }

        private void PcbA_Click(object sender, EventArgs e)
        {
            ChangeFlag(EButtonCode.A);
            ChangeButton(EButtonCode.A, PcbA, Properties.Resources.a, Properties.Resources.no_a);
        }

        private void PcbC_Click(object sender, EventArgs e)
        {
            ChangeFlag(EButtonCode.C);
            ChangeButton(EButtonCode.C, PcbC, Properties.Resources.c, Properties.Resources.no_c);
        }

        private void PcbD_Click(object sender, EventArgs e)
        {
            ChangeFlag(EButtonCode.D);
            ChangeButton(EButtonCode.D, PcbD, Properties.Resources.d, Properties.Resources.no_d);
        }

        private void PcbDirection_Click(object sender, EventArgs e)
        {
            FrmDirectionSelect form = new FrmDirectionSelect(commandData);
            form.ShowDialog();
            form.Dispose();
            SetDirection();
        }
    }
}
