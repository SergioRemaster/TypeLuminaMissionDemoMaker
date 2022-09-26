using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLuminaMissionDemoMaker.MissionData.Enums;

namespace TypeLuminaMissionDemoMaker.MissionData
{
    public class CommandData
    {
        private int frames = 1;
        private EDirectionCode directionCode;
        private EButtonCode buttonCode;

        public CommandData()
        {
        }

        public CommandData(int frames, EDirectionCode directionCode, EButtonCode buttonCode)
        {
            this.frames = frames;
            this.directionCode = directionCode;
            this.buttonCode = buttonCode;
        }

        public int Frames { get => frames; set => frames = value; }
        public EDirectionCode DirectionCode { get => directionCode; set => directionCode = value; }
        public EButtonCode ButtonCode { get => buttonCode; set => buttonCode = value; }

        public byte[] GetAsByteArray()
        {
            List<byte> byteList = new List<byte>();
            for (int x = 0; x < frames; ++x)
            {
                byteList.Add(Convert.ToByte((int)buttonCode));
                byteList.Add(Convert.ToByte((int)directionCode));
            }
            return byteList.ToArray();
        }
    }
}
