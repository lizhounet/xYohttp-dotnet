using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Common.Constant
{
    /// <summary>
    /// xyo 消息回调事件名
    /// </summary>
    public class XyoEventConstant
    {
        /// <summary>
        /// 新的账号登录成功/下线
        /// </summary>
        public const string Login = "Login";
        /// <summary>
        /// 群消息事件
        /// </summary>
        public const string EventGroupChat = "EventGroupChat";
        /// <summary>
        /// 私聊消息事件
        /// </summary>
        public const string EventPrivateChat = "EventPrivateChat";
        /// <summary>
        /// 设备回调事件
        /// </summary>
        public const string EventDeviceCallback = "EventDeviceCallback";
        /// <summary>
        /// 好友请求事件
        /// </summary>
        public const string EventFrieneVerify = "EventFrieneVerify";
        /// <summary>
        /// 群名称变动事件
        /// </summary>
        public const string EventGroupNameChange = "EventGroupNameChange";
        /// <summary>
        /// 群成员增加事件 PS: 新人进群
        /// </summary>
        public const string EventGroupMemberAdd = "EventGroupMemberAdd";
        /// <summary>
        /// 群成员减少事件 PS: 群成员退出
        /// </summary>
        public const string EventGroupMemberDecrease = "EventGroupMemberDecrease";
        /// <summary>
        /// 被邀请入群事件 PS: 企业微信不传递此事件
        /// </summary>
        public const string EventInvitedInGroup = "EventInvitedInGroup";
        /// <summary>
        /// 面对面收款事件
        /// </summary>
        public const string EventQRcodePayment = "EventQRcodePayment";
        /// <summary>
        /// 文件下载结束事件
        /// </summary>
        public const string EventDownloadFile = "EventDownloadFile";
        /// <summary>
        /// 创建新的群聊事件，企业微信不传递此事件
        /// </summary>
        public const string EventGroupEstablish = "EventGroupEstablish";
    }
}
