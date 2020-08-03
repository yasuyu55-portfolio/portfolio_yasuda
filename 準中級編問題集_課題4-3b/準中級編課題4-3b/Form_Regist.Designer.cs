namespace 準中級編課題4_3b
{
    partial class Form_Regist
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
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Japanese = new System.Windows.Forms.Label();
            this.label_Math = new System.Windows.Forms.Label();
            this.label_English = new System.Windows.Forms.Label();
            this.numericUpDown_Japanese = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Math = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_English = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Japanese)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Math)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_English)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(25, 186);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 2;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(136, 186);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 3;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(136, 30);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 19);
            this.textBox_Name.TabIndex = 4;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(23, 36);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 12);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "名前";
            // 
            // label_Japanese
            // 
            this.label_Japanese.AutoSize = true;
            this.label_Japanese.Location = new System.Drawing.Point(23, 78);
            this.label_Japanese.Name = "label_Japanese";
            this.label_Japanese.Size = new System.Drawing.Size(29, 12);
            this.label_Japanese.TabIndex = 6;
            this.label_Japanese.Text = "国語";
            // 
            // label_Math
            // 
            this.label_Math.AutoSize = true;
            this.label_Math.Location = new System.Drawing.Point(23, 113);
            this.label_Math.Name = "label_Math";
            this.label_Math.Size = new System.Drawing.Size(29, 12);
            this.label_Math.TabIndex = 7;
            this.label_Math.Text = "数学";
            // 
            // label_English
            // 
            this.label_English.AutoSize = true;
            this.label_English.Location = new System.Drawing.Point(23, 145);
            this.label_English.Name = "label_English";
            this.label_English.Size = new System.Drawing.Size(29, 12);
            this.label_English.TabIndex = 8;
            this.label_English.Text = "英語";
            // 
            // numericUpDown_Japanese
            // 
            this.numericUpDown_Japanese.Location = new System.Drawing.Point(116, 76);
            this.numericUpDown_Japanese.Name = "numericUpDown_Japanese";
            this.numericUpDown_Japanese.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_Japanese.TabIndex = 9;
            // 
            // numericUpDown_Math
            // 
            this.numericUpDown_Math.Location = new System.Drawing.Point(116, 106);
            this.numericUpDown_Math.Name = "numericUpDown_Math";
            this.numericUpDown_Math.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_Math.TabIndex = 10;
            // 
            // numericUpDown_English
            // 
            this.numericUpDown_English.Location = new System.Drawing.Point(116, 143);
            this.numericUpDown_English.Name = "numericUpDown_English";
            this.numericUpDown_English.Size = new System.Drawing.Size(120, 19);
            this.numericUpDown_English.TabIndex = 11;
            // 
            // Form_Regist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 256);
            this.Controls.Add(this.numericUpDown_English);
            this.Controls.Add(this.numericUpDown_Math);
            this.Controls.Add(this.numericUpDown_Japanese);
            this.Controls.Add(this.label_English);
            this.Controls.Add(this.label_Math);
            this.Controls.Add(this.label_Japanese);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_OK);
            this.Name = "Form_Regist";
            this.Text = "登録";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Japanese)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Math)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_English)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Japanese;
        private System.Windows.Forms.Label label_Math;
        private System.Windows.Forms.Label label_English;
        private System.Windows.Forms.NumericUpDown numericUpDown_Japanese;
        private System.Windows.Forms.NumericUpDown numericUpDown_Math;
        private System.Windows.Forms.NumericUpDown numericUpDown_English;
    }
}