namespace 準中級編課題4_1g
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
            this.listView_Results = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Read = new System.Windows.Forms.Button();
            this.label_AvereageJpanese = new System.Windows.Forms.Label();
            this.label_AverageMath = new System.Windows.Forms.Label();
            this.label_AverageEnglish = new System.Windows.Forms.Label();
            this.textBox_JapaneseAverage = new System.Windows.Forms.TextBox();
            this.textBox_MathAverage = new System.Windows.Forms.TextBox();
            this.textBox_EnglishAverage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_Results
            // 
            this.listView_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView_Results.FullRowSelect = true;
            this.listView_Results.GridLines = true;
            this.listView_Results.Location = new System.Drawing.Point(24, 28);
            this.listView_Results.Name = "listView_Results";
            this.listView_Results.Size = new System.Drawing.Size(311, 134);
            this.listView_Results.TabIndex = 0;
            this.listView_Results.UseCompatibleStateImageBehavior = false;
            this.listView_Results.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "国語";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "数学";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "英語";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "合計";
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(260, 194);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(75, 23);
            this.button_Read.TabIndex = 1;
            this.button_Read.Text = "読み込み";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // label_AvereageJpanese
            // 
            this.label_AvereageJpanese.AutoSize = true;
            this.label_AvereageJpanese.Location = new System.Drawing.Point(13, 185);
            this.label_AvereageJpanese.Name = "label_AvereageJpanese";
            this.label_AvereageJpanese.Size = new System.Drawing.Size(53, 12);
            this.label_AvereageJpanese.TabIndex = 2;
            this.label_AvereageJpanese.Text = "国語平均";
            // 
            // label_AverageMath
            // 
            this.label_AverageMath.AutoSize = true;
            this.label_AverageMath.Location = new System.Drawing.Point(12, 219);
            this.label_AverageMath.Name = "label_AverageMath";
            this.label_AverageMath.Size = new System.Drawing.Size(53, 12);
            this.label_AverageMath.TabIndex = 3;
            this.label_AverageMath.Text = "数学平均";
            // 
            // label_AverageEnglish
            // 
            this.label_AverageEnglish.AutoSize = true;
            this.label_AverageEnglish.Location = new System.Drawing.Point(13, 247);
            this.label_AverageEnglish.Name = "label_AverageEnglish";
            this.label_AverageEnglish.Size = new System.Drawing.Size(53, 12);
            this.label_AverageEnglish.TabIndex = 4;
            this.label_AverageEnglish.Text = "英語平均";
            // 
            // textBox_JapaneseAverage
            // 
            this.textBox_JapaneseAverage.Location = new System.Drawing.Point(82, 182);
            this.textBox_JapaneseAverage.Name = "textBox_JapaneseAverage";
            this.textBox_JapaneseAverage.ReadOnly = true;
            this.textBox_JapaneseAverage.Size = new System.Drawing.Size(100, 19);
            this.textBox_JapaneseAverage.TabIndex = 5;
            // 
            // textBox_MathAverage
            // 
            this.textBox_MathAverage.Location = new System.Drawing.Point(82, 216);
            this.textBox_MathAverage.Name = "textBox_MathAverage";
            this.textBox_MathAverage.ReadOnly = true;
            this.textBox_MathAverage.Size = new System.Drawing.Size(100, 19);
            this.textBox_MathAverage.TabIndex = 6;
            // 
            // textBox_EnglishAverage
            // 
            this.textBox_EnglishAverage.Location = new System.Drawing.Point(82, 244);
            this.textBox_EnglishAverage.Name = "textBox_EnglishAverage";
            this.textBox_EnglishAverage.ReadOnly = true;
            this.textBox_EnglishAverage.Size = new System.Drawing.Size(100, 19);
            this.textBox_EnglishAverage.TabIndex = 7;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 292);
            this.Controls.Add(this.textBox_EnglishAverage);
            this.Controls.Add(this.textBox_MathAverage);
            this.Controls.Add(this.textBox_JapaneseAverage);
            this.Controls.Add(this.label_AverageEnglish);
            this.Controls.Add(this.label_AverageMath);
            this.Controls.Add(this.label_AvereageJpanese);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.listView_Results);
            this.Name = "Form_Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Results;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button_Read;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label_AvereageJpanese;
        private System.Windows.Forms.Label label_AverageMath;
        private System.Windows.Forms.Label label_AverageEnglish;
        private System.Windows.Forms.TextBox textBox_JapaneseAverage;
        private System.Windows.Forms.TextBox textBox_MathAverage;
        private System.Windows.Forms.TextBox textBox_EnglishAverage;
    }
}

