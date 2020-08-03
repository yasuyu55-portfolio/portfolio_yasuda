using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 準中級編課題4_3b
{
    /// <summary>
    /// 生徒の名前と国語・英語・数学の成績を登録する
    /// </summary>
    public partial class Form_Regist : Form
    {
        public Form_Regist()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Scoresクラスのオブジェクトscoresを生成
        /// </summary>
        private Scores scores = new Scores();

        /// <summary>
        /// ScoresクラスのオブジェクトScoreRegistを生成
        /// </summary>
        public Scores ScoreRegist
        {
            set
            {
                this.scores = value;
            }
            get
            {
                return this.scores;
            }
        }

        /// <summary>
        /// ボタンを押したら、Registフォームに入力されたデータを
        /// メインフォームのリストビューの最後の行に追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            string nameText = this.textBox_Name.Text;
            int nameInt = 0;

            // テキストボックスの名前欄が空白
            // または数字のとき
            if (String.IsNullOrEmpty(nameText) || int.TryParse(nameText, out nameInt))
            {
                MessageBox.Show("名前を正しく入力してください。");
                return;
            }

            this.DialogResult = DialogResult.OK;

            this.scores.Name = nameText;
            this.scores.Japanese = this.numericUpDown_Japanese.Value.ToString(); 
            this.scores.Math = this.numericUpDown_Math.Value.ToString(); 
            this.scores.English = this.numericUpDown_English.Value.ToString(); 
        }
    }
}
