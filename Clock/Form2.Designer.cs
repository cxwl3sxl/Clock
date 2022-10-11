namespace Clock
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.iWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyWindowSize = new System.Windows.Forms.Button();
            this.btnApplyFontSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iFontSize = new System.Windows.Forms.NumericUpDown();
            this.btnSecondColor = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cbFixed = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Location = new System.Drawing.Point(12, 12);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(405, 23);
            this.btnBorderColor.TabIndex = 0;
            this.btnBorderColor.Text = "边框颜色";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(12, 41);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(405, 23);
            this.btnTextColor.TabIndex = 1;
            this.btnTextColor.Text = "文字颜色";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // iWindowSize
            // 
            this.iWindowSize.Location = new System.Drawing.Point(83, 104);
            this.iWindowSize.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.iWindowSize.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.iWindowSize.Name = "iWindowSize";
            this.iWindowSize.Size = new System.Drawing.Size(249, 21);
            this.iWindowSize.TabIndex = 4;
            this.iWindowSize.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "窗体大小：";
            // 
            // btnApplyWindowSize
            // 
            this.btnApplyWindowSize.Location = new System.Drawing.Point(338, 103);
            this.btnApplyWindowSize.Name = "btnApplyWindowSize";
            this.btnApplyWindowSize.Size = new System.Drawing.Size(79, 23);
            this.btnApplyWindowSize.TabIndex = 6;
            this.btnApplyWindowSize.Text = "应用";
            this.btnApplyWindowSize.UseVisualStyleBackColor = true;
            this.btnApplyWindowSize.Click += new System.EventHandler(this.btnApplyWindowSize_Click);
            // 
            // btnApplyFontSize
            // 
            this.btnApplyFontSize.Location = new System.Drawing.Point(338, 132);
            this.btnApplyFontSize.Name = "btnApplyFontSize";
            this.btnApplyFontSize.Size = new System.Drawing.Size(79, 23);
            this.btnApplyFontSize.TabIndex = 9;
            this.btnApplyFontSize.Text = "应用";
            this.btnApplyFontSize.UseVisualStyleBackColor = true;
            this.btnApplyFontSize.Click += new System.EventHandler(this.btnApplyFontSize_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "文字字号：";
            // 
            // iFontSize
            // 
            this.iFontSize.Location = new System.Drawing.Point(83, 133);
            this.iFontSize.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.iFontSize.Name = "iFontSize";
            this.iFontSize.Size = new System.Drawing.Size(249, 21);
            this.iFontSize.TabIndex = 7;
            this.iFontSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnSecondColor
            // 
            this.btnSecondColor.Location = new System.Drawing.Point(12, 70);
            this.btnSecondColor.Name = "btnSecondColor";
            this.btnSecondColor.Size = new System.Drawing.Size(405, 23);
            this.btnSecondColor.TabIndex = 15;
            this.btnSecondColor.Text = "指针颜色";
            this.btnSecondColor.UseVisualStyleBackColor = true;
            this.btnSecondColor.Click += new System.EventHandler(this.btnSecondColor_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "桌面时钟";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cbFixed
            // 
            this.cbFixed.AutoSize = true;
            this.cbFixed.Checked = true;
            this.cbFixed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFixed.Location = new System.Drawing.Point(14, 164);
            this.cbFixed.Name = "cbFixed";
            this.cbFixed.Size = new System.Drawing.Size(72, 16);
            this.cbFixed.TabIndex = 16;
            this.cbFixed.Text = "固定位置";
            this.cbFixed.UseVisualStyleBackColor = true;
            this.cbFixed.CheckedChanged += new System.EventHandler(this.cbFixed_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(92, 160);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(325, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "关闭程序";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 411);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cbFixed);
            this.Controls.Add(this.btnSecondColor);
            this.Controls.Add(this.btnApplyFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iFontSize);
            this.Controls.Add(this.btnApplyWindowSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iWindowSize);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btnBorderColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.NumericUpDown iWindowSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApplyWindowSize;
        private System.Windows.Forms.Button btnApplyFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown iFontSize;
        private System.Windows.Forms.Button btnSecondColor;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox cbFixed;
        private System.Windows.Forms.Button btnExit;
    }
}