using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace 準中級編課題4_4b
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
        /// string[]型のListを宣言
        /// </summary>
        private List<string[]> list = new List<string[]>();

        /// <summary>
        /// フォームを起動したら、STUDENTテーブルから名前情報をcomBboxに格納する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Regist_Load(object sender, EventArgs e)
        {
            try
            {
                // DELETEDが0のときのSTUDENTテーブルのデータを表示
                string sqlCommand = @"SELECT * FROM STUDENT_TABLE WHERE DELETED = 0;";

                string[] colums = {
                                    "STUDENT_ID",
                                    "STUDENT_NAME",
                                    "DELETED"
                                   };

                // sqlコマンドを実行し、カラム名をListに保存する
                listFromTableData(sqlCommand, colums);

                // Listデータから名前をコンボボックスに追加
                addComboBoxFromList();

                // 0で初期化
                this.comboBox_Name.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// sqlコマンドを実行し、カラム名をListに保存する
        /// </summary>
        /// <param name="sqlCommand">SQL文</param>
        /// <param name="colums">カラム名</param>
        private void listFromTableData(string sqlCommand, string[] colums)
        {
            string dbFile = Application.StartupPath + @"\results2.db";
            SQLiteConnection con = null;
            SQLiteCommand com = null;
            SQLiteDataReader reader = null;

            try
            {
                // 接続文字列
                string connectionString = String.Format("Data Source={0};Version=3;", dbFile);
                // DB Open
                con = new SQLiteConnection(connectionString);
                con.Open();
                com = con.CreateCommand();

                // テーブルのデータを全て表示する
                com.CommandText = sqlCommand;
                reader = com.ExecuteReader();

                this.list.Clear();

                while (reader.Read())
                {
                    string[] s = new string[colums.Length];

                    for (int i = 0; i < colums.Length; i++)
                    {
                        s[i] = reader[colums[i]].ToString();
                    }

                    this.list.Add(s);
                }
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
                if (com != null)
                {
                    com.Dispose();
                }
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        /// <summary>
        /// コンボボックスに名前を追加
        /// </summary>
        private void addComboBoxFromList()
        {
            this.comboBox_Name.Items.Clear();

            for (int i = 0; i < this.list.Count; i++)
            {
                string name = this.list[i][1];
                this.comboBox_Name.Items.Add(name);
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
            this.DialogResult = DialogResult.OK;

            this.scores.StudentID = this.list[this.comboBox_Name.SelectedIndex][0];

            this.scores.Name = this.comboBox_Name.SelectedItem.ToString();
            this.scores.Japanese = this.numericUpDown_Japanese.Value.ToString();
            this.scores.Math = this.numericUpDown_Math.Value.ToString();
            this.scores.English = this.numericUpDown_English.Value.ToString();
        }
    }
}
