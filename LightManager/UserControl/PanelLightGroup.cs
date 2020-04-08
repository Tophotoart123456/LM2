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
    public partial class PanelLightGroup : UserControl
    {
        public PanelLightGroup()
        {
            InitializeComponent();
        }

        //添加灯光组
        public void AddLightGroup(string show,string lampAssemble, bool isAllLightGroup=false, DockStyle ds = DockStyle.None)
        {
            LightGroup lg = new LightGroup();
            lg.Dock = ds;
            lg.SetText(show);
            lg.Tag = show;
            lg.LampAssembleInfo = lampAssemble;//灯光群名字
            if (isAllLightGroup)
            {
                lg.NC += Lg_NC;
                panel2.Controls.Add(lg);
            }
            else
                flowLayoutPanel1.Controls.Add(lg);          
        }

        //设置选中/未选中灯组
        public void SetLightGroup(bool select, int level, Color cr)
        {
            List<_3DLightsInfo> _3d = new List<_3DLightsInfo>();
            foreach (var v in flowLayoutPanel1.Controls)
            {
                var temp = v as LightGroup;
                temp.isSelect = select;
                temp.lihgtLevel = level;
                temp.SetLevel(level);
                temp.SetSelectBk(cr);

                temp.OpreateLampFor2D();

                //3D数据
                List<_3DLightsInfo> tp = temp.Get3DData1();
                if (null == tp || 0 == tp.Count)
                    continue;
                    _3d.AddRange(tp);
            }
            if (null == _3d || 0 == _3d.Count)
                return;
            string sr = HttpDataProces.Serialize3DInfo(_3d);
            sr = HttpDataProces._3DToString(sr);
            HttpDataProces.controlFor3D.SendInfoTo3D(sr);
        }
        private void Lg_NC(bool allselect)
        {
            LightGroup parent = (LightGroup)panel2.Controls[0];
            if (parent.isSelect)
                SetLightGroup(parent.isSelect, parent.lihgtLevel, Color.FromArgb(70, 110, 255)/*Color.Lime*/);             
            else
                SetLightGroup(parent.isSelect, parent.lihgtLevel,Color.FromArgb(69,69,69) /*Color.Transparent*/);
        }

    }
}
