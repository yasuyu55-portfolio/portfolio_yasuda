using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 準中級編_課題1_4
{
    /// <summary>
    /// サブフォームで名前と年齢を入れてもらい、このフォームで表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押し、サブフォームのOKボタンを押されたら
        /// テキストボックスに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Input_Click(object sender, EventArgs e)
        {
            Form_Sub form_Sub = new Form_Sub();

            DialogResult dr = new DialogResult();

            dr = form_Sub.ShowDialog();

            if (dr == DialogResult.OK)
            {
                this.textBox_Name.Text = form_Sub.Person.Name;
                this.textBox_Age.Text = form_Sub.Person.Age;
            }
        }
    }
}
