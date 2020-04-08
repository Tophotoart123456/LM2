using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Helper;


namespace LightManager
{
    public partial class LightManager : Form
    {
        private TimeJudge timeJudge = null;
        private HttpDataProces httpDataProces = null;

        
        //地图控件
        public static int _airportId = 18;//18武汉机场
        public static ControlForMap mapC = null;
        //
        //log 对象
        public static LogBase log = null;
        public LightManager()
        {
            InitializeComponent();
            InitUi();
            InitObj();
            GetRunwayDataFromHttp();
            GetLampDataFromHttp();

            //加载地图
            mapC.InitMap();
            //test
            //string test = Color.Red.ToArgb().ToString("X");

        }
        private void InitUi()
        {
            CenterToScreen();
        }
        private void InitObj()
        {
            mapC = new ControlForMap(panel_Map);
            timeJudge = new TimeJudge();
            httpDataProces = new HttpDataProces();
            log = new LogBase();
            log.CreateFile();
            HttpDataProces.controlFor3D = new ControlFor3D();
            if (!HttpDataProces.controlFor3D.Connact())
                MessageBox.Show("3D视景客户端未打开!");
        }
        
        private void AddRunwayControl(string name)
        {
            RunwaySetting rs = new RunwaySetting();
            rs.SetRunwayName(name);
            rs.Tag = name;
            rs.Margin = new Padding(0, 0, 0, 2);
            flowLayoutPanel1.Controls.Add(rs);
            
        }
        protected override void OnClosed(EventArgs e)
        {
            HttpDataProces.controlFor3D.Close();
            base.OnClosed(e);
        }
        #region 单选按钮控制
        private void ButtonClick(object sender,EventArgs e)
        {
            if(sender is Button)
            {
                var button = sender as Button;
                int Tag = Convert.ToInt32(button.Tag);
                if (Tag >= 1 && Tag <= 3)
                {
                    if (Tag == 1)
                        timeJudge.JudgeTheTime(TimeSlot.DayTime, button.Text);
                    else if(Tag==2)
                        timeJudge.JudgeTheTime(TimeSlot.Dusk, button.Text);
                    else if(Tag==3)
                        timeJudge.JudgeTheTime(TimeSlot.Evening, button.Text);
                    SetItem1Bk(panel1, button, 1, 3);
                }
                else if (Tag >= 4 && Tag <= 7)
                    SetItem1Bk(panel1, button, 4, 7);
                else if (Tag >= 8 && Tag <= 10)
                    SetItem1Bk(panel2, button, 8, 10);
                //试灯
                var tempGG = GetTabPanel();
                if (!button.BackColor.Equals(Color.FromArgb(70, 110, 255)/*Color.Lime*/))
                {
                    //打开试灯
                    if (11 == Tag)
                        //SetLightGroup(true, 5,Color.FromArgb(70, 110, 255)/* Color.Lime*/);
                        if (null != tempGG)
                            tempGG.SetLightGroup(true, 5, Color.FromArgb(70, 110, 255));
                    button.BackColor = Color.FromArgb(70, 110, 255);//Color.Lime;
                }
                else
                {
                    //关闭试灯
                    if (11 == Tag)
                        //SetLightGroup(false, 5, Color.FromArgb(69,69,69)/*Color.Transparent*/);
                        if (null != tempGG)
                            tempGG.SetLightGroup(false, 5, Color.FromArgb(69, 69, 69));
                    button.BackColor = Color.FromArgb(83, 83, 83);//Color.Transparent;
                }
            }
        }
        //白天 夜晚..
        private void SetItem1Bk(Control c,Button current, int start,int end)
        {
            foreach(var v in c.Controls)
            {
                if(v is Button)
                {
                    var temp = v as Button;
                    if (temp.Equals(current))
                        continue;
                    int tag = Convert.ToInt32(temp.Tag);
                    if (tag >= start && tag <= end)
                        temp.BackColor =Color.FromArgb(83, 83, 83) ;//Color.Transparent;
                }
            }
        }
        #endregion

