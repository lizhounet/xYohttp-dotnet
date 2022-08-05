using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 群成员减少 消息
    /// </summary>
    public class EventGroupMemberDecreaseMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        ///  群号
        /// </summary>
        [JsonProperty("from_group")]
        public string? FromGroup { get; set; }
        /// <summary>
        ///  新群名
        /// </summary>
        [JsonProperty("from_group_name")]
        public string? FromGroupName { get; set; }
        /// <summary>
        /// 被操作者wxid
        /// </summary>
        [JsonProperty("to_wxid")]
        public string? ToWxid { set; get; }
        /// <summary>
        /// 被操作者昵称
        /// </summary>
        [JsonProperty("to_name")]
        public string? ToName { set; get; }
        /// <summary>
        /// 操作时间
        /// </summary>
        [JsonProperty("time")]
        public string? Time { set; get; }
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
    }
}
