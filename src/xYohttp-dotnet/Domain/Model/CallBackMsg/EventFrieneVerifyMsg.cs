using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using xYohttp_dotnet.Common.Enums;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 好友请求消息
    /// </summary>
    public class EventFrieneVerifyMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        /// 添加方式
        /// </summary>
        [JsonProperty("type")]
        public EFrieneVerifyType Type { get; set; }
        /// <summary>
        /// 请求者wxid
        /// </summary>
        [JsonProperty("from_wxid")]
        public string? FromWxId { set; get; }
        /// <summary>
        /// 请求者昵称
        /// </summary>
        [JsonProperty("from_name")]
        public string? FromName { set; get; }
        /// <summary>
        /// v1
        /// </summary>
        [JsonProperty("v1")]
        public string? V1 { set; get; }
        /// <summary>
        /// v2
        /// </summary>
        [JsonProperty("v2")]
        public string? V2 { set; get; }
        /// <summary>
        /// 来源微信类型 0 正常微信 / 1 企业微信
        /// </summary>
        [JsonProperty("robot_type")]
        public int? RobotType { set; get; }
        /// <summary>
        /// 好友验证信息JSON
        /// </summary>
        [JsonProperty("json_msg")]
        public JObject? JsonMsg { set; get; }
    }
}
