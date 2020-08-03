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

namespace 準中級編課題4_1g
{
    /// <summary>
    /// results.dbからSQLコマンドでデータを読み込む
    /// 生徒の成績（国語、数学、英語、合計点、平均点）を表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押したら、DBのデータを読み込み、
        /// リストビューには合計点の高い順に並べて表示して、
        /// テキストボックスに国語・数学・英語の平均点を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Read_Click(object sender, EventArgs e)
        {
            try
            {
                // 合計点の高い順に並べて表示するコマンド
                string sqlCommand = "SELECT " +
                                  "STUDENT_NAME " +
                                  ",JAPANESE_POINT " +
                                  ",MATHEMATICS_POINT " +
                                  ",ENGLISH_POINT " +
                                  ",JAPANESE_POINT + MATHEMATICS_POINT + ENGLISH_POINT AS TOTAL " +
                                  "FROM RESULT_TABLE " +
                                  "ORDER BY TOTAL DESC;";

                // readerで読み取るカラム名
                string[] colum ={
                                   "STUDENT_NAME",
                                   "JAPANESE_POINT",
                                   "MATHEMATICS_POINT",
                                   "ENGLISH_POINT",
                                   "TOTAL"
                                };

                // SQLコマンドを実行し、Listにデータを保存する
                List<string[]> list = editSQL(sqlCommand, colum);

                // Listのデータをリストビューに表示
                display(list);

                // 国語、数学、英語の平均を求めるコマンド
                sqlCommand = "SELECT " +
                                "AVG(JAPANESE_POINT) " +
                                ",AVG(MATHEMATICS_POINT) " +
                                ",AVG(ENGLISH_POINT) " +
                                "FROM RESULT_TABLE;";

                // readerで読み取るカラム名
                string[] colum2 ={
                                   "AVG(JAPANESE_POINT)",
                                   "AVG(MATHEMATICS_POINT)",
                                   "AVG(ENGLISH_POINT)"
                                 };

                // SQLコマンドを実行し、Listにデータを保存する
                List<string[]> listAverage = editSQL(sqlCommand, colum2);

                this.textBox_JapaneseAverage.Text = listAverage[0][0];
                this.textBox_MathAverage.Text = listAverage[0][1];
                this.textBox_EnglishAverage.Text = listAverage[0][2];
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// SQLコマンドを実行し、指定したカラムの値をListに保存する
        /// </summary>
        /// <param name="sqlCommand">SQL文</param>
        /// <param name="colum">カラム名の配列</param>
        /// <returns>SQLで読み込んだデータ</returns>
        private List<string[]> editSQL(string sqlCommand, string[] colum)
        {
            string dbFile = Application.StartupPath + @"\results.db";
            SQLiteConnection con = null;
            SQLiteCommand com = null;
            SQLiteDataReader reader = null;

            List<string[]> list = new List<string[]>();

            try
            {
                // 接続文字列
                string connectionString = String.Format("Data Source={0};Version=3;", dbFile);
                // DB Open
                con = new SQLiteConnection(connectionString);
                con.Open();
                com = con.CreateCommand();

                // 引数のSQLコマンドを代入
                com.CommandText = sqlCommand;

                reader = com.ExecuteReader();

                while (reader.Read())
                {
                    string[] s = new string[colum.Length];

                    for (int i = 0; i < colum.Length; i++)
                    {
                        // リードするカラム名
                        s[i] = reader[colum[i]].ToString();
                    }

                    list.Add(s);
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

            return list;
        }

        /// <summary>
        /// Listのデータをリストビューに表示する
        /// </summary>
        /// <param name="list">SQLで読み込んだListデータ</param>
        private void display(List<string[]> list)
        {
            this.listView_Results.Items.Clear();
            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem lv = new ListViewItem(list[i]);
                this.listView_Results.Items.Add(lv);
            }
        }
    }
}

