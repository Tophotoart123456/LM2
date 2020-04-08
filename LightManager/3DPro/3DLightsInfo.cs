using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightManager
{
    public class _3DLightsInfo
    {
        public int LightId { get; set; }
        public int AirportId { get; set; }
        //灯类型
        public int LightType { get; set; }
        public string Brightness { get; set; }
        public string Colour { get; set; }
        public float Direction { get; set; }
        public int IsFlicker { get; set; }
        public string FlashingFrequency { get; set; }
        public _3DPoint Pos { get; set; } = new _3DPoint();
    }
    public class _3DPoint
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
    }

}
