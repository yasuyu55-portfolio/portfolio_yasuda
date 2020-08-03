using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 準中級編_課題1_2
{
    /// <summary>
    /// フォームに入力したものをボタンを押したら、サブフォームに表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押したら、subフォームを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Input_Click(object sender, EventArgs e)
        {
            Form_Sub form_Sub = new Form_Sub();

            // 何も入力されていないとき
            if (String.IsNullOrEmpty(this.textBox_MainInput.Text))
            {
                MessageBox.Show("何も入力されていません。");
                return;
            }

            form_Sub.Password = this.textBox_MainInput.Text;

            DialogResult dr = new DialogResult();
            dr = form_Sub.ShowDialog();

            // Form_SubのOKボタンが押されたとき
            if (dr == DialogResult.OK)
            {
                this.textBox_MainInput.Text = String.Empty;
            }
        }
    }
}
