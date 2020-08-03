namespace 準中級編_課題1_2
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
            this.textBox_MainInput = new System.Windows.Forms.TextBox();
            this.button_Input = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_MainInput
            // 
            this.textBox_MainInput.Location = new System.Drawing.Point(63, 73);
            this.textBox_MainInput.Name = "textBox_MainInput";
            this.textBox_MainInput.Size = new System.Drawing.Size(100, 19);
            this.textBox_MainInput.TabIndex = 0;
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(77, 154);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(75, 23);
            this.button_Input.TabIndex = 1;
            this.button_Input.Text = "表示";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_Input);
            this.Controls.Add(this.textBox_MainInput);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_MainInput;
        private System.Windows.Forms.Button button_Input;
    }
}

