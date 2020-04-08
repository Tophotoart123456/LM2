using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightManager
{
    public partial class LightGroup:UserControl
    {
        //灯光等级
        public int lihgtLevel = 0;
        //是否选中
        public bool isSelect = false;
        //所属灯光群
        public string LampAssembleInfo { get; set; }
        //全部选中时通知外部事件
        public delegate void NoticeClick(bool allselect);
        public event NoticeClick NC;
        //
        public LightGroup()
        {
            InitializeComponent();
        }
        //道路名字
        public void SetText(string show)
        {
            label4.Text = show;
        }
        private void label3_MouseEnter(object sender, EventArgs e)
        {
            var v = sender as Label;
            v.BackColor = Color.FromArgb(70, 110, 255);//Color.CadetBlue;
        }
        //灯光等级
        public void SetLevel(int lv)
        {
            label2.Text = lv.ToString();
        }
        //选中颜色
        public void SetSelectBk(Color cr)
        {
            label4.BackColor = cr;
        }
        private void label3_MouseLeave(object sender, EventArgs e)
        {
            var v = sender as Label;
            v.BackColor = Color.FromArgb(69,69,69);//Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string sr3d = "";
            var v = sender as Label;
            int Tag = Convert.ToInt32(v.Tag);
            
            switch (Tag)
            {
                case 1://减
                    if (isSelect)
                    {
                        if (lihgtLevel > 0)
                        {
                            lihgtLevel--;
                            SetLevel(lihgtLevel);
                            if (label4.Text.Equals("全部灯组"))
                                NC.Invoke(isSelect);
                            else
                            {
                                var _3d = Get3DData();
                                _3d = HttpDataProces._3DToString(_3d);
                                HttpDataProces.controlFor3D.SendInfoTo3D(_3d);
                            }
                            //2维地图关灯
                         
                            OpreateLampFor2D();
                            
                        }
                    }
                    break;
                case 2://加
                    if (isSelect)
                    {
                        if (lihgtLevel < 5)
                        {
                            lihgtLevel++;
                            SetLevel(lihgtLevel);
                            if (label4.Text.Equals("全部灯组"))
                                NC.Invoke(isSelect);
                            else
                            {
                                var _3d = Get3DData();
                                _3d = HttpDataProces._3DToString(_3d);
                                HttpDataProces.controlFor3D.SendInfoTo3D(_3d);
                            }
                            //2维地图开灯
                         
                            OpreateLampFor2D();
                           
                        }
                    }
                    break;
                case 3://选中
                    if(!v.BackColor.Equals(Color.FromArgb(70, 110, 255)/*Color.Lime*/))
                    {
                        isSelect = true;
                        v.BackColor = Color.FromArgb(70, 110, 255);//Color.Lime;
                        if(label4.Text.Equals("全部灯组"))
                        NC.Invoke(isSelect);
                    }
                    else
                    {
                        isSelect = false;
                        v.BackColor = Color.FromArgb(69, 69, 69);//Color.Transparent;
                        if (label4.Text.Equals("全部灯组"))
                            NC.Invoke(isSelect);
                    }
                    break;
                default: break;
            }
        }

        //获取当前灯光组下数据
        public string Get3DData()
        {
            string reslut = "";

            var temp = HttpDataProces.global_LampAssemble.Find(o => o.lampAssembleName.Equals(LampAssembleInfo));
            if(null != temp)
            {
                var group = temp.lampGroupInfo.Find(o=>o.lampGroupName.Equals(label4.Text));
                if(null != group)
                {
                    List<_3DLightsInfo> LightsInfo = HttpDataProces.Set3DInfo(lihgtLevel, group.lampInfo);
                    if (null == LightsInfo || 0 == LightsInfo.Count)
                        return reslut;
                    reslut = HttpDataProces.Serialize3DInfo(LightsInfo);
                   
                }
            }
            return reslut;
        }
        public List<_3DLightsInfo> Get3DData1()
        {
            List<_3DLightsInfo> LightsInfo = null;
            var temp = HttpDataProces.global_LampAssemble.Find(o => o.lampAssembleName.Equals(LampAssembleInfo));
            if (null != temp)
            {
                var group = temp.lampGroupInfo.Find(o => o.lampGroupName.Equals(label4.Text));
                if (null != group)
                {
                    LightsInfo = HttpDataProces.Set3DInfo(lihgtLevel, group.lampInfo);
                }
            }
            return LightsInfo;
        }
        public List<lampInfo> GetData()
        {
            List<lampInfo> LightsInfo = null;
            var temp = HttpDataProces.global_LampAssemble.Find(o => o.lampAssembleName.Equals(LampAssembleInfo));
            if (null != temp)
            {
                var group = temp.lampGroupInfo.Find(o => o.lampGroupName.Equals(label4.Text));
                if (null != group)
                {
                    LightsInfo = group.lampInfo;
                    //如果是闪烁灯组则赋值groupId
                    if(group.flashGroupFlag == 1)
                    LightsInfo?.ForEach(o => o.orderGroupId = group.lampGroupId);
                    //
                }
            }
            return LightsInfo;
        }
        public void OpreateLampFor2D()
        {
            var tt = GetData();
            if(lihgtLevel == 0)
            LightManager.mapC.OperateLamp(tt, false);
            else if(lihgtLevel==1)
                LightManager.mapC.OperateLamp(tt, true);
        }

    }
}
