namespace LightManager
{
    partial class LightManager
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            MapCore.BasePoint basePoint2 = new MapCore.BasePoint();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Map = new VpHonor.MyControl.MyControl.Map.UCMap();
            this.panel_LightGroup = new System.Windows.Forms.Panel();
            this.panel_Item = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Group = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel_Control = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.panel_Title = new System.Windows.Forms.Panel();
            this.label_Min = new System.Windows.Forms.Label();
            this.label_Zoom = new System.Windows.Forms.Label();
            this.label_Close = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            this.panel_LightGroup.SuspendLayout();
            this.flowLayoutPanel_Group.SuspendLayout();
            this.panel_Control.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83)))));
            this.panel_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Main.Controls.Add(this.panel_Map);
            this.panel_Main.Controls.Add(this.panel_LightGroup);
            this.panel_Main.Controls.Add(this.panel_Control);
            this.panel_Main.Controls.Add(this.panel_Title);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(929, 598);
            this.panel_Main.TabIndex = 0;
            // 
            // panel_Map
            // 
            this.panel_Map.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_Map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Map.CenterPoint = basePoint2;
            this.panel_Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Map.IsCompass = false;
            this.panel_Map.IsRightMouseMenu = true;
            this.panel_Map.Location = new System.Drawing.Point(0, 101);
            this.panel_Map.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Map.Name = "panel_Map";
            this.panel_Map.Scale = 1.1920928955078125E-07D;
            this.panel_Map.Size = new System.Drawing.Size(927, 352);
            this.panel_Map.TabIndex = 4;
            // 
            // panel_LightGroup
            // 
            this.panel_LightGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.panel_LightGroup.Controls.Add(this.panel_Item);
            this.panel_LightGroup.Controls.Add(this.flowLayoutPanel_Group);
            this.panel_LightGroup.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_LightGroup.Location = new System.Drawing.Point(0, 453);
            this.panel_LightGroup.Name = "panel_LightGroup";
            this.panel_LightGroup.Size = new System.Drawing.Size(927, 143);
            this.panel_LightGroup.TabIndex = 3;
            // 
            // panel_Item
            // 
            this.panel_Item.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.panel_Item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Item.Location = new System.Drawing.Point(0, 36);
            this.panel_Item.Name = "panel_Item";
            this.panel_Item.Size = new System.Drawing.Size(927, 107);
            this.panel_Item.TabIndex = 1;
            // 
            // flowLayoutPanel_Group
            // 
            this.flowLayoutPanel_Group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(176)))), ((int)(((byte)(190)))));
            this.flowLayoutPanel_Group.Controls.Add(this.button1);
            this.flowLayoutPanel_Group.Controls.Add(this.button2);
            this.flowLayoutPanel_Group.Controls.Add(this.button3);
            this.flowLayoutPanel_Group.Controls.Add(this.button4);
            this.flowLayoutPanel_Group.Controls.Add(this.button5);
            this.flowLayoutPanel_Group.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel_Group.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.flowLayoutPanel_Group.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel_Group.Name = "flowLayoutPanel_Group";
            this.flowLayoutPanel_Group.Size = new System.Drawing.Size(927, 36);
            this.flowLayoutPanel_Group.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "15机场灯光群";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(118, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "33机场灯光群";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(236, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "16机场灯光群";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(354, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 32);
            this.button4.TabIndex = 3;
            this.button4.Text = "34机场灯光群";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button5.Location = new System.Drawing.Point(472, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 32);
            this.button5.TabIndex = 4;
            this.button5.Text = "其他灯光群1";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // panel_Control
            // 
            this.panel_Control.Controls.Add(this.tableLayoutPanel1);
            this.panel_Control.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Control.Location = new System.Drawing.Point(0, 20);
            this.panel_Control.Name = "panel_Control";
            this.panel_Control.Size = new System.Drawing.Size(927, 81);
            this.panel_Control.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 81);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(73, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 81);
            this.panel1.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(223, 44);
            this.button12.Margin = new System.Windows.Forms.Padding(0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 32);
            this.button12.TabIndex = 6;
            this.button12.Tag = "7";
            this.button12.Text = ">=5000米";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(149, 44);
            this.button11.Margin = new System.Windows.Forms.Padding(0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 32);
            this.button11.TabIndex = 5;
            this.button11.Tag = "6";
            this.button11.Text = "<5000米";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(75, 44);
            this.button10.Margin = new System.Windows.Forms.Padding(0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 32);
            this.button10.TabIndex = 4;
            this.button10.Tag = "5";
            this.button10.Text = "<1600米";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(1, 44);
            this.button9.Margin = new System.Windows.Forms.Padding(0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 32);
            this.button9.TabIndex = 3;
            this.button9.Tag = "4";
            this.button9.Text = "<=800米";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(206, 6);
            this.button8.Margin = new System.Windows.Forms.Padding(0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(91, 32);
            this.button8.TabIndex = 2;
            this.button8.Tag = "3";
            this.button8.Text = "夜晚";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(103, 6);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(91, 32);
            this.button7.TabIndex = 1;
            this.button7.Tag = "2";
            this.button7.Text = "凌晨/黄昏";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(194)))), ((int)(((byte)(195)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(147)))));
            this.button6.Location = new System.Drawing.Point(1, 6);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 32);
            this.button6.TabIndex = 0;
            this.button6.Tag = "1";
            this.button6.Text = "白天";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.ButtonClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.button15);
            this.panel2.Controls.Add(this.button14);
            this.panel2.Controls.Add(this.button13);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(373, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 81);
            this.panel2.TabIndex = 1;
            // 
            // button15
            // 
            this.button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(127, 7);
            this.button15.Margin = new System.Windows.Forms.Padding(0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(40, 69);
            this.button15.TabIndex = 2;
            this.button15.Tag = "10";
            this.button15.Text = "CATII";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button14
            // 
            this.button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button14.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(70, 7);
            this.button14.Margin = new System.Windows.Forms.Padding(0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(40, 69);
            this.button14.TabIndex = 1;
            this.button14.Tag = "9";
            this.button14.Text = "CAT I";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ButtonClick);
            // 
            // button13
            // 
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(13, 7);
            this.button13.Margin = new System.Windows.Forms.Padding(0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(40, 69);
            this.button13.TabIndex = 0;
            this.button13.Tag = "8";
            this.button13.Text = "NOCAT";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.ButtonClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(555, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(298, 81);
            this.panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(248, 81);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(211)))), ((int)(((byte)(219)))));
            this.panel4.Controls.Add(this.button16);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(248, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 81);
            this.panel4.TabIndex = 0;
            // 
            // button16
            // 
            this.button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(6, 5);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(40, 69);
            this.button16.TabIndex = 3;
            this.button16.Tag = "11";
            this.button16.Text = "试灯";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.ButtonClick);
            // 
            // panel_Title
            // 
            this.panel_Title.BackColor = System.Drawing.Color.Black;
            this.panel_Title.Controls.Add(this.label_Min);
            this.panel_Title.Controls.Add(this.label_Zoom);
            this.panel_Title.Controls.Add(this.label_Close);
            this.panel_Title.Controls.Add(this.label2);
            this.panel_Title.Controls.Add(this.label1);
            this.panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Title.Location = new System.Drawing.Point(0, 0);
            this.panel_Title.Name = "panel_Title";
            this.panel_Title.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel_Title.Size = new System.Drawing.Size(927, 20);
            this.panel_Title.TabIndex = 0;
            this.panel_Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Title_MouseDown);
            // 
            // label_Min
            // 
            this.label_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Min.Image = global::LightManager.Properties.Resources.icon_minuscreen_1x;
            this.label_Min.Location = new System.Drawing.Point(804, 0);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(41, 17);
            this.label_Min.TabIndex = 4;
            this.label_Min.Click += new System.EventHandler(this.TitleLabelClick);
            // 
            // label_Zoom
            // 
            this.label_Zoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Zoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Zoom.Image = global::LightManager.Properties.Resources.icon_fullscreen_1x_;
            this.label_Zoom.Location = new System.Drawing.Point(845, 0);
            this.label_Zoom.Name = "label_Zoom";
            this.label_Zoom.Size = new System.Drawing.Size(41, 17);
            this.label_Zoom.TabIndex = 3;
            this.label_Zoom.Click += new System.EventHandler(this.TitleLabelClick);
            // 
            // label_Close
            // 
            this.label_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_Close.Image = global::LightManager.Properties.Resources.icon_closewindow_1x;
            this.label_Close.Location = new System.Drawing.Point(886, 0);
            this.label_Close.Name = "label_Close";
            this.label_Close.Size = new System.Drawing.Size(41, 17);
            this.label_Close.TabIndex = 2;
            this.label_Close.Click += new System.EventHandler(this.TitleLabelClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(43, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ATTW-LIGHT 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(110)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIGHT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LightManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 598);
            this.Controls.Add(this.panel_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LightManager";
            this.Text = "灯光控制";
            this.panel_Main.ResumeLayout(false);
            this.panel_LightGroup.ResumeLayout(false);
            this.flowLayoutPanel_Group.ResumeLayout(false);
            this.panel_Control.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel_Title.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        private System.Windows.Forms.Panel panel_Control;
        private System.Windows.Forms.Panel panel_Title;
        private VpHonor.MyControl.MyControl.Map.UCMap panel_Map;
        private System.Windows.Forms.Panel panel_LightGroup;
        private System.Windows.Forms.Panel panel_Item;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Zoom;
        private System.Windows.Forms.Label label_Close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

