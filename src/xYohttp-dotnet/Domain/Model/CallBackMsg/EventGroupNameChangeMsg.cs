using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 群名称变动 消息
    /// </summary>
    public class EventGroupNameChangeMsg
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
        [JsonProperty("new_name")]
        public string? NewName { get; set; }
        /// <summary>
        ///  旧群名
        /// </summary>
        [JsonProperty("old_name")]
        public string? OldName { get; set; }
        /// <summary>
        ///  操作者昵称
        /// </summary>
        [JsonProperty("from_name")]
        public string? FromName { get; set; }
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
