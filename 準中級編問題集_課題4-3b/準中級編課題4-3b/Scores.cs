using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 準中級編課題4_3b
{
    /// <summary>
    /// Scoresクラスを定義
    /// </summary>
    public class Scores
    {
        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string nameScore = string.Empty;

        /// <summary>
        /// nameTextのプロパティを宣言
        /// </summary>
        public string Name
        {
            set
            {
                this.nameScore = value;
            }
            get
            {
                return this.nameScore;
            }
        }

        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string japaneseScore = string.Empty;

        /// <summary>
        /// Japaneseのプロパティを宣言
        /// </summary>
        public string Japanese
        {
            set
            {
                this.japaneseScore = value;
            }
            get
            {
                return this.japaneseScore;
            }
        }

        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string mathScore = string.Empty;

        /// <summary>
        /// Mathのプロパティを宣言
        /// </summary>
        public string Math
        {
            set
            {
                this.mathScore = value;
            }
            get
            {
                return this.mathScore;
            }
        }

        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string englishScore = string.Empty;

        /// <summary>
        /// Englishのプロパティを宣言
        /// </summary>
        public string English
        {
            set
            {
                this.englishScore = value;
            }
            get
            {
                return this.englishScore;
            }
        }
    }
}