        #region 获取灯光数据
        private void GetLampDataFromHttp()
        {
            string param = @"{ ""airportId"":"+_airportId.ToString()+"}";
            string success = "";
            try
            {
                success = /*TestInfo("C:\\Users\\Administrator\\Desktop\\新建文件夹\\LightManager\\LightManager\\1.txt");*/Helper.HttpRequestHelper.HttpPostRequest(HttpDataProces.GetUrl("LampInfoInterface"), param);
                success = httpDataProces.HttpDataAnalysis(success);
                httpDataProces.SetLampAssembleValue(success);
                SetLampAssemble();
            }
            catch(Exception err)
            {
                MessageBox.Show(success);
            }
        }
        //灯光群
        private void SetLampAssemble()
        {
            if (flowLayoutPanel_Group.Controls.Count > 0)
                flowLayoutPanel_Group.Controls.Clear();
            bool first = false;
            foreach (var v in HttpDataProces.global_LampAssemble)
            {
                Button btn = new Button();
                btn.Margin = new Padding(0, 0, 2, 0);
                btn.Size = new Size(115, 32);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(69, 69, 69);
                btn.Text = v.lampAssembleName;
                btn.Tag = v.lampAssembleName;
                btn.Cursor = Cursors.Hand;
                btn.Click += Btn_Click;
                flowLayoutPanel_Group.Controls.Add(btn);

                //设置选项卡panel
                AddTabPanel(v.lampAssembleId, v.lampAssembleName,v.lampGroupInfo);
                //设置当前选项卡
                if(!first)
                {
                    first = true;
                    SetTabItemBk(btn);
                    Btn_Click(btn, new EventArgs());
                }
            }
        }
        //灯光群按钮点击事件
        private void Btn_Click(object sender, EventArgs e)
        {
            Button Temp =sender as Button;
            SetTabItemBk(Temp);
            foreach(var v in panel_Item.Controls)
            {
                if(v is PanelLightGroup)
                {
                    var p = v as PanelLightGroup;
                    if (null != p && p.Name == Temp.Text)
                    {
                        p.Visible = true;
                    }
                    else
                        p.Visible = false;
                }
            }
        }
        //设置选项卡背景色
        private void SetTabItemBk(Button b)
        {
            foreach(var v in flowLayoutPanel_Group.Controls)
            {
                if(v is Button)
                {
                    Button temp = v as Button;
                    if(temp.Equals(b))
                        temp.BackColor= Color.FromArgb(83, 83, 83);
                    else
                        temp.BackColor= Color.FromArgb(69, 69, 69);
                }
            }
        }
        //设置选显卡内容
        private void AddTabPanel(int tag,string name,List<lampGroupInfo> lgi)
        {
            PanelLightGroup plg = new PanelLightGroup();
            plg.Dock = DockStyle.Fill;
            plg.Tag = tag;
            plg.Name = name;
            foreach (var v in lgi)
                plg.AddLightGroup(v.lampGroupName,name);
            if(lgi.Count>0)
            plg.AddLightGroup("全部灯组",name, true, DockStyle.Right);
            panel_Item.Controls.Add(plg);
        }
        //获取当前选项卡panel
        private PanelLightGroup GetTabPanel()
        {
            PanelLightGroup g = null;
            foreach(var v in panel_Item.Controls)
            {
                if(v is PanelLightGroup)
                {
                    var p = v as PanelLightGroup;
                    if(null != p && p.Visible)
                    {
                        g = p;
                        break;
                    }
                }
            }
            return g;
        }
        //数据测试
        private string TestInfo(string filepath)
        {
            string re = "";

            using(Stream s= File.OpenRead(filepath))
            {
                long size = s.Length;
                byte[] buffer = new byte[size];
                s.Read(buffer, 0, buffer.Length);
                re = Encoding.Default.GetString(buffer);              
            }
            return re;
        }
        #endregion
        #region 获取跑道数据
        private void GetRunwayDataFromHttp()
        {
            string param = @"{ ""airportId"":"+_airportId.ToString()+"}";
            string success = "";
            try
            {
                success = /*TestInfo("C:\\Users\\Administrator\\Desktop\\新建文件夹\\LightManager\\LightManager\\跑道.txt");*/Helper.HttpRequestHelper.HttpPostRequest(HttpDataProces.GetUrl("RunwayInterface"), param);
                success = httpDataProces.HttpDataAnalysis(success);
                httpDataProces.SetRunwayValue(success);
                SetRunwayInfo();
            }
            catch (Exception err)
            {
                MessageBox.Show(success);
            }
        }
        private void SetRunwayInfo()
        {
            foreach(var v in HttpDataProces.global_Runway)
            {
                AddRunwayControl(v.RunwayName);
            }
        }
        #endregion

        #region 标题栏点击事件
        private void TitleLabelClick(object sender, EventArgs e)
        {
            if (label_Close.Equals(sender))
            {
                Close();
                //SendDataTest();
            }
            else
            {
                if (label_Zoom.Equals(sender))
                {
                    if (WindowState.Equals(FormWindowState.Normal))
                        WindowState = FormWindowState.Maximized;
                    else if (WindowState.Equals(FormWindowState.Maximized))
                        WindowState = FormWindowState.Normal;
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
        }
        #endregion

        private void panel_Title_MouseDown(object sender, MouseEventArgs e)
        {
            Class_Base ba = new Class_Base();
            ba.HeaderPanel_MouseDown(this, e);
        }
    }
}
