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

namespace 準中級編問題集_課題3_2
{
    /// <summary>
    /// 成績データが記録されているresults.csvファイルを読み込み、ListViewに成績一覧を表示する
    /// 各成績は点数の高い順序で表示する
    /// </summary>
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタンを押したら、３つのリストビューにデータを表示する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Display_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\Public\Documents\results.csv";

            try
            {
                // ファイルのデータを読み込んでListに保存する
                List<string[]> list = readFile(filePath);

                // リストのデータから名前と国語の点数を抜き出す
                List<string[]> list_Japanese = selectList(list, 1);

                // リストのデータから名前と数学の点数を抜き出す
                List<string[]> list_Math = selectList(list, 2);

                // リストのデータから名前と英語の点数を抜き出す
                List<string[]> list_English = selectList(list, 3);

                // 国語の点数を高い順番に並べ替える
                List<string[]> sort_Japanese = sort(list_Japanese);

                // 数学の点数を高い順番に並べ替える
                List<string[]> sort_Math = sort(list_Math);

                // 英語の点数を高い順番に並べ替える
                List<string[]> sort_English = sort(list_English);

                // リストビューに国語の成績データを表示
                display(sort_Japanese, listView_Jpananese);

                // リストビューに数学の成績データを表示
                display(sort_Math, listView_Math);

                // リストビューに英語の成績データを表示
                display(sort_English, listView_English);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        /// <summary>
        /// リストのデータを点数の高い順に上から並べる
        /// </summary>
        /// <param name="list">string[]型のList</param>
        /// <returns>並べた後のstring[]型のList</returns>
        private List<string[]> sort(List<string[]> list)
        {
            return list.OrderByDescending(x => x[1]).ToList();
        }

        /// <summary>
        /// ファイルを読み込んでデータをリストに格納
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
                    string[] array = sr.ReadLine().Split(',');
                    list.Add(array);
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
        /// 全体データから名前と選択した科目の点数を抜き出す
        /// </summary>
        /// <param name="list">全体データ</param>
        /// <param name="j">科目の列番号</param>
        /// <returns>抜き出したList配列データ</returns>
        private List<string[]> selectList(List<string[]> list, int j)
        {
            List<string[]> listSubject = new List<string[]>();

            for (int i = 0; i < list.Count; i++)
            {
                string[] array = new string[2];
                array[0] = list[i][0];

                // 引数jで国語(1)・数学(2)・英語(3)の列を選択する
                array[1] = list[i][j];
                listSubject.Add(array);
            }

            return listSubject;
        }

        /// <summary>
        /// Listのデータをリストビューに表示する
        /// </summary>
        /// <param name="list">Listのデータ</param>
        /// <param name="lv">リストビュー</param>
        private void display(List<string[]> list, ListView lv)
        {
            lv.Items.Clear();

            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem item = new ListViewItem(list[i]);
                lv.Items.Add(item);
            }
        }
    }
}
