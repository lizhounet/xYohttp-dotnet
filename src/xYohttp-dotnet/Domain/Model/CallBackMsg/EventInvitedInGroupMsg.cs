using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 被邀请入群 消息 
    /// </summary>
    public class EventInvitedInGroupMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        ///  邀请机器人入群的id
        /// </summary>
        [JsonProperty("from_wxid")]
        public string? FromWxId { get; set; }
        /// <summary>
        ///  入群消息
        /// </summary>
        [JsonProperty("from_wxid")]
        public InvitedInGroupMsg? Msg { get; set; }
        /// <summary>
        /// 来源微信类型 0 正常微信 / 1 企业微信
        /// </summary>
        [JsonProperty("robot_type")]
        public int? RobotType { set; get; }

        public class InvitedInGroupMsg
        {
            /// <summary>
            ///  inviter_wxid
            /// </summary>
            [JsonProperty("inviter_wxid")]
            public string? InviterWxId { get; set; }
            /// <summary>
            ///  inviter_nickname
            /// </summary>
            [JsonProperty("inviter_nickname")]
            public string? InviterNickName { get; set; }
            /// <summary>
            ///  群头像
            /// </summary>
            [JsonProperty("group_headimgurl")]
            public string? GroupHeadImgUrl { get; set; }
            /// <summary>
            ///  群名
            /// </summary>
            [JsonProperty("group_name")]
            public string? GroupName { get; set; }
            /// <summary>
            ///  invite_url
            /// </summary>
            [JsonProperty("invite_url")]
            public string? InviteUrl { get; set; }
        }
    }
}
