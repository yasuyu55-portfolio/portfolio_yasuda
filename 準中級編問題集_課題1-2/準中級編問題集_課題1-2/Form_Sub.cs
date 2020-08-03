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
    /// メインフォームに入力したものをフォームに表示する
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
        private string password = string.Empty;

        /// <summary>
        /// プロパティの宣言
        /// </summary>
        public string Password
        {
            set
            {
                this.password = value;
            }
            get
            {
                return this.password;
            }
        }

        /// <summary>
        /// サブフォームをロードしたときにテキストボックスに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Sub_Load(object sender, EventArgs e)
        {
            this.textBox_SubOutput.Text = this.password;
        }
    }
}
