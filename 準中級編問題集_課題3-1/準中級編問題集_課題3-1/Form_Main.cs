using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 準中級編問題集_課題3_1
{
    /// <summary>
    /// 成績データが記録されているresults.csvファイルを読み込み、ListViewに成績一覧を
    /// 表示する。成績は合計点数の高い順序で並べる
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押したら、リストビューに名前と各科目の点数、合計点を表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Display_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Public\Documents\results.csv";

            try
            {
                // ファイルを読み込んでListデータにする
                List<string[]> list = readFile(filePath);

                // 国語・数学・英語の3科目の合計を足して合計を求め、リストに追加する
                List<string[]> listTotal = caluculationTotal(list);

                // 合計点の高い順にリストを並び替える
                List<string[]> listSort = sortList(listTotal);

                // リストのデータを表示する
                display(listSort);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ファイルを読み込んでListに保存する
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <returns>ファイルを読み込んだデータ</returns>
        private List<string[]> readFile(string filePath)
        {
            List<string[]> list = new List<string[]>();

            StreamReader sr = null;

            try
            {
                sr = new StreamReader(filePath, Encoding.Default);

                while (-1 < sr.Peek())
                {
                    string[] arrayAll = new string[5];

                    string[] array = sr.ReadLine().Split(',');
                    arrayAll[0] = array[0];
                    arrayAll[1] = array[1];
                    arrayAll[2] = array[2];
                    arrayAll[3] = array[3];

                    arrayAll[4] = "x";
                    list.Add(arrayAll);
                }
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return list;
        }

        /// <summary>
        /// 3科目の合計値を求めて、リストの列に追加して返す
        /// </summary>
        /// <param name="list">リスト配列データ</param>
        /// <returns>合計値の列を追加したデータ</returns>
        private List<string[]> caluculationTotal(List<string[]> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int total = int.Parse(list[i][1]) + int.Parse(list[i][2]) + int.Parse(list[i][3]);
                list[i][4] = total.ToString();
            }

            return list;
        }

        /// <summary>
        /// 合計点の高い順番に並べ替える
        /// </summary>
        /// <param name="list">リスト配列データ</param>
        /// <returns>並べ変えた後のデータ</returns>
        private List<string[]> sortList(List<string[]> list)
        {
            return list.OrderByDescending(x => x[4]).ToList();
        }

        /// <summary>
        /// Listのデータをリストビューに表示する
        /// </summary>
        /// <param name="list">List配列データ</param>
        private void display(List<string[]> list)
        {
            this.listView_Display.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                string[] s = list[i];
                ListViewItem item = new ListViewItem(s);
                this.listView_Display.Items.Add(item);
            }
        }
    }
}
