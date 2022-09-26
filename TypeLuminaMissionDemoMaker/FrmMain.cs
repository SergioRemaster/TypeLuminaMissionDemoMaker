using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;
using TypeLuminaMissionDemoMaker.CustomControls;
using TypeLuminaMissionDemoMaker.MissionData;

namespace TypeLuminaMissionDemoMaker
{
    public partial class FrmMain : Form
    {
        private CommandSequence commandSequence = new CommandSequence();
        private string lastFilePath = "";

        private const string TITLE_DEFAULT = "Mission Demo Maker";

        public FrmMain()
        {
            InitializeComponent();
        }

        private string LastFilePath
        {
            get => lastFilePath;
            set
            {
                lastFilePath = value;
                if(String.IsNullOrWhiteSpace(lastFilePath))
                    Text = TITLE_DEFAULT;
                else
                    Text = TITLE_DEFAULT + " - " + Path.GetFileName(lastFilePath);
            }
        }

        private bool CheckIfSafeSave()
        {
            if (commandSequence.CommandList.Count == 0)
            {
                MessageBox.Show("You can't save a demo data with no command list!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void AddChildObjectToPanel(int index, Control child)
        {
            child.Parent = FlpCommandList;
            FlpCommandList.Controls.SetChildIndex(child, index);
            RepositionAllCommands(index+1);
        }

        private void RepositionAllCommands(int index)
        {
            for (int x = index; x < FlpCommandList.Controls.Count; ++x)
            {
                ((CommandEntry)FlpCommandList.Controls[x]).ListPosition = x;
            }
        }

        private void MnuNewSequence_Click(object sender, EventArgs e)
        {
            FlpCommandList.Controls.Clear();
            commandSequence.CommandList.Clear();
            LastFilePath = "";
        }

        private void MnuLoadSequence_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = ".";
                ofd.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    commandSequence.LoadFromFile(ofd.FileName);
                    LastFilePath = ofd.FileName;
                    FlpCommandList.Controls.Clear();
                    for (int x = 0; x < commandSequence.CommandList.Count; ++x)
                    {
                        FlpCommandList.Controls.Add(new CommandEntry(commandSequence.CommandList[x], x));
                    }
                }
            }
        }

        private void BtnInsertCommand_Click(object sender, EventArgs e)
        {
            FrmInsertNumber form = new FrmInsertNumber(commandSequence.CommandList.Count);
            form.ShowDialog();
            if (form.Pos > -1)
            {
                CommandData cmd = new CommandData();
                commandSequence.CommandList.Insert(form.Pos, cmd);
                AddChildObjectToPanel(form.Pos,new CommandEntry(commandSequence.CommandList[form.Pos], form.Pos));
            }
        }

        private void BtnAppendCommand_Click(object sender, EventArgs e)
        {
            commandSequence.CommandList.Add(new CommandData());
            AddChildObjectToPanel(commandSequence.CommandList.Count - 1, new CommandEntry(commandSequence.CommandList.Last(), commandSequence.CommandList.Count-1));
        }

        private void BtnDeleteCommand_Click(object sender, EventArgs e)
        {
            FrmInsertNumber form = new FrmInsertNumber(commandSequence.CommandList.Count);
            form.ShowDialog();
            if (form.Pos > -1)
            {
                commandSequence.CommandList.RemoveAt(form.Pos);
                FlpCommandList.Controls.RemoveAt(form.Pos);
                RepositionAllCommands(form.Pos);
            }
        }

        private void MnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MnuSaveSequence_Click(object sender, EventArgs e)
        {
            if (CheckIfSafeSave())
            {
                if (String.IsNullOrWhiteSpace(lastFilePath))
                    MnuSaveAsSequence_Click(sender, e);
                else
                {
                    commandSequence.SaveCommandListData(lastFilePath);
                }
            }
        }

        private void MnuSaveAsSequence_Click(object sender, EventArgs e)
        {
            if (CheckIfSafeSave())
            {
                using (SaveFileDialog ofd = new SaveFileDialog())
                {
                    ofd.InitialDirectory = ".";
                    ofd.Filter = "dat files (*.dat)|*.dat|All files (*.*)|*.*";
                    ofd.FilterIndex = 1;
                    ofd.RestoreDirectory = true;
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        commandSequence.SaveCommandListData(ofd.FileName);
                        LastFilePath = ofd.FileName;
                    }
                }
            }
        }
    }
}