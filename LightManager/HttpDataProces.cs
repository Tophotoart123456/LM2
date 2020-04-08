using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace LightManager
{
    public class HttpDataProces
    {
        #region 全局共享字段和方法
        //全局灯群信息集合
        public static List<lampAssembleInfo> global_LampAssemble = new List<lampAssembleInfo>();
        //跑道集合
        public static List<runwayConfig> global_Runway = new List<runwayConfig>();

        //3D 对象
        public static ControlFor3D controlFor3D = null;
        //获取后台接口地址
        public static string GetUrl(string param)
        {
            string reslut = "";

            reslut=System.Configuration.ConfigurationSettings.AppSettings["JavaSeviceAddress"];
            reslut+= System.Configuration.ConfigurationSettings.AppSettings[param];

            return reslut;
        }
        //序列化3D数据
        public static string Serialize3DInfo(List<_3DLightsInfo> param)
        {
            string reslult= JsonConvert.SerializeObject(param);     
            return reslult;
        }
        //加载组前缀
        public static string _3DToString(string param)
        {
            
            if (null == param || 0 == param.Length)
                return null;
            string reslult = @"{""LightsInfo"":"+param+"}";

            return reslult;
        }
        //3D数据赋值
        public static List<_3DLightsInfo> Set3DInfo(int lightlevel,List<lampInfo> info)
        {
            if (null == info || 0 == info.Count)
                return null;
            List<_3DLightsInfo> buffer = new List<_3DLightsInfo>();

            foreach (var p in info)
            {
                _3DLightsInfo t = new _3DLightsInfo();
                t.AirportId = p.airportId.Value;
                t.Brightness = GetLightBrightness(lightlevel, p).ToString();
                t.Colour = p.nameColor;
                if(p.flashDuration.HasValue)
                t.Direction = p.flashDuration.Value;
                t.FlashingFrequency = "";
                t.IsFlicker = 0;
                t.Pos.x = p.pointX.Value;
                t.Pos.y = p.pointY.Value;
                t.Pos.z = p.pointZ.Value;
                buffer.Add(t);
            }

            return buffer;
        }
        public static int GetLightBrightness(int level,lampInfo lamp)
        {
            int Brightness = 0;

            switch(level)
            {
                case 1:
                    if(lamp.firstLevel.HasValue)
                    Brightness = lamp.firstLevel.Value;
                    break;
                case 2:
                    if (lamp.secondLevel.HasValue)
                        Brightness = lamp.secondLevel.Value;
                    break;
                case 3:
                    if (lamp.thirdLevel.HasValue)
                        Brightness = lamp.thirdLevel.Value;
                    break;
                case 4:
                    if (lamp.fourthLevel.HasValue)
                        Brightness = lamp.fourthLevel.Value;
                    break;
                case 5:
                    if (lamp.fifthLevel.HasValue)
                        Brightness = lamp.fifthLevel.Value;
                    break;
                default:break;
            }

            return Brightness;
        }
        #endregion
        //处理http返回数据
        public string HttpDataAnalysis(string param)
        {
            string reslut = "";

            if (null == param || 0 == param.Length)
                return reslut;
            JObject o = JsonConvert.DeserializeObject<JObject>(param);
            if(null != o && "1000" == o["returnCode"].ToString())//读取成功
            {
                reslut = o["dataInfo"].ToString();
            }
            else
            {
                reslut = o["message"].ToString();
            }
            return reslut;
        }
        //给全局变量灯群赋值
        public void SetLampAssembleValue(string param)
        {
            if (null == param)
                return;
            global_LampAssemble = JsonConvert.DeserializeObject<List<lampAssembleInfo>>(param);
        }
        //给全局变量跑道赋值
        public void SetRunwayValue(string param)
        {
            if (null == param)
                return;
            global_Runway = JsonConvert.DeserializeObject<List<runwayConfig>>(param);
        }
      
    }
}
