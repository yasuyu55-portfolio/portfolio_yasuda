using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 準中級編_課題1_4
{
    /// <summary>
    /// Personクラスを定義
    /// 名前と年齢のデータをサブフォームからメインフォームに渡す
    /// </summary>
    public class Person
    {
        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string name = string.Empty;
        /// <summary>
        /// nameのプロパティを宣言
        /// </summary>
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }

        /// <summary>
        /// string型の変数を初期化して宣言
        /// </summary>
        private string age = string.Empty;
        /// <summary>
        /// ageのプロパティを宣言
        /// </summary>
        public string Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }
    }
}
