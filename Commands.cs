using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BERT
{
    public class Commands
    {
        public static string GetVersion(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "version");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][0];
            }
            else
            {
                return "NG";
            }
        }
        public static string GetMac(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "mac");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][0];
            }
            else
            {
                return "NG";
            }
        }

        public static List<string> GetResult(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, string.Format("result {0}", ch));
            if (reply.Result == CommandCode.OK)
            {
                // 各計測値が要素に入ってます。
                // サンプルなのでList<string>で返してますが数値などに変換して使ってください
                return reply.Data[0].ToList();
            }
            else
            {
                return null;
            }
        }

        public static string SetBitrate(BertPortBase port, string br)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "bitrate " + br);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                throw new Exception();
                //return "NG";
            }
        }
        public static string GetBitrate(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "bitrate");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][0];
            }
            else
            {
                throw new Exception();
                //return "NG";
            }
        }

        public static string SetTrigger(BertPortBase port, string trg)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "trigger " + trg);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }

        public static string GetTrigger(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "trigger");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][0];
            }
            else
            {
                return "NG";
            }
        }

        public static string SetPPG(BertPortBase port, int ch, int flg)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ppg " + ch.ToString() + " " + flg.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string GetPPG(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ppg " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の2つめなので0-0
                if (reply.Data.Count == 0)
                {
                    return "NG";
                }

                return reply.Data[0][1];
            }
            else
            {
                return "NG";
            }
        }
        public static string SetEd(BertPortBase port, int ch, int flg)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ed " + ch.ToString() + " " + flg.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string GetEd(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ed " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][1];
            }
            else
            {
                return "NG";
            }
        }
        public static string SetReSyncMode(BertPortBase port, int ch, String mode)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "resyncmode " + ch.ToString() + " " + mode);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string GetReSyncMode(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "resyncmode " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][1];
            }
            else
            {
                return "NG";
            }
        }
        public static string ReSync(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "resync " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string SetPpgPat(BertPortBase port, int ch, string pat, string len)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ppgpat " + ch.ToString() + " " + pat + " " + len);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string GetPpgPat(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ppgpat " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][1];
            }
            else
            {
                return "NG";
            }
        }
        public static string SetEdPat(BertPortBase port, int ch, string pat)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "edpat " + ch.ToString() + " " + pat);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string GetEdPat(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "edpat " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][1];
            }
            else
            {
                return "NG";
            }
        }

        public static string SetPrgPat(BertPortBase port, int lineno, string[] sptext)
        {

            int ch = 0;

            if (lineno == 1)
            {
                ch = 1;
            }
            else if(lineno == 2)
            {
                ch = 2;
            }
            else if (lineno == 3)
            {
                ch = 1;
            }
            else if (lineno == 4)
            {
                ch = 2;
            }
            else 
            {
                return "NG";
            }


            CommandReply reply;
            for (int i = 1; i < 9; i++)
            {
                reply = CommandManager.GetInstance().Execute(port, "ppgprgpat " + ch.ToString() + " " + i.ToString() + " " + sptext[i] );
                if (reply.Result != CommandCode.OK)
                {
                    return reply.Data[0][1];
                }
                reply = CommandManager.GetInstance().Execute(port, "edprgpat " + ch.ToString() + " " + i.ToString() + " " + sptext[i]);
                if (reply.Result != CommandCode.OK)
                {
                    return reply.Data[0][1];
                }
            }
            return "OK";
        }

        public static string ResetFlag(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "resetflag " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }
        public static string ResetCount(BertPortBase port, int ch)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "resetcount " + ch.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }

        public static string SetDHCP(BertPortBase port, int flag)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "dhcp " + flag.ToString());
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";
            }
        }

        public static string GetDHCP(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "dhcp");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の1つめなので0-0
                return reply.Data[0][0];
            }
            else
            {
                return "NG";
            }
        }

        public static string IPSet(BertPortBase port, string ip_addr, string ip_mask, string gw_addr)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ip " + ip_addr + " " + ip_mask + " " + gw_addr);
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";

            }
        }

        public static List<string> IPGet(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "net");
            if (reply.Result == CommandCode.OK)
            {
                // 各計測値が要素に入ってます。
                // サンプルなのでList<string>で返してますが数値などに変換して使ってください
                return reply.Data[0].ToList();
            }
            else
            {
                return new List<string>();
            }
        }

        public static string Reset(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "reset");
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";

            }
        }

        public static string Save(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "save");
            if (reply.Result == CommandCode.OK)
            {
                // 戻り値なし
                return "OK";
            }
            else
            {
                return "NG";

            }
        }

        public static string GetCH(BertPortBase port)
        {
            CommandReply reply = CommandManager.GetInstance().Execute(port, "ch");
            if (reply.Result == CommandCode.OK)
            {
                // 応答1行目の2つめなので0-0
                if (reply.Data.Count == 0)
                {
                    return "NG";
                }

                return reply.Data[0][0];
            }
            else
            {
                return "NG";
            }
        }
    }
}