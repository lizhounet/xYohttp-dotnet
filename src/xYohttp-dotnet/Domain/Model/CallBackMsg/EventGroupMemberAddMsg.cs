using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 群成员增加 消息
    /// </summary>
    public class EventGroupMemberAddMsg
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
        ///  新人
        /// </summary>
        [JsonProperty("guest")]
        public List<Guest> Guests { get; set; } = new List<Guest>();
        /// <summary>
        ///  邀请者
        /// </summary>
        [JsonProperty("inviter")]
        public List<Inviter> Inviters { get; set; } = new List<Inviter>();
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
        /// 新人
        /// </summary>
        public class Guest
        {
            [JsonProperty("wxid")]
            public string? WxId { get; set; }
            [JsonProperty("username")]
            public string? UserName { get; set; }
        }
        /// <summary>
        /// 邀请者
        /// </summary>
        public class Inviter
        {
            [JsonProperty("wxid")]
            public string? WxId { get; set; }
            [JsonProperty("username")]
            public string? UserName { get; set; }
        }
    }
}
