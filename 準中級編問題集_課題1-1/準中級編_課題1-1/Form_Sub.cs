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
    /// サブフォームで名前を入力し、メインフォームで表示する
    /// </summary>
    public partial class Form_Sub : Form
    {
        public Form_Sub()
        {
            InitializeComponent();
        }

        /// <summary>
        /// string型のメンバ変数を宣言
        /// </summary>
        private string name = string.Empty;

        /// <summary>
        /// プロパティの宣言
        /// </summary>
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        /// <summary>
        ///  ボタンを押したら,テキストボックスに入力された文字を
        ///  passwordに代入する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Sub_OK_Click(object sender, EventArgs e)
        {
            // 何も入力されていないとき
            if (String.IsNullOrEmpty(this.textBox_SubInput.Text))
            {
                MessageBox.Show("名前が入力されていません。");
                return;
            }

            // 整数が入力されたとき
            if (int.TryParse(this.textBox_SubInput.Text, out int errorInt))
            {
                MessageBox.Show("名前は文字で入力してください。");
                return;
            }

            // 小数点が入力されたとき
            if (double.TryParse(this.textBox_SubInput.Text, out double errorDouble))
            {
                MessageBox.Show("名前は文字で入力してください。");
                return;
            }

            this.name = this.textBox_SubInput.Text;
        }
    }
}
