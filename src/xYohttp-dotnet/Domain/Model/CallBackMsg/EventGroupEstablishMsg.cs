using Newtonsoft.Json;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 创建新的群聊消息
    /// </summary>
    public class EventGroupEstablishMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        /// 来源群号
        /// </summary>
        [JsonProperty("from_group")]
        public string? FromGroup { get; set; }
        /// <summary>
        /// 来源微信类型 0 正常微信 / 1 企业微信
        /// </summary>
        [JsonProperty("robot_type")]
        public int? RobotType { set; get; }
    }
}
