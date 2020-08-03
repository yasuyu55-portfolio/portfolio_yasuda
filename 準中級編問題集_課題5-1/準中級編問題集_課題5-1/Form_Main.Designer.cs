namespace 準中級編問題集_課題5_1
{
    partial class Form_Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.button_Zero = new System.Windows.Forms.Button();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_ClearEntry = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_One = new System.Windows.Forms.Button();
            this.button_SignAddDelete = new System.Windows.Forms.Button();
            this.button_Two = new System.Windows.Forms.Button();
            this.button_Three = new System.Windows.Forms.Button();
            this.button_Four = new System.Windows.Forms.Button();
            this.button_Five = new System.Windows.Forms.Button();
            this.button_Six = new System.Windows.Forms.Button();
            this.button_Eight = new System.Windows.Forms.Button();
            this.button_Seven = new System.Windows.Forms.Button();
            this.button_Nine = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Minus = new System.Windows.Forms.Button();
            this.button_Plus = new System.Windows.Forms.Button();
            this.button_DotAdd = new System.Windows.Forms.Button();
            this.button_Equal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.Location = new System.Drawing.Point(46, 25);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.Size = new System.Drawing.Size(297, 19);
            this.textBox_Result.TabIndex = 1;
            this.textBox_Result.TabStop = false;
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Zero
            // 
            this.button_Zero.ForeColor = System.Drawing.Color.Blue;
            this.button_Zero.Location = new System.Drawing.Point(46, 248);
            this.button_Zero.Name = "button_Zero";
            this.button_Zero.Size = new System.Drawing.Size(49, 23);
            this.button_Zero.TabIndex = 0;
            this.button_Zero.Text = "0";
            this.button_Zero.UseVisualStyleBackColor = true;
            this.button_Zero.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Back
            // 
            this.button_Back.ForeColor = System.Drawing.Color.Red;
            this.button_Back.Location = new System.Drawing.Point(46, 78);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(79, 36);
            this.button_Back.TabIndex = 0;
            this.button_Back.Text = "Back";
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_ClearEntry
            // 
            this.button_ClearEntry.ForeColor = System.Drawing.Color.Red;
            this.button_ClearEntry.Location = new System.Drawing.Point(147, 78);
            this.button_ClearEntry.Name = "button_ClearEntry";
            this.button_ClearEntry.Size = new System.Drawing.Size(88, 36);
            this.button_ClearEntry.TabIndex = 0;
            this.button_ClearEntry.Text = "CE";
            this.button_ClearEntry.UseVisualStyleBackColor = true;
            this.button_ClearEntry.Click += new System.EventHandler(this.button_ClearEntry_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.ForeColor = System.Drawing.Color.Red;
            this.button_Clear.Location = new System.Drawing.Point(258, 78);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(98, 36);
            this.button_Clear.TabIndex = 0;
            this.button_Clear.Text = "C";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_One
            // 
            this.button_One.ForeColor = System.Drawing.Color.Blue;
            this.button_One.Location = new System.Drawing.Point(46, 210);
            this.button_One.Name = "button_One";
            this.button_One.Size = new System.Drawing.Size(49, 23);
            this.button_One.TabIndex = 0;
            this.button_One.Text = "1";
            this.button_One.UseVisualStyleBackColor = true;
            this.button_One.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_SignAddDelete
            // 
            this.button_SignAddDelete.ForeColor = System.Drawing.Color.Blue;
            this.button_SignAddDelete.Location = new System.Drawing.Point(123, 248);
            this.button_SignAddDelete.Name = "button_SignAddDelete";
            this.button_SignAddDelete.Size = new System.Drawing.Size(45, 23);
            this.button_SignAddDelete.TabIndex = 0;
            this.button_SignAddDelete.Text = "+/-";
            this.button_SignAddDelete.UseVisualStyleBackColor = true;
            this.button_SignAddDelete.Click += new System.EventHandler(this.button_SignAddDelete_Click);
            // 
            // button_Two
            // 
            this.button_Two.ForeColor = System.Drawing.Color.Blue;
            this.button_Two.Location = new System.Drawing.Point(123, 210);
            this.button_Two.Name = "button_Two";
            this.button_Two.Size = new System.Drawing.Size(45, 23);
            this.button_Two.TabIndex = 0;
            this.button_Two.Text = "2";
            this.button_Two.UseVisualStyleBackColor = true;
            this.button_Two.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Three
            // 
            this.button_Three.ForeColor = System.Drawing.Color.Blue;
            this.button_Three.Location = new System.Drawing.Point(190, 210);
            this.button_Three.Name = "button_Three";
            this.button_Three.Size = new System.Drawing.Size(45, 23);
            this.button_Three.TabIndex = 0;
            this.button_Three.Text = "3";
            this.button_Three.UseVisualStyleBackColor = true;
            this.button_Three.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Four
            // 
            this.button_Four.ForeColor = System.Drawing.Color.Blue;
            this.button_Four.Location = new System.Drawing.Point(46, 181);
            this.button_Four.Name = "button_Four";
            this.button_Four.Size = new System.Drawing.Size(49, 23);
            this.button_Four.TabIndex = 0;
            this.button_Four.Text = "4";
            this.button_Four.UseVisualStyleBackColor = true;
            this.button_Four.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Five
            // 
            this.button_Five.ForeColor = System.Drawing.Color.Blue;
            this.button_Five.Location = new System.Drawing.Point(123, 181);
            this.button_Five.Name = "button_Five";
            this.button_Five.Size = new System.Drawing.Size(45, 23);
            this.button_Five.TabIndex = 0;
            this.button_Five.Text = "5";
            this.button_Five.UseVisualStyleBackColor = true;
            this.button_Five.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Six
            // 
            this.button_Six.ForeColor = System.Drawing.Color.Blue;
            this.button_Six.Location = new System.Drawing.Point(190, 181);
            this.button_Six.Name = "button_Six";
            this.button_Six.Size = new System.Drawing.Size(45, 23);
            this.button_Six.TabIndex = 0;
            this.button_Six.Text = "6";
            this.button_Six.UseVisualStyleBackColor = true;
            this.button_Six.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Eight
            // 
            this.button_Eight.ForeColor = System.Drawing.Color.Blue;
            this.button_Eight.Location = new System.Drawing.Point(124, 141);
            this.button_Eight.Name = "button_Eight";
            this.button_Eight.Size = new System.Drawing.Size(44, 23);
            this.button_Eight.TabIndex = 0;
            this.button_Eight.Text = "8";
            this.button_Eight.UseVisualStyleBackColor = true;
            this.button_Eight.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Seven
            // 
            this.button_Seven.ForeColor = System.Drawing.Color.Blue;
            this.button_Seven.Location = new System.Drawing.Point(46, 141);
            this.button_Seven.Name = "button_Seven";
            this.button_Seven.Size = new System.Drawing.Size(49, 23);
            this.button_Seven.TabIndex = 0;
            this.button_Seven.Text = "7";
            this.button_Seven.UseVisualStyleBackColor = true;
            this.button_Seven.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Nine
            // 
            this.button_Nine.ForeColor = System.Drawing.Color.Blue;
            this.button_Nine.Location = new System.Drawing.Point(190, 141);
            this.button_Nine.Name = "button_Nine";
            this.button_Nine.Size = new System.Drawing.Size(45, 23);
            this.button_Nine.TabIndex = 0;
            this.button_Nine.Text = "9";
            this.button_Nine.UseVisualStyleBackColor = true;
            this.button_Nine.Click += new System.EventHandler(this.button_Number_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.ForeColor = System.Drawing.Color.Red;
            this.button_Divide.Location = new System.Drawing.Point(258, 137);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(52, 27);
            this.button_Divide.TabIndex = 0;
            this.button_Divide.Text = "/";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_SinbolDecide_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.ForeColor = System.Drawing.Color.Red;
            this.button_Multiply.Location = new System.Drawing.Point(258, 177);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(52, 27);
            this.button_Multiply.TabIndex = 0;
            this.button_Multiply.Text = "*";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_SinbolDecide_Click);
            // 
            // button_Minus
            // 
            this.button_Minus.ForeColor = System.Drawing.Color.Red;
            this.button_Minus.Location = new System.Drawing.Point(258, 210);
            this.button_Minus.Name = "button_Minus";
            this.button_Minus.Size = new System.Drawing.Size(52, 23);
            this.button_Minus.TabIndex = 0;
            this.button_Minus.Text = "-";
            this.button_Minus.UseVisualStyleBackColor = true;
            this.button_Minus.Click += new System.EventHandler(this.button_SinbolDecide_Click);
            // 
            // button_Plus
            // 
            this.button_Plus.ForeColor = System.Drawing.Color.Red;
            this.button_Plus.Location = new System.Drawing.Point(258, 248);
            this.button_Plus.Name = "button_Plus";
            this.button_Plus.Size = new System.Drawing.Size(52, 23);
            this.button_Plus.TabIndex = 0;
            this.button_Plus.Text = "+";
            this.button_Plus.UseVisualStyleBackColor = true;
            this.button_Plus.Click += new System.EventHandler(this.button_SinbolDecide_Click);
            // 
            // button_DotAdd
            // 
            this.button_DotAdd.ForeColor = System.Drawing.Color.Blue;
            this.button_DotAdd.Location = new System.Drawing.Point(190, 248);
            this.button_DotAdd.Name = "button_DotAdd";
            this.button_DotAdd.Size = new System.Drawing.Size(45, 23);
            this.button_DotAdd.TabIndex = 0;
            this.button_DotAdd.Text = ".";
            this.button_DotAdd.UseVisualStyleBackColor = true;
            this.button_DotAdd.Click += new System.EventHandler(this.button_DotAdd_Click);
            // 
            // button_Equal
            // 
            this.button_Equal.ForeColor = System.Drawing.Color.Red;
            this.button_Equal.Location = new System.Drawing.Point(327, 248);
            this.button_Equal.Name = "button_Equal";
            this.button_Equal.Size = new System.Drawing.Size(50, 23);
            this.button_Equal.TabIndex = 0;
            this.button_Equal.Text = "=";
            this.button_Equal.UseVisualStyleBackColor = true;
            this.button_Equal.Click += new System.EventHandler(this.button_Equal_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 312);
            this.Controls.Add(this.button_Equal);
            this.Controls.Add(this.button_DotAdd);
            this.Controls.Add(this.button_Plus);
            this.Controls.Add(this.button_Minus);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Nine);
            this.Controls.Add(this.button_Eight);
            this.Controls.Add(this.button_Seven);
            this.Controls.Add(this.button_Six);
            this.Controls.Add(this.button_Five);
            this.Controls.Add(this.button_Four);
            this.Controls.Add(this.button_Three);
            this.Controls.Add(this.button_Two);
            this.Controls.Add(this.button_SignAddDelete);
            this.Controls.Add(this.button_One);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_ClearEntry);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.button_Zero);
            this.Controls.Add(this.textBox_Result);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Activated += new System.EventHandler(this.Form_Main_Activated);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button button_Zero;
        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Button button_ClearEntry;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_One;
        private System.Windows.Forms.Button button_SignAddDelete;
        private System.Windows.Forms.Button button_Two;
        private System.Windows.Forms.Button button_Three;
        private System.Windows.Forms.Button button_Four;
        private System.Windows.Forms.Button button_Five;
        private System.Windows.Forms.Button button_Six;
        private System.Windows.Forms.Button button_Eight;
        private System.Windows.Forms.Button button_Seven;
        private System.Windows.Forms.Button button_Nine;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Minus;
        private System.Windows.Forms.Button button_Plus;
        private System.Windows.Forms.Button button_DotAdd;
        private System.Windows.Forms.Button button_Equal;
    }
}

