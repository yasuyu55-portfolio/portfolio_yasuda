namespace 準中級編_課題1_3
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
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.button_Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(79, 36);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(100, 19);
            this.textBox_Name.TabIndex = 0;
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(79, 80);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.ReadOnly = true;
            this.textBox_Age.Size = new System.Drawing.Size(100, 19);
            this.textBox_Age.TabIndex = 1;
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(79, 134);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(75, 23);
            this.button_Input.TabIndex = 2;
            this.button_Input.Text = "入力";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Input);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Button button_Input;
    }
}

