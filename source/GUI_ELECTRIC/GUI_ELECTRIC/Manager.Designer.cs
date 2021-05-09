
namespace GUI_ELECTRIC
{
    partial class Manager
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
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.MeterGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputIDMeter = new System.Windows.Forms.TextBox();
            this.inputCounter = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.assign = new System.Windows.Forms.ToolStripMenuItem();
            this.newMeterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeterGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(25, 194);
            this.customerGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 29;
            this.customerGridView.Size = new System.Drawing.Size(859, 223);
            this.customerGridView.TabIndex = 0;
            this.customerGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellContentClick);
            this.customerGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerGridView_CellContentDoubleClick);
            this.customerGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerGridView_CellMouseClick);
            // 
            // MeterGridView
            // 
            this.MeterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MeterGridView.Location = new System.Drawing.Point(966, 194);
            this.MeterGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MeterGridView.Name = "MeterGridView";
            this.MeterGridView.RowHeadersWidth = 51;
            this.MeterGridView.RowTemplate.Height = 29;
            this.MeterGridView.Size = new System.Drawing.Size(356, 223);
            this.MeterGridView.TabIndex = 1;
            this.MeterGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MeterGridView_CellMouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Địa Chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(966, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "ID Meter:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(966, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Counter:";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(178, 53);
            this.inputName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(190, 22);
            this.inputName.TabIndex = 6;
            // 
            // inputAddress
            // 
            this.inputAddress.Location = new System.Drawing.Point(114, 94);
            this.inputAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.Size = new System.Drawing.Size(190, 22);
            this.inputAddress.TabIndex = 7;
            // 
            // inputIDMeter
            // 
            this.inputIDMeter.Location = new System.Drawing.Point(1042, 53);
            this.inputIDMeter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputIDMeter.Name = "inputIDMeter";
            this.inputIDMeter.Size = new System.Drawing.Size(114, 22);
            this.inputIDMeter.TabIndex = 8;
            // 
            // inputCounter
            // 
            this.inputCounter.Location = new System.Drawing.Point(1042, 94);
            this.inputCounter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputCounter.Name = "inputCounter";
            this.inputCounter.Size = new System.Drawing.Size(190, 22);
            this.inputCounter.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1362, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menu
            // 
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.assign,
            this.newMeterToolStripMenuItem});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(60, 24);
            this.menu.Text = "Menu";
            // 
            // assign
            // 
            this.assign.Name = "assign";
            this.assign.Size = new System.Drawing.Size(165, 26);
            this.assign.Text = "Assign";
            this.assign.Click += new System.EventHandler(this.assign_Click);
            // 
            // newMeterToolStripMenuItem
            // 
            this.newMeterToolStripMenuItem.Name = "newMeterToolStripMenuItem";
            this.newMeterToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newMeterToolStripMenuItem.Text = "New Meter";
            this.newMeterToolStripMenuItem.Click += new System.EventHandler(this.newMeterToolStripMenuItem_Click);
            // 
            // inputPhone
            // 
            this.inputPhone.Location = new System.Drawing.Point(488, 53);
            this.inputPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputPhone.Name = "inputPhone";
            this.inputPhone.Size = new System.Drawing.Size(190, 22);
            this.inputPhone.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Số Điện Thoại:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "VND",
            "Do La"});
            this.comboBox5.Location = new System.Drawing.Point(178, 146);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 24);
            this.comboBox5.TabIndex = 14;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(39, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Tính tiền điện";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 428);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.inputPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputCounter);
            this.Controls.Add(this.inputIDMeter);
            this.Controls.Add(this.inputAddress);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeterGridView);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Manager";
            this.Text = "ID Meter:";
            this.Load += new System.EventHandler(this.Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MeterGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.DataGridView MeterGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputIDMeter;
        private System.Windows.Forms.TextBox inputCounter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem assign;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox inputPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem newMeterToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button3;
    }
}

