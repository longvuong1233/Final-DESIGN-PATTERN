
namespace GUI_ELECTRIC
{
    partial class Assign
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
            this.customerCb = new System.Windows.Forms.ComboBox();
            this.meterCb = new System.Windows.Forms.ComboBox();
            this.customerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.meterGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCb
            // 
            this.customerCb.FormattingEnabled = true;
            this.customerCb.Location = new System.Drawing.Point(62, 73);
            this.customerCb.Name = "customerCb";
            this.customerCb.Size = new System.Drawing.Size(207, 24);
            this.customerCb.TabIndex = 0;
            // 
            // meterCb
            // 
            this.meterCb.FormattingEnabled = true;
            this.meterCb.Location = new System.Drawing.Point(1013, 73);
            this.meterCb.Name = "meterCb";
            this.meterCb.Size = new System.Drawing.Size(216, 24);
            this.meterCb.TabIndex = 1;
            // 
            // customerGridView
            // 
            this.customerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerGridView.Location = new System.Drawing.Point(24, 182);
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.RowHeadersWidth = 51;
            this.customerGridView.RowTemplate.Height = 24;
            this.customerGridView.Size = new System.Drawing.Size(932, 221);
            this.customerGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1010, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Meter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Khách Hàng:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(436, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meterGridView
            // 
            this.meterGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.meterGridView.Location = new System.Drawing.Point(1013, 182);
            this.meterGridView.Name = "meterGridView";
            this.meterGridView.RowHeadersWidth = 51;
            this.meterGridView.RowTemplate.Height = 24;
            this.meterGridView.Size = new System.Drawing.Size(316, 221);
            this.meterGridView.TabIndex = 2;
            // 
            // Assign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.meterGridView);
            this.Controls.Add(this.meterCb);
            this.Controls.Add(this.customerCb);
            this.Name = "Assign";
            this.Text = "Assign";
            this.Load += new System.EventHandler(this.Assign_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meterGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerCb;
        private System.Windows.Forms.ComboBox meterCb;
        private System.Windows.Forms.DataGridView customerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView meterGridView;
    }
}