using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.Dto
{
    /// <summary>
    /// httpApi功能配置 DTO
    /// </summary>
    public class XyoCfgInfoDto
    {
        /// <summary>
        /// 基础配置
        /// </summary>
        [JsonProperty("basicCfg")]
        public BasicCfg BasicCfg { get; set; }

        /// <summary>
        /// HTTP配置
        /// </summary>
        [JsonProperty("HTTPCfg")]
        public HttpCfg HttpCfg { get; set; }

        /// <summary>
        /// 消息回调事件配置
        /// </summary>
        [JsonProperty("msgCallback")]
        public MsgCallback MsgCallback { get; set; }

        /// <summary>
        /// WebSocket配置
        /// </summary>
        [JsonProperty("WebSocketCfg")]
        public WebSocketCfg WebSocketCfg { get; set; }
    }
    /// <summary>
    /// 基础配置
    /// </summary>
    public partial class BasicCfg
    {
        /// <summary>
        /// 自动开启服务
        /// </summary>
        [JsonProperty("auto-on")]
        public bool AutoOn { get; set; }

        /// <summary>
        /// 调试模式
        /// </summary>
        [JsonProperty("debug")]
        public bool Debug { get; set; }

        /// <summary>
        /// IP白名单
        /// </summary>
        [JsonProperty("ipWhitelist")]
        public List<string> IpWhitelist { get; set; }=new List<string>();
    }

    /// <summary>
    /// HTTP配置
    /// </summary>
    public partial class HttpCfg
    {
        /// <summary>
        /// API调用
        /// </summary>
        [JsonProperty("APICall")]
        public bool ApiCall { get; set; }

        /// <summary>
        /// 补全必要协议头
        /// </summary>
        [JsonProperty("AutoRequestHeaders")]
        public bool AutoRequestHeaders { get; set; }

        /// <summary>
        /// 消息回调
        /// </summary>
        [JsonProperty("msgCallback")]
        public bool MsgCallback { get; set; }

        /// <summary>
        /// 消息回调地址
        /// </summary>
        [JsonProperty("msgCallback_link")]
        public List<string> MsgCallbackLink { get; set; }=new List<string>();
    }

    /// <summary>
    /// 消息回调事件配置
    /// </summary>
    public partial class MsgCallback
    {
        /// <summary>
        /// 设备回调事件
        /// </summary>
        [JsonProperty("EventDeviceCallback")]
        public bool EventDeviceCallback { get; set; }

        /// <summary>
        /// 好友请求事件
        /// </summary>
        [JsonProperty("EventFrieneVerify")]
        public bool EventFrieneVerify { get; set; }

        /// <summary>
        /// 群消息事件
        /// </summary>
        [JsonProperty("EventGroupChat")]
        public bool EventGroupChat { get; set; }

        /// <summary>
        /// 创建新的群聊事件（企业微信不传递此事件）
        /// </summary>
        [JsonProperty("EventGroupEstablish")]
        public bool EventGroupEstablish { get; set; }

        /// <summary>
        /// 群成员增加事件
        /// </summary>
        [JsonProperty("EventGroupMemberAdd")]
        public bool EventGroupMemberAdd { get; set; }

        /// <summary>
        /// 群成员减少事件
        /// </summary>
        [JsonProperty("EventGroupMemberDecrease")]
        public bool EventGroupMemberDecrease { get; set; }

        /// <summary>
        /// 群名称变动事件
        /// </summary>
        [JsonProperty("EventGroupNameChange")]
        public bool EventGroupNameChange { get; set; }

        /// <summary>
        /// 被邀请入群事件
        /// </summary>
        [JsonProperty("EventInvitedInGroup")]
        public bool EventInvitedInGroup { get; set; }

        /// <summary>
        /// 私聊消息事件
        /// </summary>
        [JsonProperty("EventPrivateChat")]
        public bool EventPrivateChat { get; set; }

        /// <summary>
        /// 面对面收款事件
        /// </summary>
        [JsonProperty("EventQRcodePayment")]
        public bool EventQRcodePayment { get; set; }

        /// <summary>
        /// 新的账号登录成功/下线
        /// </summary>
        [JsonProperty("Login")]
        public bool Login { get; set; }
    }

    /// <summary>
    /// WebSocket配置
    /// </summary>
    public partial class WebSocketCfg
    {
        /// <summary>
        /// API调用
        /// </summary>
        [JsonProperty("APICall")]
        public bool ApiCall { get; set; }

        /// <summary>
        /// 消息回调
        /// </summary>
        [JsonProperty("msgCallback")]
        public bool MsgCallback { get; set; }
    }
}
