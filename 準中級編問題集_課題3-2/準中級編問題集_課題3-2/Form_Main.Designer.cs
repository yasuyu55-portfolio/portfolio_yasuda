namespace 準中級編問題集_課題3_2
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
            this.listView_Jpananese = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Display = new System.Windows.Forms.Button();
            this.listView_Math = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_English = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Jpananese
            // 
            this.listView_Jpananese.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_Jpananese.GridLines = true;
            this.listView_Jpananese.Location = new System.Drawing.Point(34, 32);
            this.listView_Jpananese.Name = "listView_Jpananese";
            this.listView_Jpananese.Size = new System.Drawing.Size(147, 136);
            this.listView_Jpananese.TabIndex = 0;
            this.listView_Jpananese.UseCompatibleStateImageBehavior = false;
            this.listView_Jpananese.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名前";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "国語";
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(231, 241);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(75, 23);
            this.button_Display.TabIndex = 1;
            this.button_Display.Text = "表示";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button_Display_Click);
            // 
            // listView_Math
            // 
            this.listView_Math.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.listView_Math.GridLines = true;
            this.listView_Math.Location = new System.Drawing.Point(212, 32);
            this.listView_Math.Name = "listView_Math";
            this.listView_Math.Size = new System.Drawing.Size(152, 136);
            this.listView_Math.TabIndex = 2;
            this.listView_Math.UseCompatibleStateImageBehavior = false;
            this.listView_Math.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "名前";
            this.columnHeader6.Width = 75;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "数学";
            // 
            // listView_English
            // 
            this.listView_English.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12});
            this.listView_English.GridLines = true;
            this.listView_English.Location = new System.Drawing.Point(418, 32);
            this.listView_English.Name = "listView_English";
            this.listView_English.Size = new System.Drawing.Size(162, 136);
            this.listView_English.TabIndex = 3;
            this.listView_English.UseCompatibleStateImageBehavior = false;
            this.listView_English.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "名前";
            this.columnHeader11.Width = 81;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "英語";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 324);
            this.Controls.Add(this.listView_English);
            this.Controls.Add(this.listView_Math);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.listView_Jpananese);
            this.Name = "Form_Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Jpananese;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.ListView listView_Math;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listView_English;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
    }
}

