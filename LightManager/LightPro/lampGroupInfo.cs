using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightManager
{
    public class lampGroupInfo
    {
        public int lampGroupId { get; set; }
        public string lampGroupName { get; set; }
        public int? airportId { get; set; }
        public int? runwayId { get; set; }
        public int? flashGroupFlag { get; set; }//闪光组标识(0:普通灯光 1:顺序闪烁灯光)
        public double? startPointX { get; set; }
        public double? startPointY { get; set; }
        public double? startPointZ { get; set; }
        public int? lampNumber { get; set; }//灯数量
        public double? extensionDirection { get; set; }//延伸方向
        public double? lightSpace { get; set; }//灯光间距
        public string lightColor { get; set; }//灯光颜色
        public double? lightOrientation { get; set; }//灯光朝向
        public int? flashDuration { get; set; }//闪烁时长(单位秒)
        public int? firstLevel { get; set; }
        public int? secondLevel { get; set; }
        public int? thirdLevel { get; set; }
        public int? fourthLevel { get; set; }
        public int? fifthLevel { get; set; }

        //灯
        public List<lampInfo> lampInfo { get; set; }
    }
}
