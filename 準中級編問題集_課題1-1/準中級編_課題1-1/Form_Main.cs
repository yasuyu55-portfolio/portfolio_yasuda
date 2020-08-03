using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 準中級編_課題1_1
{
    /// <summary>
    /// サブフォームで入力した名前をメインフォームで表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押したら,サブフォームを出す
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Input_Click(object sender, EventArgs e)
        {
            Form_Sub form_Sub = new Form_Sub();

            DialogResult dr = new DialogResult();

            dr = form_Sub.ShowDialog();

            // サブフォームのOKボタンが押されたら、サブフォームに入力した文字を
            // メインフォームのテキストボックスに表示する
            if (dr == DialogResult.OK)
            {
                this.textBox_MainOutput.Text = form_Sub.Name;
            }
        }
    }
}
