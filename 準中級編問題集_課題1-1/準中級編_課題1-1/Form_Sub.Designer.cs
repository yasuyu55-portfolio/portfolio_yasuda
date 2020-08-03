namespace 準中級編_課題1_1
{
    partial class Form_Sub
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
            this.textBox_SubInput = new System.Windows.Forms.TextBox();
            this.button_SubOK = new System.Windows.Forms.Button();
            this.button_SubCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SubInput
            // 
            this.textBox_SubInput.Location = new System.Drawing.Point(35, 67);
            this.textBox_SubInput.Name = "textBox_SubInput";
            this.textBox_SubInput.Size = new System.Drawing.Size(100, 19);
            this.textBox_SubInput.TabIndex = 0;
            // 
            // button_SubOK
            // 
            this.button_SubOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_SubOK.Location = new System.Drawing.Point(60, 166);
            this.button_SubOK.Name = "button_SubOK";
            this.button_SubOK.Size = new System.Drawing.Size(75, 23);
            this.button_SubOK.TabIndex = 1;
            this.button_SubOK.Text = "OK";
            this.button_SubOK.UseVisualStyleBackColor = true;
            this.button_SubOK.Click += new System.EventHandler(this.button_Sub_OK_Click);
            // 
            // button_SubCancel
            // 
            this.button_SubCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_SubCancel.Location = new System.Drawing.Point(171, 166);
            this.button_SubCancel.Name = "button_SubCancel";
            this.button_SubCancel.Size = new System.Drawing.Size(75, 23);
            this.button_SubCancel.TabIndex = 2;
            this.button_SubCancel.Text = "Cancel";
            this.button_SubCancel.UseVisualStyleBackColor = true;
            // 
            // Form_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 262);
            this.Controls.Add(this.button_SubCancel);
            this.Controls.Add(this.button_SubOK);
            this.Controls.Add(this.textBox_SubInput);
            this.Name = "Form_Sub";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SubInput;
        private System.Windows.Forms.Button button_SubOK;
        private System.Windows.Forms.Button button_SubCancel;
    }
}