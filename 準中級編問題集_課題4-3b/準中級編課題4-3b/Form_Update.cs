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
    /// 生徒の名前と国語・英語・数学の成績を更新する
    /// </summary>
    public partial class Form_Update : Form
    {
        public Form_Update()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Scoresクラスのオブジェクトscoresを生成
        /// </summary>
        private Scores scores = new Scores();

        /// <summary>
        /// ScoresクラスのオブジェクトScoreUpdateを生成
        /// </summary>
        public Scores ScoreUpdate
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
        /// Updateフォームを起動したら、メインフォームのリストビューで選択した項目を
        /// テキストボックスとnumericUpDownに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Update_Load(object sender, EventArgs e)
        {
            this.textBox_Name.Text = this.scores.Name;
            this.numericUpDown_Japanese.Value = decimal.Parse(this.scores.Japanese);
            this.numericUpDown_Math.Value = decimal.Parse(this.scores.Math);
            this.numericUpDown_English.Value = decimal.Parse(this.scores.English);
        }

        /// <summary>
        /// ボタンを押したら、Updateフォームに入力されたデータを
        /// メインフォームのリストビューの最後の行に追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            this.scores.Name = this.textBox_Name.Text;
            this.scores.Japanese = this.numericUpDown_Japanese.Value.ToString();
            this.scores.Math = this.numericUpDown_Math.Value.ToString();
            this.scores.English = this.numericUpDown_English.Value.ToString();
        }
    }
}
