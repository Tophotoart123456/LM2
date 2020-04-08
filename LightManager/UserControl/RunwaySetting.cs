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
    public partial class RunwaySetting : UserControl
    {
        //起
        public bool Takeoff { get; set; }
        //落
        public bool Land { get; set; }

        public RunwaySetting()
        {
            InitializeComponent();
        }
        public void SetRunwayName(string name)
        {
            label1.Text = name;
        }
        private void CheckBoxClick(object sender,EventArgs e)
        {
            if(sender is CheckBox)
            {
                var v = sender as CheckBox;
                int Tag = Convert.ToInt32( v.Tag);
                if(1==Tag)//起
                {
                    Takeoff = v.Checked;
                }
                else if(2== Tag)//落
                {
                    Land = v.Checked;
                }

                if (!panel1.BackColor.Equals(Color.FromArgb(70, 110, 255)/*Color.Lime*/))
                    //panel1.BackColor = Color.FromArgb(70, 110, 255);//Color.Lime;
                    SetPanelBk(Color.FromArgb(70, 110, 255));
                else
                {
                    if (!(Takeoff || Land))
                        //panel1.BackColor = Color.Transparent;
                        SetPanelBk(Color.FromArgb(83, 83, 83));
                }
            }
           
        }

        //设置bk
        private void SetPanelBk(Color cr)
        {
            panel1.BackColor = cr;
            label1.BackColor = cr;
            checkBox1.BackColor = cr;
            checkBox2.BackColor = cr;
        }
    }
}
