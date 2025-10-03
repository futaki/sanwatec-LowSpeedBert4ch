using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERT
{
    public class CommandReply
    {
        private List<string[]> data = new List<string[]>();

        /// <summary>
        /// コマンド結果
        /// </summary>
        public int Result { get; set; }

        /// <summary>
        /// コマンドデータの追加
        /// </summary>
        /// <param name="data">応答文字列</param>
        public void AddData(string[] data)
        {
            string[] add = new string[data.Length];
            Array.Copy(data, add, data.Length);
            this.data.Add(add);
        }

        /// <summary>
        /// コマンドデータ
        /// </summary>
        public List<string[]> Data
        {
            get
            {
                return this.data;
            }
        }

        /// <summary>
        /// 文字列を取得します
        /// </summary>
        /// <returns>結果文字列</returns>
        public new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Result.ToString());
            sb.Append(":");

            foreach (string[] sArray in this.data)
            {
                foreach (string s in sArray)
                {
                    sb.Append(" ");
                    sb.Append(s);
                }
                sb.Append(":::");
            }
            return sb.ToString();
        }
    }
}
