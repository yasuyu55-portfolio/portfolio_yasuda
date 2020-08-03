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

namespace 準中級編課題4_3b
{
    /// <summary>
    /// 生徒の成績の登録・更新・削除を行い、リストビューに表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// string[]型のListを宣言
        /// テーブルのデータをListに格納する
        /// </summary>
        private List<string[]> list = new List<string[]>();

        /// <summary>
        /// 起動したら、DBからデータを読み込み、
        /// リストビューにテーブルのデータを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            try
            {
                // テーブルのデータを全てメンバ変数のリストに格納する
                listFromTableData();

                // メンバ変数のListデータをリストビューに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// ボタンを押したら、Registフォームを表示する
        /// Registフォームに入力したデータをリストビューに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Regist_Click(object sender, EventArgs e)
        {
            Form_Regist form_Regist = new Form_Regist();
            DialogResult dr = new DialogResult();

            dr = form_Regist.ShowDialog();

            try
            {
                // RegistフォームのOKボタンが押されたとき以外
                if (dr != DialogResult.OK)
                {
                    return;
                }
                string sqlName = form_Regist.ScoreRegist.Name;
                string sqlJpanese = form_Regist.ScoreRegist.Japanese;
                string sqlMath = form_Regist.ScoreRegist.Math;
                string sqlEnglish = form_Regist.ScoreRegist.English;

                // テーブルにデータを追加するコマンド
                string sqlCommand = @"
                                    INSERT
						            INTO RESULT_TABLE
                                    (
									  STUDENT_NAME,
									  JAPANESE_POINT,
									  MATHEMATICS_POINT,
									  ENGLISH_POINT
                                    )
                                    VALUES
                                    (
						            '" + sqlName + "',"
                                + sqlJpanese + ","
                                + sqlMath + ","
                                + sqlEnglish + ");";

                // SQLコマンドを実行し、テーブルに反映
                editTableData(sqlCommand);

                // テーブルのデータをListに保存する
                listFromTableData();

                // Listのデータをリストビューに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ボタンを押したら、リストビューで選択した行のデータを更新して
        /// 再度リストビューに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Update_Click(object sender, EventArgs e)
        {
            // リストビューで選択された項目が無ければメッセージボックスを表示
            if (this.listView_Results.SelectedIndices.Count == 0)
            {
                MessageBox.Show("変更するデータを選択してください。");
                return;
            }

            int index = this.listView_Results.SelectedIndices[0];

            try
            {
                Form_Update form_Update = new Form_Update();
                DialogResult dr = new DialogResult();

                // リストビューで選択した行の値をUpdateフォームに表示
                form_Update.ScoreUpdate.Name = this.list[index][1];
                form_Update.ScoreUpdate.Japanese = this.list[index][2];
                form_Update.ScoreUpdate.Math = this.list[index][3];
                form_Update.ScoreUpdate.English = this.list[index][4];

                dr = form_Update.ShowDialog();

                // UpdateフォームのOKボタンが押されたとき以外
                if (dr != DialogResult.OK)
                {
                    return;
                }

                string sqlName = form_Update.ScoreUpdate.Name;
                string sqlJpanese = form_Update.ScoreUpdate.Japanese;
                string sqlMath = form_Update.ScoreUpdate.Math;
                string sqlEnglish = form_Update.ScoreUpdate.English;

                // テーブルのデータを更新するコマンド
                string sqlcommand = @"
                                    UPDATE
						              RESULT_TABLE
                                    SET
									  STUDENT_NAME = '" + sqlName +
                                  "' ,JAPANESE_POINT =" + sqlJpanese +
                                  ",MATHEMATICS_POINT =" + sqlMath +
                                  ",ENGLISH_POINT =" + sqlEnglish +
                               " WHERE RESULT_ID = " + this.list[index][0] +
                                ";";

                // SQLコマンドを実行し、テーブルに反映
                editTableData(sqlcommand);

                // テーブルのデータを全てListに格納する
                listFromTableData();

                // Listのデータをリストビューに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ボタンを押したら、リストビューで選択した箇所を
        /// テーブルから削除して、テーブルデータを
        /// リストビューに再表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Delete_Click(object sender, EventArgs e)
        {
            // リストビューで選択された項目が無ければメッセージボックスを表示
            if (this.listView_Results.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除するデータを選択してください。");
                return;
            }

            int index = this.listView_Results.SelectedIndices[0];

            try
            {
                // テーブルのデータを更新
                string sqlCommand = @"
                                      DELETE
                                       FROM
						              RESULT_TABLE
                                       WHERE RESULT_ID = " + this.list[index][0] +
                                      ";";

                // SQLコマンドを実行し、テーブルに反映
                editTableData(sqlCommand);

                // リストビューにテーブルのデータを表示する
                listFromTableData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// 引数のSQLコマンドを実行し、テーブルのデータに反映する
        /// </summary>
        /// <param name="sqlCommand">SQLテキスト</param>
        private void editTableData(string sqlCommand)
        {
            string dbFile = Application.StartupPath + @"\results.db";
            SQLiteConnection con = null;
            SQLiteCommand com = null;

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

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
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
        /// テーブルのデータを全てメンバ変数のリストに格納する
        /// </summary>
        private void listFromTableData()
        {
            string dbFile = Application.StartupPath + @"\results.db";
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
                com.CommandText = "SELECT * FROM RESULT_TABLE;";
                reader = com.ExecuteReader();

                this.list.Clear();

                while (reader.Read())
                {
                    string[] s ={
                                   reader["RESULT_ID"].ToString(),
                                   reader["STUDENT_NAME"].ToString(),
                                   reader["JAPANESE_POINT"].ToString(),
                                   reader["MATHEMATICS_POINT"].ToString(),
                                   reader["ENGLISH_POINT"].ToString()
                                };
                    this.list.Add(s);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        /// メンバ変数のListデータをリストビューに表示する
        /// </summary>
        private void displayListData()
        {
            this.listView_Results.Items.Clear();
            for (int i = 0; i < this.list.Count; i++)
            {
                string[] s ={
                               this.list[i][1],
                               this.list[i][2],
                               this.list[i][3],
                               this.list[i][4],
                            };

                ListViewItem lv = new ListViewItem(s);
                this.listView_Results.Items.Add(lv);
            }
        }
    }
}
