namespace 準中級編_課題1_2
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
            this.textBox_SubOutput = new System.Windows.Forms.TextBox();
            this.button_SubOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_SubOutput
            // 
            this.textBox_SubOutput.Location = new System.Drawing.Point(60, 80);
            this.textBox_SubOutput.Name = "textBox_SubOutput";
            this.textBox_SubOutput.ReadOnly = true;
            this.textBox_SubOutput.Size = new System.Drawing.Size(100, 19);
            this.textBox_SubOutput.TabIndex = 0;
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
            // 
            // Form_Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 262);
            this.Controls.Add(this.button_SubOK);
            this.Controls.Add(this.textBox_SubOutput);
            this.Name = "Form_Sub";
            this.Load += new System.EventHandler(this.Form_Sub_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_SubOutput;
        private System.Windows.Forms.Button button_SubOK;
    }
}