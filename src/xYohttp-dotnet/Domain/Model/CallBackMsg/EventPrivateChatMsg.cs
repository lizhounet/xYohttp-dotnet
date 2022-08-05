using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using xYohttp_dotnet.Common.Enums;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 私聊消息
    /// </summary>
    public class EventPrivateChatMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        /// 消息类型
        /// </summary>
        [JsonProperty("type")]
        public EMsgType Type { get; set; }
        /// <summary>
        /// 来源用户ID
        /// </summary>
        [JsonProperty("from_wxid")]
        public string? FromWxId { get; set; }
        /// <summary>
        /// 来源用户昵称
        /// </summary>
        [JsonProperty("from_name")]
        public string? FromName { get; set; }
        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("msg")]
        public string? Msg { set; get; }
        /// <summary>
        /// 企业微信可用
        /// </summary>
        [JsonProperty("clientid")]
        public int? ClientId { set; get; }
        /// <summary>
        /// 来源微信类型 0 正常微信 / 1 企业微信
        /// </summary>
        [JsonProperty("robot_type")]
        public int? RobotType { set; get; }
        /// <summary>
        /// 消息ID
        /// </summary>
        [JsonProperty("msg_id")]
        public string? MsgId { set; get; }

    }
}
