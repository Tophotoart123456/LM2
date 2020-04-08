using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightManager
{
    public class lampInfo
    {
        public int? lampId { get; set; }
        public string lampName { get; set; }
        public int? airportId { get; set; }
        public int? lampTypeId { get; set; }//灯类型 
        public int? flashFlag { get; set; } //闪光灯类型 0 普通灯光 1顺序闪烁灯光
        public int? visionType { get; set; }//视景类型
        public string iconUrl { get; set; }
        public double? pointX { get; set; }
        public double? pointY { get; set; }
        public double? pointZ { get; set; }
        public int? autoBootFlag { get; set; }//自动引导 0否 1是
        public string nameColor { get; set; } //名称颜色
        public string iconColor { get; set; }
        public int? flashDuration{ get; set; }//闪烁时长 秒
        public int? firstLevel { get; set; }
        public int? secondLevel { get; set; }
        public int? thirdLevel { get; set; }
        public int? fourthLevel { get; set; }
        public int? fifthLevel { get; set; }
        public int? seq_no { get; set; }//闪烁顺序
        //update on 20200402 所属灯组
        public int? orderGroupId { get; set; }
    }
}
