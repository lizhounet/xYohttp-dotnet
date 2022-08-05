using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Common.Enums
{
    /// <summary>
    /// 消息类型
    /// </summary>
    public enum EMsgType
    {
        文本 = 1,
        图片消息 = 3,
        语音消息 = 34,
        好友验证 = 37,
        名片推荐 = 42,
        视频消息 = 43,
        动态表情 = 47,
        位置消息 = 48,
        分享链接 = 49,
        转账消息 = 2000,
        红包消息 = 2001,
        小程序 = 2002,
        群邀请 = 2003,
        接收文件 = 2004,
        撤回消息 = 2005,
        系统消息 = 10000,
        服务通知 = 10002,
    }
}
