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
    /// 名前と年齢を入力し、メインフォームにデータを渡す
    /// </summary>
    public partial class Form_Sub : Form
    {
        public Form_Sub()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Personクラスのオブジェクトpersonを生成
        /// </summary>
        private Person person = new Person();

        /// <summary>
        /// データを受け渡すプロパティを宣言
        /// </summary>
        public Person Person
        {
            set
            {
                this.person = value;
            }
            get
            {
                return this.person;
            }
        }

        /// <summary>
        /// ボタンを押したらテキストボックスに入力したデータを
        /// Dataに保存する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            string name = this.textBox_Name.Text;
            string age = this.textBox_Age.Text;

            int ageInt = 0;
            int nameInt = 0;

            // テキストボックスの名前欄が空白
            // または数字のとき
            if (string.IsNullOrEmpty(name) || int.TryParse(name, out nameInt))
            {
                MessageBox.Show("名前を正しく入力してください。");
                return;
            }

            // テキストボックスの年齢欄が空白 または文字列のとき
            // または文字列のとき
            if (!int.TryParse(age, out ageInt))
            {
                MessageBox.Show("年齢を数字で入力してください。");
                return;
            }

            // 入力された年齢の値が0未満
            if (ageInt < 0)
            {
                MessageBox.Show("入力した年齢をもう一度確認してください");
                return;
            }

            this.person.Name = name;
            this.person.Age = ageInt.ToString();
        }
    }
}
