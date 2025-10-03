using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BERT
{
    internal class CmdPerse
    {

        public BertSerialPort CmdIF = new BertSerialPort();


        // ビットレートの設定
        public async void Bitrate(int iface, String brate)
        {
            String ret = "";

            if (iface == 0)
            {
                CmdIF.Send("bitrate" + " " + brate);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // トリガー出力の選択
        public async void Trigger(int iface, String trig)
        {
            String ret = "";

            if (iface == 0)
            {
                CmdIF.Send("trigger" + " " + trig);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // PPGの出力ON/OFF
        public async void Ppg(int iface, int ch, int flg)
        {
            String ret = "";
            String sch = ch.ToString();
            String sflg = flg.ToString();

            if (iface == 0)
            {
                CmdIF.Send("ppg" + " " + sch + " " + sflg);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // PPGパターン設定
        public async void Ppgpat(int iface, int ch, String pat)
        {
            String ret = "";
            String sch = ch.ToString();

            if (iface == 0)
            {
                CmdIF.Send("ppg" + " " + sch + " " + pat);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // エラー付加
        public async void Adde(int iface, int ch, int flg)
        {
            String ret = "";
            String sch = ch.ToString();
            String sflg = flg.ToString();

            if (iface == 0)
            {
                CmdIF.Send("adde" + " " + sch + " " + sflg);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // 測定開始/停止
        public async void Ed(int iface, int ch, int flg)
        {
            String ret = "";
            String sch = ch.ToString();
            String sflg = flg.ToString();

            if (iface == 0)
            {
                CmdIF.Send("ed" + " " + sch + " " + sflg);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // 再同期
        public async void Resync(int iface, int ch)
        {
            String ret = "";
            String sch = ch.ToString();

            if (iface == 0)
            {
                CmdIF.Send("ed" + " " + sch);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // 再同期モード
        public async void Resyncmode(int iface, int ch, String mode)
        {
            String ret = "";
            String sch = ch.ToString();

            if (iface == 0)
            {
                CmdIF.Send("resyncmode" + " " + sch + " " + mode);

                await Task.Run(() => ret = CmdIF.Read());

            }

        }

        // カウンタリセット
        public async void Resetcount(int iface, int ch)
        {
            String ret = "";
            String sch = ch.ToString();

            if (iface == 0)
            {
                CmdIF.Send("resetcount" + " " + sch);

                await Task.Run(() => ret = CmdIF.Read());

            }


        }

        // フラグリセット
        public async void Resetflag(int iface, int ch)
        {
            String ret = "";
            String sch = ch.ToString();

            if (iface == 0)
            {
                CmdIF.Send("resetflag" + " " + sch);

                await Task.Run(() => ret = CmdIF.Read());

            }


        }

        // EDパターン設定
        public async void Edpat(int iface, int ch, String pat)
        {
            String ret = "";
            String sch = ch.ToString();
            String spat = pat.ToString();

            if (iface == 0)
            {
                CmdIF.Send("edpat" + " " + sch + " " + spat);

                await Task.Run(() => ret = CmdIF.Read());

            }
        }

        // 測定値のリード
        public async void Result(int iface, int ch)
        {
                String ret = "";
                String sch = ch.ToString();

                if (iface == 0)
                {
                    CmdIF.Send("result" + " " + sch);

                    await Task.Run(() => ret = CmdIF.Read());

                }


        }

        // DHCPのON/OFF設定
        public async void Dhcp(int iface, int flg)
        {
            String ret = "";
            String sflg = flg.ToString();

            if (iface == 0)
            {
                CmdIF.Send("dhcp" + " " + sflg);

                await Task.Run(() => ret = CmdIF.Read());

            }


        }

        // 静的IPアドレス設定
        public async void ip(String ip, String mask, String gate)
        {
            String ret = "";

            CmdIF.Send("ip" + ip + " " + mask + " " + gate);

            await Task.Run(() => ret = CmdIF.Read());

        }

        // IPアドレスの取得
        public async void net()
        {
            String ret = "";

            CmdIF.Send("net");

            await Task.Run(() => ret = CmdIF.Read());

        }

        // FWバージョンの取得
        public async void CmdVer()
        {
            String ver = "";

            CmdIF.Send("version");

            await Task.Run(() => ver = CmdIF.Read());
        }


    }

}