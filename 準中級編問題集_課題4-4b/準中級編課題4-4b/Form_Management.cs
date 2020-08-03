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
    public partial class Form_Management : Form
    {
        public Form_Management()
        {
            InitializeComponent();
        }

        /// <summary>
        /// string型のListを宣言
        /// </summary>
        private List<string[]> list = new List<string[]>();

        /// <summary>
        /// Manegmentフォームを起動したら、テーブルデータをリストボックスに表示する。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Management_Load(object sender, EventArgs e)
        {
            try
            {
                // テーブルのデータを全てメンバ変数のListに格納する
                listFromTableData();

                // Listのデータをリストボックスに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ボタンを押したら、Manegementフォームに入力されたデータを
        /// メインフォームのリストボックスの最後の行に追加する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Add_Click(object sender, EventArgs e)
        {
            string nameText = this.textBox_Name.Text;
            int nameInt = 0;

            // テキストボックスの名前欄が空白
            // または数字のとき
            if (String.IsNullOrEmpty(nameText) || int.TryParse(nameText, out nameInt))
            {
                MessageBox.Show("名前を入力してください。");
                return;
            }

            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i][1] == nameText)
                {
                    MessageBox.Show("同じ名前は登録できません。");

                    // テキストボックスを空白にする
                    this.textBox_Name.Text = string.Empty;
                    return;
                }
            }

            try
            {
                string sqlCommand = @"
                                    INSERT
						            INTO STUDENT_TABLE
                                    (
                                     STUDENT_NAME,
                                     DELETED
                                    )
                                    VALUES
                                    ('" +
                                     nameText
                                     + @"' ,
                                    0);";

                // 引数のSQLコマンドを実行し、テーブルのデータに反映する
                editTableData(sqlCommand);

                // テーブルのデータを全てメンバ変数のリストに格納する
                listFromTableData();

                // メンバ変数のListデータをリストボックスに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // テキストボックスを空白にする
            this.textBox_Name.Text = string.Empty;
        }

        /// <summary>
        /// リストボックスの名前を選択したら、テキストボックスにその名前を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            // リストボックスの名前を選択したとき
            if (this.listBox_Names.SelectedIndices.Count != 0)
            {
                this.textBox_Name.Text = this.listBox_Names.SelectedItem.ToString();
            }
        }

        /// <summary>
        /// ボタンを押したら、リストボックスで選択した行のデータを更新して
        /// 再度リストビューに表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Update_Click(object sender, EventArgs e)
        {
            // リストボックスで選択された項目が無ければメッセージボックスを表示
            if (this.listBox_Names.SelectedIndices.Count == 0)
            {
                MessageBox.Show("更新する名前を選択してください。");
                return;
            }

            try
            {
                int index = this.listBox_Names.SelectedIndices[0];

                string nameText = this.textBox_Name.Text;

                // テーブルのデータを更新
                string sqlCommand = @"
                                    UPDATE
						              STUDENT_TABLE
                                    SET
									  STUDENT_NAME = '" + nameText + "'" +
                               " WHERE STUDENT_ID = " + this.list[index][0] +
                                ";";

                // 引数のSQLコマンドを実行し、テーブルのデータに反映する
                editTableData(sqlCommand);

                // テーブルのデータを全てメンバ変数のリストに格納する
                listFromTableData();

                // テーブルのデータを全てメンバ変数のリストに格納する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.textBox_Name.Text = string.Empty;
        }

        /// <summary>
        /// ボタンを押したら、リストボックスで選択した箇所を
        /// テーブルから削除して、テーブルデータを
        /// リスボックスに再表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Delete_Click(object sender, EventArgs e)
        {
            // リストビューで選択された項目が無ければメッセージボックスを表示
            if (this.listBox_Names.SelectedIndices.Count == 0)
            {
                MessageBox.Show("削除する名前を選択してください。");
                return;
            }

            try
            {
                int index = this.listBox_Names.SelectedIndices[0];

                string nameText = this.textBox_Name.Text;

                // 選択した項目のDELETEDを1に更新
                string sqlCommand = @"
                                    UPDATE
						              STUDENT_TABLE
                                    SET
									  DELETED = 1
                                 WHERE STUDENT_ID = " + this.list[index][0] +
                                ";";

                // 引数のSQLコマンドを実行し、テーブルのデータに反映する
                editTableData(sqlCommand);

                // 選択した項目のDELETEDを1に更新
                sqlCommand = @"
                                    UPDATE
						              RESULT_TABLE
                                    SET
									  DELETED = 1
                                 WHERE STUDENT_ID = " + this.list[index][0] +
                             ";";

                // 引数のSQLコマンドを実行し、テーブルのデータに反映する
                editTableData(sqlCommand);

                // テーブルのデータを全てメンバ変数のリストに格納する
                listFromTableData();

                // メンバ変数のListデータをリストボックスに表示する
                displayListData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.textBox_Name.Text = string.Empty;
        }

        /// <summary>
        /// 引数のSQLコマンドを実行し、テーブルのデータに反映する
        /// </summary>
        /// <param name="sqlCommand">SQLテキスト</param>
        private void editTableData(string sqlCommand)
        {
            string dbFile = Application.StartupPath + @"\results2.db";
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
        /// テーブルのデータをメンバ変数のリストに格納する
        /// </summary>
        private void listFromTableData()
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

                // DELETEDが0のテーブルのデータを表示する
                com.CommandText = @"SELECT R.STUDENT_ID, R.STUDENT_NAME FROM STUDENT_TABLE AS R 
                                    JOIN STUDENT_TABLE AS S ON R.STUDENT_ID = S.STUDENT_ID AND R.DELETED = 0;";
                reader = com.ExecuteReader();

                this.list.Clear();

                while (reader.Read())
                {
                    string[] s ={
                                   reader["STUDENT_ID"].ToString(),
                                   reader["STUDENT_NAME"].ToString(),
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
        /// メンバ変数のListデータをリストボックスに表示する
        /// </summary>
        private void displayListData()
        {
            this.listBox_Names.Items.Clear();
            for (int i = 0; i < this.list.Count; i++)
            {
                this.listBox_Names.Items.Add(this.list[i][1]);
            }
        }

        /// <summary>
        /// ボタンを押したら、Magementフォームを閉じる
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}

