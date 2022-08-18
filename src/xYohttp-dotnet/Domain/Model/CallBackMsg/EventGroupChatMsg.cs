using Newtonsoft.Json;
using System.Collections.Generic;
using xYohttp_dotnet.Common.Enums;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 群消息
    /// </summary>
    public class EventGroupChatMsg
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
        /// 来源群号
        /// </summary>
        [JsonProperty("from_group")]
        public string? FromGroup { get; set; }
        /// <summary>
        /// 来源群名称
        /// </summary>
        [JsonProperty("from_group_name")]
        public string? FromGroupName { get; set; }
        /// <summary>
        /// 具体发消息的群成员id
        /// </summary>
        [JsonProperty("from_wxid")]
        public string? FromWxId { set; get; }
        /// <summary>
        /// 具体发消息的群成员昵称
        /// </summary>
        [JsonProperty("from_name")]
        public string? FromName { set; get; }
        /// <summary>
        /// 消息内容
        /// </summary>
        [JsonProperty("msg")]
        public string? Msg { set; get; }
        /// <summary>
        /// 附带JSON属性（群消息有艾特人员时，返回被艾特信息）
        /// </summary>
        [JsonProperty("msg_source")]
        public MsgSource? MsgSource { set; get; }
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
    /// <summary>
    /// 附带JSON属性（群消息有艾特人员时，返回被艾特信息）
    /// </summary>
    public class MsgSource {
        /// <summary>
        /// 被艾特的用户信息
        /// </summary>
        [JsonProperty("atuserlist")]
        public List<AtUserList> AtUserLists { set; get; }=new List<AtUserList>();
        public class AtUserList {
            /// <summary>
            /// 被艾特的用户微信id
            /// </summary>
            [JsonProperty("wxid")]
            public string? WxId { get; set; }
            /// <summary>
            /// 被艾特的用户昵称 前面带@
            /// </summary>
            [JsonProperty("nickname")]
            public string? Nickname { get; set; }
            [JsonProperty("position_from")]
            public int? PositionFrom { set; get; }
            [JsonProperty("position_to")]
            public int? PositionTo { set; get; }
        }


    }
}
