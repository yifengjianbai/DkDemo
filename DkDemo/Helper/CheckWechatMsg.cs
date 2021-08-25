using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DkDemo.Helper
{
    public static class CheckWechatMsg
    {
        //公众平台上开发者设置的token, appID, EncodingAESKey
        public static string sToken = "yifengjianbai";
        public static string sAppID = "wx8c92b24a2eb09500";
        public static string sEncodingAESKey = "c04cde781a664d965e9784e5853ea350";

        public static string Action(string signature, string timestamp, string nonce, string echostr)
        {
            //Tencent.WXBizMsgCrypt wxcpt = new Tencent.WXBizMsgCrypt(sToken, sEncodingAESKey, sAppID);
            return echostr;
        }
    }
}
