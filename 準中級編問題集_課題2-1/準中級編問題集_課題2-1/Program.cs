using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace 準中級編問題集_課題2_1
{
    /// <summary>
    /// cats.csvファイルを読み込み、内容を表示する
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\Public\Documents\cats.csv";

            try
            {
                // ファイルのデータを表示する
                Console.Write(readFile(filePath));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// ファイルを読み込んだデータを返す
        /// </summary>
        /// <param name="filePath">ファイルパス</param>
        /// <returns>読み込んだデータ</returns>
        private static string readFile(string filePath)
        {
            StreamReader sr = null;

            string text = string.Empty;

            try
            {
                sr = new StreamReader(filePath, Encoding.Default);

                text = sr.ReadToEnd();
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }

            return text;
        }
    }
}
