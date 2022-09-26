using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLuminaMissionDemoMaker.MissionData.Enums;

namespace TypeLuminaMissionDemoMaker.MissionData
{
    public class CommandSequence
    {
        private List<CommandData> commandList = new List<CommandData>();

        public CommandSequence()
        {
        }

        public List<CommandData> CommandList { get => commandList; set => commandList = value; }

        public int GetTotalFrames()
        {
            int x = 0;
            commandList.ForEach(p => x += p.Frames);
            return x;
        }

        public void LoadFromFile(string filepath)
        {
            using (BinaryReader reader = new BinaryReader(File.Open(filepath, FileMode.Open)))
            {
                commandList.Clear();
                reader.BaseStream.Seek(8, SeekOrigin.Begin);
                int commandNum = reader.ReadInt32();
                EButtonCode btnCode;
                EDirectionCode dirCode;

                for (int x = 0; x < commandNum; ++x)
                {
                    btnCode = (EButtonCode)reader.ReadByte();
                    dirCode = (EDirectionCode)reader.ReadByte();

                    if (commandList.Count > 0)
                    {
                        CommandData cmd = commandList.Last();
                        if (cmd.DirectionCode == dirCode && cmd.ButtonCode == btnCode)
                            cmd.Frames++;
                        else
                            commandList.Add(new CommandData(1, dirCode, btnCode));
                    }
                    else
                        commandList.Add(new CommandData(1, dirCode, btnCode));
                }
            }
        }

        public void SaveCommandListData(string filepath)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filepath, FileMode.Create)))
            {
                writer.Write(1);
                writer.Write(8);
                writer.Write(GetTotalFrames());
                
                foreach (CommandData cmd in commandList)
                {
                    writer.Write(cmd.GetAsByteArray());
                }

                for (int x = 0; x < 7; ++x)
                {
                    writer.Write(0);
                }
            }
        }
    }
}
