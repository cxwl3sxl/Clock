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
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.iWindowSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApplyWindowSize = new System.Windows.Forms.Button();
            this.btnApplyFontSize = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.iFontSize = new System.Windows.Forms.NumericUpDown();
            this.iMoveStep = new System.Windows.Forms.NumericUpDown();
            this.btnSecondColor = new System.Windows.Forms.Button();
            this.btnRight = new Clock.MyButton();
            this.btnDown = new Clock.MyButton();
            this.btnLeft = new Clock.MyButton();
            this.btnUp = new Clock.MyButton();
            this.myButton1 = new Clock.MyButton();
            this.myButton2 = new Clock.MyButton();
            this.myButton3 = new Clock.MyButton();
            this.myButton4 = new Clock.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.iWindowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMoveStep)).BeginInit();
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
            // iMoveStep
            // 
            this.iMoveStep.Location = new System.Drawing.Point(183, 268);
            this.iMoveStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iMoveStep.Name = "iMoveStep";
            this.iMoveStep.Size = new System.Drawing.Size(60, 21);
            this.iMoveStep.TabIndex = 14;
            this.iMoveStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iMoveStep.Value = new decimal(new int[] {
            5,
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
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(272, 246);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(60, 60);
            this.btnRight.TabIndex = 13;
            this.btnRight.Text = "右移";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.ClickAction += new System.Action(this.btnRight_ClickAction);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(183, 332);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(60, 60);
            this.btnDown.TabIndex = 12;
            this.btnDown.Text = "下移";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.ClickAction += new System.Action(this.btnDown_ClickAction);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(83, 246);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(60, 60);
            this.btnLeft.TabIndex = 11;
            this.btnLeft.Text = "左移";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.ClickAction += new System.Action(this.btnLeft_ClickAction);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(183, 173);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(60, 60);
            this.btnUp.TabIndex = 10;
            this.btnUp.Text = "上移";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.ClickAction += new System.Action(this.btnUp_ClickAction);
            // 
            // myButton1
            // 
            this.myButton1.Location = new System.Drawing.Point(83, 173);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(60, 60);
            this.myButton1.TabIndex = 16;
            this.myButton1.Text = "移动\r\n左上";
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // myButton2
            // 
            this.myButton2.Location = new System.Drawing.Point(272, 173);
            this.myButton2.Name = "myButton2";
            this.myButton2.Size = new System.Drawing.Size(60, 60);
            this.myButton2.TabIndex = 17;
            this.myButton2.Text = "移动\r\n右上";
            this.myButton2.UseVisualStyleBackColor = true;
            // 
            // myButton3
            // 
            this.myButton3.Location = new System.Drawing.Point(83, 332);
            this.myButton3.Name = "myButton3";
            this.myButton3.Size = new System.Drawing.Size(60, 60);
            this.myButton3.TabIndex = 18;
            this.myButton3.Text = "移动\r\n左下";
            this.myButton3.UseVisualStyleBackColor = true;
            // 
            // myButton4
            // 
            this.myButton4.Location = new System.Drawing.Point(272, 332);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(60, 60);
            this.myButton4.TabIndex = 19;
            this.myButton4.Text = "移动\r\n右下";
            this.myButton4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 411);
            this.Controls.Add(this.myButton4);
            this.Controls.Add(this.myButton3);
            this.Controls.Add(this.myButton2);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.btnSecondColor);
            this.Controls.Add(this.iMoveStep);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnApplyFontSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iFontSize);
            this.Controls.Add(this.btnApplyWindowSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iWindowSize);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.btnBorderColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            ((System.ComponentModel.ISupportInitialize)(this.iWindowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMoveStep)).EndInit();
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
        private MyButton btnUp;
        private MyButton btnLeft;
        private MyButton btnDown;
        private MyButton btnRight;
        private System.Windows.Forms.NumericUpDown iMoveStep;
        private System.Windows.Forms.Button btnSecondColor;
        private MyButton myButton1;
        private MyButton myButton2;
        private MyButton myButton3;
        private MyButton myButton4;
    }
}