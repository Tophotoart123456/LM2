using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightManager
{
    public class runwayConfig
    {
       

        [JsonProperty("runwayId")]
        public int? RunwayId { get; set; }

        [JsonProperty("runwayName")]
        //[Detail(DisPlayName = "名称", VerifyName = "IsRepeatName", Group = "Base")]
        public string RunwayName { get; set; }

        [JsonProperty("airportId")]
        public int? AirportId { get; set; }

        [JsonProperty("roadId")]
        //[Detail(DisPlayName = "被引用的滑行道", Group = "Base", Enable = true, Visible = true, ControlType = (int)ControlType.ComboBox, ComboboxSourceApi = "PlotMap;PlotMap.Provider.Providers.RoadInfo;ConvertListItem", ComboboxConetctFiled = "RoadName")]
        public int? RoadId { get; set; }

        [JsonProperty("roadName")]
        public string RoadName { get; set; }


        [Description("基准点ID")]
        [JsonProperty("basepointId")]
        //[Detail(DisPlayName = "基准点", Group = "Base", ControlType = (int)ControlType.ComboBox, ComboboxSourceApi = "PlotMap;PlotMap.Provider.Providers.PointInfo;ConvertListItem", ComboboxConetctFiled = "BasepointName")]
        public int? BasepointId { get; set; }



        [JsonProperty("basePointName")]
        public string BasePointName { get; set; }

        [Description("跑道入口点")]
        [JsonProperty("enterId")]
        //[Detail(DisPlayName = "跑道入口点", Required = true, Group = "Base", ControlType = (int)ControlType.ComboBox, ComboboxSourceApi = "PlotMap;PlotMap.Provider.Providers.PointInfo;ConvertListItem", ComboboxConetctFiled = "EnterName")]
        public int? EnterId { get; set; }

        [JsonProperty("enterName")]
        public string EnterName { get; set; }

        [Description("跑道终点")]
        [JsonProperty("runwayEndPointId")]
        //[Detail(DisPlayName = "跑道终点", Required = true, Group = "Base", ControlType = (int)ControlType.ComboBox, ComboboxSourceApi = "PlotMap;PlotMap.Provider.Providers.PointInfo;ConvertListItem", ComboboxConetctFiled = "RunwayEndPointName")]
        public int? RunwayEndPointId { get; set; }

        [JsonProperty("runwayEndPointName")]
        public string RunwayEndPointName { get; set; }


        [JsonProperty("gpPoint")]
        //[Detail(DisPlayName = "GP0", Group = "Base", ControlType = (int)ControlType.TextBox, Enable = false)]
        public string GpPoint { get; set; }

        [Description("朝向(d)度数")]
        [JsonProperty("orientation")]
        //[Detail(DisPlayName = "朝向(d)度数", Group = "Base", ControlType = (int)ControlType.NumberBox, Required = true)]
        public double? Orientation { get; set; }

        [Description("干跑道摩擦系数")]
        [JsonProperty("dryFrictionCoefficient")]
        //[Detail(DisPlayName = "干跑道摩擦系数", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? DryFrictionCoefficient { get; set; }

        [Description("湿跑道摩擦系数")]
        [JsonProperty("wetFrictionCoefficient")]
        //[Detail(DisPlayName = "湿跑道摩擦系数", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? WetFrictionCoefficient { get; set; }

        [Description("积雪跑道摩擦系数")]
        [JsonProperty("snowFrictionCoefficient")]
        //[Detail(DisPlayName = "积雪跑道摩擦系数", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? SnowFrictionCoefficient { get; set; }

        [Description("坡度(d)")]
        [JsonProperty("slope")]
        //[Detail(DisPlayName = "坡度(d)", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? Slope { get; set; }

        [Description("磁偏角(d)")]
        [JsonProperty("declination")]
        //[Detail(DisPlayName = "磁偏角(d)", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? Declination { get; set; }

        [Description("跑道接地点(距离跑道入口的距离)M")]
        [JsonProperty("distanceEntrance")]
        //[Detail(DisPlayName = "跑道接地点位置", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? DistanceEntrance { get; set; }

        [Description("主用脱离方向L/R")]
        [JsonProperty("mainExitDirection")]
        //[Detail(DisPlayName = "主用脱离方向", Group = "Base", ControlType = (int)ControlType.ComboBox)]
        public int? MainExitDirection { get; set; }

        [Description("跑道入口(内移多少米)")]
        [JsonProperty("runwayEntrance")]
        //[Detail(DisPlayName = "跑道入口内移", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? RunwayEntrance { get; set; }

        [Description("停止道长度M")]
        [JsonProperty("stopWayLength")]
        //[Detail(DisPlayName = "停止道长度M", Group = "Base", ControlType = (int)ControlType.NumberBox)]
        public double? StopWayLength { get; set; }

        [Description("ILS-GP下滑道下滑角度")]
        [JsonProperty("ilsGlideAngle")]
        //[Detail(DisPlayName = "ILS-GP下滑道下滑角度", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IlsGlideAngle { get; set; }


        [Description("ILS-GP下滑道有效距离")]
        [JsonProperty("ilsGpEffectiveRange")]
        //[Detail(DisPlayName = "ILS-GP下滑道有效距离", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IlsGpEffectiveRange { get; set; }


        [Description("ILS-GP水平误差范围")]
        [JsonProperty("ilsGpHorizontalDifference")]
        //[Detail(DisPlayName = "ILS-GP水平误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IlsGpHorizontalDifference { get; set; }

        [Description("ILS-GP垂直误差范围")]
        [JsonProperty("ilsGpVerticalDifference")]
        //[Detail(DisPlayName = "ILS-GP垂直误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IlsGpVerticalDifference { get; set; }


        [Description("ILS-LOC航向导有效距离")]
        [JsonProperty("ilsLocEffectiveRange")]
        //[Detail(DisPlayName = "ILS-LOC航向导有效距离", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? IlsLocEffectiveRange { get; set; }

        [Description("ILS-LOC水平误差范围")]
        [JsonProperty("ilsLocHorizontalDifference")]
        //[Detail(DisPlayName = "ILS-LOC水平误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? IlsLocHorizontalDifference { get; set; }

        [Description("ILS-LOC垂直误差范围")]
        [JsonProperty("ilsLocVerticalDifference")]
        //[Detail(DisPlayName = "ILS-LOC垂直误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? IlsLocVerticalDifference { get; set; }

        [Description("ILS-IGS-GP下滑道下滑角度")]
        [JsonProperty("igsGlideAngle")]
        //[Detail(DisPlayName = "ILS-IGS-GP下滑道下滑角度", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IgsGlideAngle { get; set; }

        [Description("IGS-GP下滑道有效距离")]
        [JsonProperty("igsGpEffectiveRange")]
        //[Detail(DisPlayName = "IGS-GP下滑道有效距离", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? IgsGpEffectiveRange { get; set; }

        [Description("IGS-GP水平误差范围")]
        //[Detail(DisPlayName = "IGS-GP水平误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        [JsonProperty("igsGpHorizontalDifference")]
        public double? IgsGpHorizontalDifference { get; set; }

        [Description("IGS-GP垂直误差范围")]
        //[Detail(DisPlayName = "IGS-GP垂直误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        [JsonProperty("igsGpVerticalDifference")]
        public double? IgsGpVerticalDifference { get; set; }

        [Description("IGS-LOC航向导有效距离")]
        [JsonProperty("igsLocEffectiveRange")]
        //[Detail(DisPlayName = "IGS-LOC航向导有效距离", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? IgsLocEffectiveRange { get; set; }

        [Description("IGS-LOC水平误差范围")]
        [JsonProperty("igsLocHorizontalDifference")]
        //[Detail(DisPlayName = "IGS-LOC水平误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? IgsLocHorizontalDifference { get; set; }

        [Description("IGS-LOC垂直误差范围")]
        //[Detail(DisPlayName = "IGS-LOC垂直误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        [JsonProperty("igsLocVerticalDifference")]
        public double? IgsLocVerticalDifference { get; set; }

        [Description("GBAS-GP下滑道下滑角度")]
        [JsonProperty("gbasGlideAngle")]
        //[Detail(DisPlayName = "GBAS-GP下滑道下滑角度", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? GbasGlideAngle { get; set; }

        [Description("GBAS-GP下滑道有效距离")]
        [JsonProperty("gbasGpEffectiveRange")]
        //[Detail(DisPlayName = "GBAS-GP下滑道有效距离", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? GbasGpEffectiveRange { get; set; }

        [Description("GBAS-GP水平误差范围")]
        [JsonProperty("gbasGpHorizontalDifference")]
        //[Detail(DisPlayName = "GBAS-GP水平误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? GbasGpHorizontalDifference { get; set; }

        [Description("GBAS-GP垂直误差范围")]
        [JsonProperty("gbasGpVerticalDifference")]
        //[Detail(DisPlayName = "GBAS-GP垂直误差范围", Group = "GP", ControlType = (int)ControlType.NumberBox)]
        public double? GbasGpVerticalDifference { get; set; }

        [Description("GBAS-LOC航向导有效距离")]
        [JsonProperty("gbasLocEffectiveRange")]
        //[Detail(DisPlayName = "GBAS-LOC航向导有效距离", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? GbasLocEffectiveRange { get; set; }

        [Description("GBAS-LOC水平误差范围")]
        [JsonProperty("gbasLocHorizontalDifference")]
        //[Detail(DisPlayName = "GBAS-LOC水平误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? GbasLocHorizontalDifference { get; set; }

        [Description("GBAS-LOC垂直误差范围")]
        [JsonProperty("gbasLocVerticalDifference")]
        //[Detail(DisPlayName = "GBAS-LOC垂直误差范围", Group = "LOC", ControlType = (int)ControlType.NumberBox)]
        public double? GbasLocVerticalDifference { get; set; }


    }
}
