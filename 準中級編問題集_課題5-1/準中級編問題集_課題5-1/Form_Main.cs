using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 準中級編問題集_課題5_1
{
    /// <summary>
    /// 電卓アプリケーション
    /// </summary>
    public partial class Form_Main : System.Windows.Forms.Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// string型のListを宣言
        /// </summary>
        private List<string> listNumbers = new List<string>();

        /// <summary>
        /// 演算記号のボタンを押したときにテキストボックスの値を格納するメンバ変数
        /// </summary>
        private string beforResult = string.Empty;

        /// <summary>
        /// 演算記号を格納する
        /// </summary>
        private string symbol = string.Empty;

        /// <summary>
        /// フォームを起動したら、「0.」をテキストボックスに表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // 初期状態にする
            returnFirstState();
        }

        /// <summary>
        /// 初期状態にする
        /// </summary>
        private void returnFirstState()
        {
            this.listNumbers.Clear();

            this.textBox_Result.Text = "0.";

            this.beforResult = string.Empty;
        }

        /// <summary>
        /// テキストボックスにListの要素を書き出すメソッド
        /// </summary>
        private void displayText()
        {
            string display = string.Empty;

            for (int i = 0; i < this.listNumbers.Count; i++)
            {
                display += this.listNumbers[i];
            }

            // リストの中に「.」がある場合
            if (this.listNumbers.Contains("."))
            {
                this.textBox_Result.Text = display;
            }
            else
            {
                this.textBox_Result.Text = display + ".";
            }
        }

        /// <summary>
        /// イベントハンドラを統一したボタンのTextプロパティを返す
        /// </summary>
        /// <param name="sender">押したボタンのイベント</param>
        /// <returns>押したボタンのTextプロパティ</returns>
        private string integrateButton(object sender)
        {
            Button btn = null;

            // senderをButton型として扱う
            btn = (Button)sender;

            return btn.Text;
        }

        /// <summary>
        /// ボタンを押したら、Textプロパティの値を追加して表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Number_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // リストの要素数が1で、かつ中身が「0」のとき
            if (this.listNumbers.Count == 1
                && this.listNumbers[0] == "0"
              )
            {
                this.listNumbers.RemoveAt(0);
            }

            // 押したボタンのTextプロパティをListに追加
            this.listNumbers.Add(integrateButton(sender));

            // テキストボックスにListの要素を表示する
            displayText();
        }

        /// <summary>
        /// ボタンが押されたら、テキストボックスの先頭に－をつけるか削除する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SignAddDelete_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            if (this.listNumbers.Count == 0 ||
                (this.listNumbers[0] == "0" && this.listNumbers.Count == 1)
                )
            {
                // リストの要素が空のとき
                // または、リストの要素数が1でかつ最初の値が0のとき
                return;
            }
            else if (this.listNumbers[0] == "-")
            {
                // リストの最初の値が「-」のとき
                this.listNumbers.RemoveAt(0);
            }
            else
            {
                // 上記２つ以外のとき
                this.listNumbers.Insert(0, "-");
            }

            // テキストボックスにListの要素を表示する
            displayText();
        }

        /// <summary>
        /// ボタンを押したら、テキストボックスの末尾に「.」を追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_DotAdd_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            if (this.listNumbers.Count == 0)
            {
                // リストの中身が空のとき
                this.listNumbers.Add("0");
            }
            else if (this.listNumbers.Contains("."))
            {
                // リストの中に「.」があるとき
                return;
            }

            this.listNumbers.Add(".");

            // テキストボックスにListの要素を表示する
            displayText();
        }

        /// <summary>
        /// ボタンを押したら、初期状態に戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Clear_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // 初期状態
            returnFirstState();
        }

        /// <summary>
        /// ボタンを押したら、テキストボックスの右端の数字を削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Back_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            if (this.listNumbers.Count == 0)
            {
                // リストの中身が空のとき
                return;
            }

            if (this.listNumbers.Count == 1
                    || (this.listNumbers.Count == 2 && this.listNumbers.Contains("-"))
                    || (this.listNumbers.Count == 3 && this.listNumbers[0] == ("-") && this.listNumbers[1] == ("0"))
                     )
            {
                // リストの要素数が1のとき
                // リストの要素数が2で「-」が含まれているとき
                // リストの要素数が3で「-0.」の形のとき
                this.listNumbers.Clear();
                this.textBox_Result.Text = "0.";
            }
            else
            {
                this.listNumbers.RemoveAt(this.listNumbers.Count - 1);

                // テキストボックスにListの要素を表示する
                displayText();
            }
        }

        /// <summary>
        /// ボタンを押したら、テキストボックスの値をメンバ変数に格納
        /// 押した演算子のボタンのTextをメンバ変数に格納
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_SinbolDecide_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // テキストボックスの値をメンバ変数に格納
            this.beforResult = this.textBox_Result.Text;

            this.listNumbers.Clear();

            // 押した演算子のボタンのTextをメンバ変数に格納
            this.symbol = integrateButton(sender);
        }

        /// <summary>
        /// 引数の文字列を分割してListに格納するメソッド
        /// </summary>
        /// <param name="resultNumber">string型の文字列</param>
        private void reconstructList(string resultNumber)
        {
            // リストの中身を空にする
            this.listNumbers.Clear();

            // stringの文字列を一文字ずつ分割し、char型の配列に格納する
            char[] cs = resultNumber.ToCharArray();

            // 分割した文字をstring型に変換してListに格納
            for (int i = 0; i < cs.Length; i++)
            {
                string s = cs[i].ToString();
                this.listNumbers.Add(s);
            }
        }

        /// <summary>
        /// ボタンを押したら選択した演算子の条件で計算し、テキストボックスに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Equal_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            // メンバ変数beforeResultが空白のとき
            if (string.IsNullOrEmpty(this.beforResult))
            {
                return;
            }

            double beforeNumbers = 0;

            if (!double.TryParse(this.beforResult, out beforeNumbers))
            {
                MessageBox.Show("エラーです。");
                return;
            }

            // テキストボックスの値が「+∞.」のとき
            if (this.textBox_Result.Text == "+∞.")
            {
                return;
            }

            double afterNumbers = 0;

            if (!double.TryParse(this.textBox_Result.Text, out afterNumbers))
            {
                MessageBox.Show("エラーです。");
                return;
            }

            if (this.symbol == "+")
            {
                afterNumbers += beforeNumbers;
            }
            else if (this.symbol == "-")
            {
                afterNumbers = beforeNumbers - afterNumbers;
            }
            else if (this.symbol == "*")
            {
                afterNumbers *= beforeNumbers;
            }
            else if (this.symbol == "/")
            {
                if (afterNumbers == 0)
                {
                    MessageBox.Show("0で割り算は出来ません。");
                    return;
                }

                afterNumbers = beforeNumbers / afterNumbers;
            }

            // 計算結果の文字列を分割してlistNumbersに格納する
            reconstructList(afterNumbers.ToString());

            // 計算結果をテキストボックスに表示
            displayText();
        }

        /// <summary>
        /// ボタンを押したら、表示している数値のみ初期状態にする
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;

            this.listNumbers.Clear();
            this.textBox_Result.Text = "0.";
        }

        /// <summary>
        /// キーボードから入力したキーとボタンのクリックを連携させる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D1:
                case Keys.NumPad1:
                    this.button_One.Focus();
                    this.button_One.PerformClick();
                    break;

                case Keys.D2:
                case Keys.NumPad2:
                    this.button_Two.Focus();
                    this.button_Two.PerformClick();
                    break;

                case Keys.D3:
                case Keys.NumPad3:
                    this.button_Three.Focus();
                    this.button_Three.PerformClick();
                    break;

                case Keys.D4:
                case Keys.NumPad4:
                    this.button_Four.Focus();
                    this.button_Four.PerformClick();
                    break;

                case Keys.D5:
                case Keys.NumPad5:
                    this.button_Five.Focus();
                    this.button_Five.PerformClick();
                    break;

                case Keys.D6:
                case Keys.NumPad6:
                    this.button_Six.Focus();
                    this.button_Six.PerformClick();
                    break;

                case Keys.D7:
                case Keys.NumPad7:
                    this.button_Seven.Focus();
                    this.button_Seven.PerformClick();
                    break;

                case Keys.D8:
                case Keys.NumPad8:
                    this.button_Eight.Focus();
                    this.button_Eight.PerformClick();
                    break;

                case Keys.D9:
                case Keys.NumPad9:
                    this.button_Nine.Focus();
                    this.button_Nine.PerformClick();
                    break;

                case Keys.D0:
                case Keys.NumPad0:
                    this.button_Zero.Focus();
                    this.button_Zero.PerformClick();
                    break;

                case Keys.Enter:
                    this.button_Equal.Focus();
                    this.button_Equal.PerformClick();
                    break;

                case Keys.Back:
                    this.button_Back.Focus();
                    this.button_Back.PerformClick();
                    break;

                case Keys.Delete:
                    this.button_ClearEntry.Focus();
                    this.button_ClearEntry.PerformClick();
                    break;

                case Keys.Escape:
                    this.button_Clear.Focus();
                    this.button_Clear.PerformClick();
                    break;

                case Keys.F9:
                    this.button_SignAddDelete.Focus();
                    this.button_SignAddDelete.PerformClick();
                    break;

                case Keys.OemPeriod:
                case Keys.Decimal:
                    this.button_DotAdd.Focus();
                    this.button_DotAdd.PerformClick();
                    break;

                case Keys.OemQuestion:
                case Keys.Divide:
                    this.button_Divide.Focus();
                    this.button_Divide.PerformClick();
                    break;

                case Keys.OemMinus:
                case Keys.Subtract:
                    this.button_Minus.Focus();
                    this.button_Minus.PerformClick();
                    break;

                case Keys.Add:
                    this.button_Plus.Focus();
                    this.button_Plus.PerformClick();
                    break;

                case Keys.Multiply:
                    this.button_Multiply.Focus();
                    this.button_Multiply.PerformClick();
                    break;
            }

            // Shiftキーが押されている場合
            if (e.KeyCode == (Keys.ShiftKey | Keys.OemSemicolon))
            {
                // [:]ボタンが押されたとき
                this.button_Multiply.Focus();
                this.button_Multiply.PerformClick();
            }
            else if (e.KeyCode == (Keys.ShiftKey | Keys.Oemplus))
            {
                // [;]キーが押されたとき
                this.button_Plus.Focus();
                this.button_Plus.PerformClick();
            }
        }

        /// <summary>
        /// Enterキーが「=」のみの動作を実行させるためのイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Activated(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
