using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//地图集合
using VpHonor.Common.InterfaceDal;
using VpHonor.Common.Model;
using VpHonor.MyControl.Common.Helper;
using VpHonor.PlotMap.MapModel;
using VpHonor.PlotMap.MapModel.AirPort;
using VpHonor.PlotMap.MapModel.AirSpace;
using VVpHonor.Common.Common.Helper;


namespace LightManager
{
   public class ControlForMap
    {
        public BaseMapData _baseMapData;//机场数据
        public bool isCompleteAir;//是否加载完地图数据

        VpHonor.MyControl.MyControl.Map.UCMap mapbox = null;

        public ControlForMap(VpHonor.MyControl.MyControl.Map.UCMap param)
        {
            if (null != param)
            {
                mapbox = param;
                mapbox.LockShape(true);
            }
        }
        #region 地图控件
        public void InitMap()
        {
            if (null == mapbox)
                return;
            if (LightManager. _airportId == null || LightManager. _airportId <= 0)
            {
                MessageHelper.Intance.Warning("请填写需要加载的地面地图数据!");
                return;
            }
            BeforeLoadData();
            mapbox.Scale = 0.543212890625E-07D;
            BaseMapData baseMapData = new AirPortData();
            //BaseMapData baseMapData = new AirPortData();
            AbstractBaseDal baseDal = new AbstractBaseDal() { Name = LightManager._airportId.ToString() };
            Task<BaseResultEnt> task = Task<BaseResultEnt>.Run(() => {
                return baseMapData.GetDataList<IBaseDal>(baseDal);
            });
            BaseResultEnt result = task.Result;
            if (result?.ResultFlg ?? false)
            {
                isCompleteAir = true;
                _baseMapData = result.ResultData as BaseMapData;
                _baseMapData.SetAirport(LightManager._airportId);

                //update on 20200402
                if(_baseMapData is AirPortData ad)
                {
                    ad?.LampInfos.ForEach(o => o.bOpen = false);
                    ad?.OrderLampInfos.ForEach(o => o.bOpen = false);
                }
                RefreshMap();
            }
            else
            {
                if (!string.IsNullOrEmpty(result?.ResultMsg))
                {
                    MessageBox.Show(result?.ResultMsg);
                }
            }
        }
        public void BeforeLoadData()
        {
            isCompleteAir = false;
            ClearMap();
        }
        public void ClearMap()
        {
            ThreadHelper.ThreadInvokerControl(mapbox, () => {
                mapbox.ClearMap();
            });
        }
        //刷新地图
        public void RefreshMap()
        {
            if (_baseMapData != null)
            {
                ThreadHelper.ThreadBeginInvokerControl(mapbox, () => {
                    if (mapbox.MapDefine == null)
                    {
                        MapCore.MapDefine mapDefine = _baseMapData.GetMapDefine();
                        mapbox.LoadData(mapDefine);
                    }
                    else
                    {
                        _baseMapData.AppendMapDefine(mapbox.MapDefine);
                        // panel2.AppendShape(_baseMapData);
                    }
                    if (_baseMapData.DatumPoint?.Count > 0)
                    {
                        mapbox.SetMapCentre(_baseMapData.DatumPoint[0]);
                    }
                });
            }
        }
        //操作灯光
        public void OperateLamp(List<lampInfo> param, bool isOpen)
        {
            if (null == param || 0 == param.Count)
                return;
            if (_baseMapData != null && _baseMapData is AirPortData airport)
            {
                foreach(var v in param)
                {
                    if(v.flashFlag == 0)//普通灯光
                    {
                        if (airport?.LampInfos?.Count > 0)
                        {
                            var t= airport?.LampInfos?.Find(o => o.LampId.Equals(v.lampId));
                            if(null != t)
                            t.bOpen = isOpen;
                        }
                    }
                    if(param.FirstOrDefault().orderGroupId != null) //闪烁灯光
                    {
                        if (airport?.OrderLampInfos?.Count > 0)
                        {
                            var t= airport?.OrderLampInfos?.Find(o=>(o.LampGroupId.Equals(param.FirstOrDefault().orderGroupId)));
                            if (t != null)
                                t.bOpen = isOpen;
                                
                        }
                    }
                }
            }
        }
        #endregion
    }
}
