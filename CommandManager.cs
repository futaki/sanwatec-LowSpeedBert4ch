using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BERT
{
    /// <summary>
    /// コマンドマネージャクラス
    /// </summary>
    public class CommandManager
    {
        private char splitter = ' ';
        private char connector = '=';
        private string replyOK = "OK";
        private string replyNG = "NG";
        private static readonly CommandManager instance = new CommandManager();

        /// <summary>
        /// データのスプリッタ
        /// </summary>
        public char Splitter
        {
            set { this.splitter = value; }
            get { return this.splitter; }
        }

        /// <summary>
        /// データとヘッダのコネクタ
        /// </summary>
        public char Connector
        {
            set { this.connector = value; }
            get { return this.connector; }
        }

        /// <summary>
        /// 成功文字列
        /// </summary>
        public string ReplyOK
        {
            set { this.replyOK = value; }
        }

        /// <summary>
        /// 失敗文字列
        /// </summary>
        public string ReplyNG
        {
            set { this.replyNG = value; }
        }

        /// <summary>
        /// インスタンスを取得します。
        /// </summary>
        /// <returns>インスタンス</returns>
        public static CommandManager GetInstance()
        {
            return instance;
        }

        /// <summary>
        /// コマンドを実行します。
        /// </summary>
        /// <param name="port">COMポート</param>
        /// <param name="command">コマンド文字列</param>
        /// <returns>コマンド応答</returns>
        public CommandReply Execute(BertPortBase port, string command)
        {
            CommandReply ret = new CommandReply
            {
                Result = CommandCode.OK
            };

            //if (!port.IsOpen)
            //{
            //    port.Open();
            //}

            try
            {
                if (port.IsOpen)
                {
                    //lock (port)
                    {
                        port.WriteLine(command);
                        bool wait = true;

                        while (wait)
                        {
                            //Thread.Sleep(50);
                                string read = port.ReadLine();
                                if (read.Equals(this.replyOK))
                                {
                                    wait = false;
                                }
                                else
                                {
                                    string[] rets = read.Split(this.splitter);
                                    if (rets.Length == 2 && rets[0].Equals(this.replyNG))
                                    {
                                        wait = false;
                                        try
                                        {
                                            ret.Result = int.Parse(rets[1]);
                                        }
                                        catch (FormatException)
                                        {
                                            ret.Result = CommandCode.ERROR_FORMAT;
                                        }
                                    }                                    else if (rets[0].IndexOf(this.connector, 0) >= 0)
                                    {
                                        StringBuilder sb = new StringBuilder(command.Split(this.splitter)[0]);
                                        sb.Append(this.connector);
                                        string data = rets[0].Replace(sb.ToString(), "");
                                        rets[0] = data;
                                        ret.AddData(rets);
                                    }
                                }
                            }
                        }
                    }
                else
                {
                    ret.Result = CommandCode.ERROR_COMM;
                }
            }
            //catch(TimeoutException)
            catch (Exception)
            {
                ret.Result = CommandCode.ERROR_TIMEOUT;
            }

            return ret;
        }

        /// <summary>
        /// 指定文字列を待ち続けます
        /// </summary>
        /// <param name="port">ポート</param>
        /// <param name="waitTag">指定文字列</param>
        /// <param name="timeoutCount">タイムアウト秒</param>
        /// <returns>true:指定文字列を確認、false:未確認</returns>
        public bool WaitString(BertPortBase port, string waitTag, int timeoutCount)
        {
            bool ret = false;
            try
            {
                if (port.IsOpen)
                {
                    bool wait = true;
                    int count = 0;
                    while (wait)
                    {
                        try
                        {
                            string read = port.ReadLine();
                            if (read.Equals(waitTag))
                            {
                                wait = false;
                                ret = true;
                            }
                        }
                        catch (TimeoutException)
                        {
                            count++;
                        }
                        if (count >= timeoutCount)
                        {
                            wait = false;
                        }
                    }
                }
            }
            catch (Exception) { }
            return ret;
        }

    }
}
