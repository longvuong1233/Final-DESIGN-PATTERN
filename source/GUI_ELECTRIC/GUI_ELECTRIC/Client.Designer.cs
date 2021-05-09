
namespace GUI_ELECTRIC
{
    partial class Client
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
            this.counter = new System.Windows.Forms.Label();
            this.off1 = new System.Windows.Forms.Button();
            this.on1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listDevice = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.on2 = new System.Windows.Forms.Button();
            this.off2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.on3 = new System.Windows.Forms.Button();
            this.off3 = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.on4 = new System.Windows.Forms.Button();
            this.off4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbIdMeter = new System.Windows.Forms.Label();
            this.lbPhone = new System.Windows.Forms.Label();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCost = new System.Windows.Forms.Label();
            this.lbPay = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.admintratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listDevice.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // counter
            // 
            this.counter.AutoSize = true;
            this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counter.Location = new System.Drawing.Point(29, 34);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(27, 29);
            this.counter.TabIndex = 2;
            this.counter.Text = "0";
            // 
            // off1
            // 
            this.off1.Location = new System.Drawing.Point(211, 3);
            this.off1.Name = "off1";
            this.off1.Size = new System.Drawing.Size(75, 23);
            this.off1.TabIndex = 3;
            this.off1.Text = "Off";
            this.off1.UseVisualStyleBackColor = true;
            this.off1.Click += new System.EventHandler(this.off1_Click);
            // 
            // on1
            // 
            this.on1.Location = new System.Drawing.Point(130, 3);
            this.on1.Name = "on1";
            this.on1.Size = new System.Drawing.Size(75, 23);
            this.on1.TabIndex = 2;
            this.on1.Text = "On";
            this.on1.UseVisualStyleBackColor = true;
            this.on1.Click += new System.EventHandler(this.on1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "FAN",
            "TIVI",
            "LIGHT",
            "Điều Hòa",
            "None"});
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listDevice
            // 
            this.listDevice.Controls.Add(this.comboBox1);
            this.listDevice.Controls.Add(this.on1);
            this.listDevice.Controls.Add(this.off1);
            this.listDevice.Controls.Add(this.comboBox2);
            this.listDevice.Controls.Add(this.on2);
            this.listDevice.Controls.Add(this.off2);
            this.listDevice.Controls.Add(this.comboBox3);
            this.listDevice.Controls.Add(this.on3);
            this.listDevice.Controls.Add(this.off3);
            this.listDevice.Controls.Add(this.comboBox4);
            this.listDevice.Controls.Add(this.on4);
            this.listDevice.Controls.Add(this.off4);
            this.listDevice.Location = new System.Drawing.Point(320, 34);
            this.listDevice.Name = "listDevice";
            this.listDevice.Size = new System.Drawing.Size(302, 134);
            this.listDevice.TabIndex = 3;
            this.listDevice.Paint += new System.Windows.Forms.PaintEventHandler(this.listDevice_Paint);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "FAN",
            "TIVI",
            "LIGHT",
            "Điều Hòa",
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(3, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // on2
            // 
            this.on2.Location = new System.Drawing.Point(130, 33);
            this.on2.Name = "on2";
            this.on2.Size = new System.Drawing.Size(75, 23);
            this.on2.TabIndex = 6;
            this.on2.Text = "On";
            this.on2.UseVisualStyleBackColor = true;
            this.on2.Click += new System.EventHandler(this.on2_Click);
            // 
            // off2
            // 
            this.off2.Location = new System.Drawing.Point(211, 33);
            this.off2.Name = "off2";
            this.off2.Size = new System.Drawing.Size(75, 23);
            this.off2.TabIndex = 7;
            this.off2.Text = "Off";
            this.off2.UseVisualStyleBackColor = true;
            this.off2.Click += new System.EventHandler(this.off2_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "FAN",
            "TIVI",
            "LIGHT",
            "Điều Hòa",
            "None"});
            this.comboBox3.Location = new System.Drawing.Point(3, 63);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // on3
            // 
            this.on3.Location = new System.Drawing.Point(130, 63);
            this.on3.Name = "on3";
            this.on3.Size = new System.Drawing.Size(75, 23);
            this.on3.TabIndex = 10;
            this.on3.Text = "On";
            this.on3.UseVisualStyleBackColor = true;
            this.on3.Click += new System.EventHandler(this.on3_Click);
            // 
            // off3
            // 
            this.off3.Location = new System.Drawing.Point(211, 63);
            this.off3.Name = "off3";
            this.off3.Size = new System.Drawing.Size(75, 23);
            this.off3.TabIndex = 11;
            this.off3.Text = "Off";
            this.off3.UseVisualStyleBackColor = true;
            this.off3.Click += new System.EventHandler(this.off3_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "FAN",
            "TIVI",
            "LIGHT",
            "Điều Hòa",
            "None"});
            this.comboBox4.Location = new System.Drawing.Point(3, 93);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 12;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // on4
            // 
            this.on4.Location = new System.Drawing.Point(130, 93);
            this.on4.Name = "on4";
            this.on4.Size = new System.Drawing.Size(75, 23);
            this.on4.TabIndex = 14;
            this.on4.Text = "On";
            this.on4.UseVisualStyleBackColor = true;
            this.on4.Click += new System.EventHandler(this.on4_Click);
            // 
            // off4
            // 
            this.off4.Location = new System.Drawing.Point(211, 93);
            this.off4.Name = "off4";
            this.off4.Size = new System.Drawing.Size(75, 23);
            this.off4.TabIndex = 15;
            this.off4.Text = "Off";
            this.off4.UseVisualStyleBackColor = true;
            this.off4.Click += new System.EventHandler(this.off4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbIdMeter);
            this.panel1.Controls.Add(this.lbPhone);
            this.panel1.Controls.Add(this.lbAddress);
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 178);
            this.panel1.TabIndex = 4;
            // 
            // lbIdMeter
            // 
            this.lbIdMeter.AutoSize = true;
            this.lbIdMeter.Location = new System.Drawing.Point(89, 144);
            this.lbIdMeter.Name = "lbIdMeter";
            this.lbIdMeter.Size = new System.Drawing.Size(25, 17);
            this.lbIdMeter.TabIndex = 9;
            this.lbIdMeter.Text = "ID:";
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(108, 115);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(25, 17);
            this.lbPhone.TabIndex = 8;
            this.lbPhone.Text = "ID:";
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(69, 79);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(25, 17);
            this.lbAddress.TabIndex = 7;
            this.lbAddress.Text = "ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(50, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(25, 17);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "ID:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(50, 12);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(25, 17);
            this.lbID.TabIndex = 5;
            this.lbID.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID Meter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thông Tin Khách Hàng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(100, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Light";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(379, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 100);
            this.panel2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(275, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Điều Hòa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 14);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Fan";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(278, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(181, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tivi";
            // 
            // lbCost
            // 
            this.lbCost.AutoSize = true;
            this.lbCost.Location = new System.Drawing.Point(9, 85);
            this.lbCost.Name = "lbCost";
            this.lbCost.Size = new System.Drawing.Size(20, 17);
            this.lbCost.TabIndex = 8;
            this.lbCost.Text = "...";
            this.lbCost.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbPay
            // 
            this.lbPay.AutoSize = true;
            this.lbPay.Location = new System.Drawing.Point(9, 115);
            this.lbPay.Name = "lbPay";
            this.lbPay.Size = new System.Drawing.Size(20, 17);
            this.lbPay.TabIndex = 9;
            this.lbPay.Text = "...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admintratorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(821, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // admintratorToolStripMenuItem
            // 
            this.admintratorToolStripMenuItem.Name = "admintratorToolStripMenuItem";
            this.admintratorToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.admintratorToolStripMenuItem.Text = "Administration";
            this.admintratorToolStripMenuItem.Click += new System.EventHandler(this.admintratorToolStripMenuItem_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 579);
            this.Controls.Add(this.lbPay);
            this.Controls.Add(this.lbCost);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listDevice);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.listDevice.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label counter;
        private System.Windows.Forms.Button off1;
        private System.Windows.Forms.Button on1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel listDevice;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button on2;
        private System.Windows.Forms.Button off2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button on3;
        private System.Windows.Forms.Button off3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button on4;
        private System.Windows.Forms.Button off4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbIdMeter;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCost;
        private System.Windows.Forms.Label lbPay;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem admintratorToolStripMenuItem;
    }
}