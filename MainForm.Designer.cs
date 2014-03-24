namespace vJoyConfNet
{
    internal sealed partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.makeconfbtn = new System.Windows.Forms.Button();
            this.deviceGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.deleteconfbtn = new System.Windows.Forms.Button();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            this.configbox = new System.Windows.Forms.GroupBox();
            this.Presets = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnum = new System.Windows.Forms.NumericUpDown();
            this.POV = new System.Windows.Forms.GroupBox();
            this.povnum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.povcon = new System.Windows.Forms.RadioButton();
            this.povnone = new System.Windows.Forms.RadioButton();
            this.povdir = new System.Windows.Forms.RadioButton();
            this.Axes = new System.Windows.Forms.GroupBox();
            this.yaxisrot = new System.Windows.Forms.CheckBox();
            this.xaxisrot = new System.Windows.Forms.CheckBox();
            this.vaxis = new System.Windows.Forms.CheckBox();
            this.uaxis = new System.Windows.Forms.CheckBox();
            this.zaxisrot = new System.Windows.Forms.CheckBox();
            this.zaxis = new System.Windows.Forms.CheckBox();
            this.yaxis = new System.Windows.Forms.CheckBox();
            this.xaxis = new System.Windows.Forms.CheckBox();
            this.resetvJoyBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.deviceGroupBox.SuspendLayout();
            this.configbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnnum)).BeginInit();
            this.POV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.povnum)).BeginInit();
            this.Axes.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // makeconfbtn
            // 
            this.makeconfbtn.BackColor = System.Drawing.SystemColors.Control;
            this.makeconfbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.makeconfbtn.Location = new System.Drawing.Point(12, 271);
            this.makeconfbtn.Name = "makeconfbtn";
            this.makeconfbtn.Size = new System.Drawing.Size(173, 34);
            this.makeconfbtn.TabIndex = 0;
            this.makeconfbtn.Text = "Apply Configuration(s)";
            this.makeconfbtn.UseVisualStyleBackColor = false;
            this.makeconfbtn.Click += new System.EventHandler(this.MakeconfbtnClick);
            // 
            // deviceGroupBox
            // 
            this.deviceGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.deviceGroupBox.Controls.Add(this.checkBox16);
            this.deviceGroupBox.Controls.Add(this.checkBox8);
            this.deviceGroupBox.Controls.Add(this.checkBox6);
            this.deviceGroupBox.Controls.Add(this.checkBox15);
            this.deviceGroupBox.Controls.Add(this.checkBox7);
            this.deviceGroupBox.Controls.Add(this.checkBox14);
            this.deviceGroupBox.Controls.Add(this.checkBox13);
            this.deviceGroupBox.Controls.Add(this.checkBox5);
            this.deviceGroupBox.Controls.Add(this.checkBox12);
            this.deviceGroupBox.Controls.Add(this.checkBox4);
            this.deviceGroupBox.Controls.Add(this.checkBox11);
            this.deviceGroupBox.Controls.Add(this.checkBox3);
            this.deviceGroupBox.Controls.Add(this.checkBox10);
            this.deviceGroupBox.Controls.Add(this.checkBox2);
            this.deviceGroupBox.Controls.Add(this.checkBox9);
            this.deviceGroupBox.Controls.Add(this.checkBox1);
            this.deviceGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deviceGroupBox.Location = new System.Drawing.Point(12, 12);
            this.deviceGroupBox.Name = "deviceGroupBox";
            this.deviceGroupBox.Size = new System.Drawing.Size(352, 65);
            this.deviceGroupBox.TabIndex = 3;
            this.deviceGroupBox.TabStop = false;
            this.deviceGroupBox.Text = "Configure These Devices";
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox16.Location = new System.Drawing.Point(308, 42);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(38, 17);
            this.checkBox16.TabIndex = 15;
            this.checkBox16.Text = "16";
            this.checkBox16.UseVisualStyleBackColor = false;
            this.checkBox16.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox8.Location = new System.Drawing.Point(308, 19);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(32, 17);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "8";
            this.checkBox8.UseVisualStyleBackColor = false;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox6.Location = new System.Drawing.Point(220, 19);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(32, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "6";
            this.checkBox6.UseVisualStyleBackColor = false;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox15.Location = new System.Drawing.Point(264, 42);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(38, 17);
            this.checkBox15.TabIndex = 14;
            this.checkBox15.Text = "15";
            this.checkBox15.UseVisualStyleBackColor = false;
            this.checkBox15.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox7.Location = new System.Drawing.Point(264, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(32, 17);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "7";
            this.checkBox7.UseVisualStyleBackColor = false;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox14.Location = new System.Drawing.Point(220, 42);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(38, 17);
            this.checkBox14.TabIndex = 13;
            this.checkBox14.Text = "14";
            this.checkBox14.UseVisualStyleBackColor = false;
            this.checkBox14.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox13.Location = new System.Drawing.Point(176, 42);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(38, 17);
            this.checkBox13.TabIndex = 12;
            this.checkBox13.Text = "13";
            this.checkBox13.UseVisualStyleBackColor = false;
            this.checkBox13.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox5.Location = new System.Drawing.Point(176, 19);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(32, 17);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "5";
            this.checkBox5.UseVisualStyleBackColor = false;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox12.Location = new System.Drawing.Point(132, 42);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(38, 17);
            this.checkBox12.TabIndex = 11;
            this.checkBox12.Text = "12";
            this.checkBox12.UseVisualStyleBackColor = false;
            this.checkBox12.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox4.Location = new System.Drawing.Point(132, 19);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(32, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "4";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox11.Location = new System.Drawing.Point(88, 42);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(38, 17);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "11";
            this.checkBox11.UseVisualStyleBackColor = false;
            this.checkBox11.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox3.Location = new System.Drawing.Point(88, 19);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(32, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "3";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox10.Location = new System.Drawing.Point(44, 42);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(38, 17);
            this.checkBox10.TabIndex = 9;
            this.checkBox10.Text = "10";
            this.checkBox10.UseVisualStyleBackColor = false;
            this.checkBox10.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(44, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(32, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "2";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox9.Location = new System.Drawing.Point(6, 42);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(32, 17);
            this.checkBox9.TabIndex = 8;
            this.checkBox9.Text = "9";
            this.checkBox9.UseVisualStyleBackColor = false;
            this.checkBox9.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(32, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "1";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // deleteconfbtn
            // 
            this.deleteconfbtn.BackColor = System.Drawing.SystemColors.Control;
            this.deleteconfbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deleteconfbtn.Location = new System.Drawing.Point(191, 271);
            this.deleteconfbtn.Name = "deleteconfbtn";
            this.deleteconfbtn.Size = new System.Drawing.Size(173, 34);
            this.deleteconfbtn.TabIndex = 1;
            this.deleteconfbtn.Text = "Remove Configuration(s)";
            this.deleteconfbtn.UseVisualStyleBackColor = false;
            this.deleteconfbtn.Click += new System.EventHandler(this.DeleteconfbtnClick);
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.BackColor = System.Drawing.SystemColors.Control;
            this.CheckAll.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckAll.Location = new System.Drawing.Point(12, 83);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(162, 17);
            this.CheckAll.TabIndex = 17;
            this.CheckAll.Text = "Check/Uncheck All Devices";
            this.CheckAll.UseVisualStyleBackColor = false;
            this.CheckAll.CheckedChanged += new System.EventHandler(this.CheckAllCheckedChanged);
            // 
            // configbox
            // 
            this.configbox.BackColor = System.Drawing.SystemColors.Control;
            this.configbox.Controls.Add(this.Presets);
            this.configbox.Controls.Add(this.label2);
            this.configbox.Controls.Add(this.btnnum);
            this.configbox.Controls.Add(this.POV);
            this.configbox.Controls.Add(this.Axes);
            this.configbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.configbox.Location = new System.Drawing.Point(12, 106);
            this.configbox.Name = "configbox";
            this.configbox.Size = new System.Drawing.Size(352, 159);
            this.configbox.TabIndex = 16;
            this.configbox.TabStop = false;
            this.configbox.Text = "Configuration";
            // 
            // Presets
            // 
            this.Presets.BackColor = System.Drawing.SystemColors.Control;
            this.Presets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Presets.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Presets.FormattingEnabled = true;
            this.Presets.Location = new System.Drawing.Point(163, 128);
            this.Presets.Name = "Presets";
            this.Presets.Size = new System.Drawing.Size(183, 21);
            this.Presets.TabIndex = 6;
            this.Presets.SelectedIndexChanged += new System.EventHandler(this.PresetsSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(163, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buttons:";
            // 
            // btnnum
            // 
            this.btnnum.BackColor = System.Drawing.Color.White;
            this.btnnum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnnum.Location = new System.Drawing.Point(215, 102);
            this.btnnum.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.btnnum.Name = "btnnum";
            this.btnnum.Size = new System.Drawing.Size(40, 20);
            this.btnnum.TabIndex = 4;
            this.btnnum.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // POV
            // 
            this.POV.BackColor = System.Drawing.SystemColors.Control;
            this.POV.Controls.Add(this.povnum);
            this.POV.Controls.Add(this.label1);
            this.POV.Controls.Add(this.povcon);
            this.POV.Controls.Add(this.povnone);
            this.POV.Controls.Add(this.povdir);
            this.POV.ForeColor = System.Drawing.SystemColors.ControlText;
            this.POV.Location = new System.Drawing.Point(163, 19);
            this.POV.Name = "POV";
            this.POV.Size = new System.Drawing.Size(183, 77);
            this.POV.TabIndex = 3;
            this.POV.TabStop = false;
            this.POV.Text = "POV Hat Switch";
            // 
            // povnum
            // 
            this.povnum.BackColor = System.Drawing.Color.White;
            this.povnum.ForeColor = System.Drawing.SystemColors.ControlText;
            this.povnum.Location = new System.Drawing.Point(52, 44);
            this.povnum.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.povnum.Name = "povnum";
            this.povnum.Size = new System.Drawing.Size(40, 20);
            this.povnum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(9, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "POVs:";
            // 
            // povcon
            // 
            this.povcon.AutoSize = true;
            this.povcon.BackColor = System.Drawing.SystemColors.Control;
            this.povcon.ForeColor = System.Drawing.SystemColors.ControlText;
            this.povcon.Location = new System.Drawing.Point(99, 19);
            this.povcon.Name = "povcon";
            this.povcon.Size = new System.Drawing.Size(78, 17);
            this.povcon.TabIndex = 0;
            this.povcon.Text = "Continuous";
            this.povcon.UseVisualStyleBackColor = false;
            // 
            // povnone
            // 
            this.povnone.AutoSize = true;
            this.povnone.BackColor = System.Drawing.SystemColors.Control;
            this.povnone.Checked = true;
            this.povnone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.povnone.Location = new System.Drawing.Point(99, 44);
            this.povnone.Name = "povnone";
            this.povnone.Size = new System.Drawing.Size(51, 17);
            this.povnone.TabIndex = 0;
            this.povnone.TabStop = true;
            this.povnone.Text = "None";
            this.povnone.UseVisualStyleBackColor = false;
            // 
            // povdir
            // 
            this.povdir.AutoSize = true;
            this.povdir.BackColor = System.Drawing.SystemColors.Control;
            this.povdir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.povdir.Location = new System.Drawing.Point(6, 19);
            this.povdir.Name = "povdir";
            this.povdir.Size = new System.Drawing.Size(81, 17);
            this.povdir.TabIndex = 0;
            this.povdir.Text = "4 Directions";
            this.povdir.UseVisualStyleBackColor = false;
            // 
            // Axes
            // 
            this.Axes.BackColor = System.Drawing.SystemColors.Control;
            this.Axes.Controls.Add(this.yaxisrot);
            this.Axes.Controls.Add(this.xaxisrot);
            this.Axes.Controls.Add(this.vaxis);
            this.Axes.Controls.Add(this.uaxis);
            this.Axes.Controls.Add(this.zaxisrot);
            this.Axes.Controls.Add(this.zaxis);
            this.Axes.Controls.Add(this.yaxis);
            this.Axes.Controls.Add(this.xaxis);
            this.Axes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Axes.Location = new System.Drawing.Point(6, 19);
            this.Axes.Name = "Axes";
            this.Axes.Size = new System.Drawing.Size(151, 134);
            this.Axes.TabIndex = 1;
            this.Axes.TabStop = false;
            this.Axes.Text = "Axes";
            // 
            // yaxisrot
            // 
            this.yaxisrot.AutoSize = true;
            this.yaxisrot.BackColor = System.Drawing.SystemColors.Control;
            this.yaxisrot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yaxisrot.Location = new System.Drawing.Point(51, 111);
            this.yaxisrot.Name = "yaxisrot";
            this.yaxisrot.Size = new System.Drawing.Size(39, 17);
            this.yaxisrot.TabIndex = 2;
            this.yaxisrot.Text = "Ry";
            this.yaxisrot.UseVisualStyleBackColor = false;
            // 
            // xaxisrot
            // 
            this.xaxisrot.AutoSize = true;
            this.xaxisrot.BackColor = System.Drawing.SystemColors.Control;
            this.xaxisrot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xaxisrot.Location = new System.Drawing.Point(6, 111);
            this.xaxisrot.Name = "xaxisrot";
            this.xaxisrot.Size = new System.Drawing.Size(39, 17);
            this.xaxisrot.TabIndex = 2;
            this.xaxisrot.Text = "Rx";
            this.xaxisrot.UseVisualStyleBackColor = false;
            // 
            // vaxis
            // 
            this.vaxis.AutoSize = true;
            this.vaxis.BackColor = System.Drawing.SystemColors.Control;
            this.vaxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.vaxis.Location = new System.Drawing.Point(6, 88);
            this.vaxis.Name = "vaxis";
            this.vaxis.Size = new System.Drawing.Size(93, 17);
            this.vaxis.TabIndex = 2;
            this.vaxis.Text = "V/Dial/Slider2";
            this.vaxis.UseVisualStyleBackColor = false;
            // 
            // uaxis
            // 
            this.uaxis.AutoSize = true;
            this.uaxis.BackColor = System.Drawing.SystemColors.Control;
            this.uaxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uaxis.Location = new System.Drawing.Point(6, 65);
            this.uaxis.Name = "uaxis";
            this.uaxis.Size = new System.Drawing.Size(65, 17);
            this.uaxis.TabIndex = 2;
            this.uaxis.Text = "U/Slider";
            this.uaxis.UseVisualStyleBackColor = false;
            // 
            // zaxisrot
            // 
            this.zaxisrot.AutoSize = true;
            this.zaxisrot.BackColor = System.Drawing.SystemColors.Control;
            this.zaxisrot.Checked = true;
            this.zaxisrot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zaxisrot.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zaxisrot.Location = new System.Drawing.Point(6, 42);
            this.zaxisrot.Name = "zaxisrot";
            this.zaxisrot.Size = new System.Drawing.Size(92, 17);
            this.zaxisrot.TabIndex = 1;
            this.zaxisrot.Text = "R/Rz/Rudder";
            this.zaxisrot.UseVisualStyleBackColor = false;
            // 
            // zaxis
            // 
            this.zaxis.AutoSize = true;
            this.zaxis.BackColor = System.Drawing.SystemColors.Control;
            this.zaxis.Checked = true;
            this.zaxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zaxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zaxis.Location = new System.Drawing.Point(84, 19);
            this.zaxis.Name = "zaxis";
            this.zaxis.Size = new System.Drawing.Size(33, 17);
            this.zaxis.TabIndex = 0;
            this.zaxis.Text = "Z";
            this.zaxis.UseVisualStyleBackColor = false;
            // 
            // yaxis
            // 
            this.yaxis.AutoSize = true;
            this.yaxis.BackColor = System.Drawing.SystemColors.Control;
            this.yaxis.Checked = true;
            this.yaxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.yaxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yaxis.Location = new System.Drawing.Point(45, 19);
            this.yaxis.Name = "yaxis";
            this.yaxis.Size = new System.Drawing.Size(33, 17);
            this.yaxis.TabIndex = 0;
            this.yaxis.Text = "Y";
            this.yaxis.UseVisualStyleBackColor = false;
            // 
            // xaxis
            // 
            this.xaxis.AutoSize = true;
            this.xaxis.BackColor = System.Drawing.SystemColors.Control;
            this.xaxis.Checked = true;
            this.xaxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xaxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.xaxis.Location = new System.Drawing.Point(6, 19);
            this.xaxis.Name = "xaxis";
            this.xaxis.Size = new System.Drawing.Size(33, 17);
            this.xaxis.TabIndex = 0;
            this.xaxis.Text = "X";
            this.xaxis.UseVisualStyleBackColor = false;
            // 
            // resetvJoyBtn
            // 
            this.resetvJoyBtn.BackColor = System.Drawing.SystemColors.Control;
            this.resetvJoyBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetvJoyBtn.Location = new System.Drawing.Point(12, 311);
            this.resetvJoyBtn.Name = "resetvJoyBtn";
            this.resetvJoyBtn.Size = new System.Drawing.Size(352, 34);
            this.resetvJoyBtn.TabIndex = 2;
            this.resetvJoyBtn.Text = "Reset vJoy Device";
            this.resetvJoyBtn.UseVisualStyleBackColor = false;
            this.resetvJoyBtn.Click += new System.EventHandler(this.ResetvJoyBtnClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 350);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(39, 17);
            this.status.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(376, 372);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.configbox);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.deviceGroupBox);
            this.Controls.Add(this.deleteconfbtn);
            this.Controls.Add(this.resetvJoyBtn);
            this.Controls.Add(this.makeconfbtn);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Configure vJoy";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.deviceGroupBox.ResumeLayout(false);
            this.deviceGroupBox.PerformLayout();
            this.configbox.ResumeLayout(false);
            this.configbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnnum)).EndInit();
            this.POV.ResumeLayout(false);
            this.POV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.povnum)).EndInit();
            this.Axes.ResumeLayout(false);
            this.Axes.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button makeconfbtn;
        private System.Windows.Forms.GroupBox deviceGroupBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.Button deleteconfbtn;
        private System.Windows.Forms.CheckBox CheckAll;
        private System.Windows.Forms.GroupBox configbox;
        private System.Windows.Forms.GroupBox Axes;
        private System.Windows.Forms.CheckBox yaxis;
        private System.Windows.Forms.CheckBox xaxis;
        private System.Windows.Forms.CheckBox zaxis;
        private System.Windows.Forms.CheckBox zaxisrot;
        private System.Windows.Forms.CheckBox yaxisrot;
        private System.Windows.Forms.CheckBox xaxisrot;
        private System.Windows.Forms.CheckBox vaxis;
        private System.Windows.Forms.CheckBox uaxis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown btnnum;
        private System.Windows.Forms.GroupBox POV;
        private System.Windows.Forms.NumericUpDown povnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton povcon;
        private System.Windows.Forms.RadioButton povnone;
        private System.Windows.Forms.RadioButton povdir;
        private System.Windows.Forms.Button resetvJoyBtn;
        private System.Windows.Forms.ComboBox Presets;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

