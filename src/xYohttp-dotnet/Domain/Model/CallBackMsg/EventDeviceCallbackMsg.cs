using Newtonsoft.Json;
using xYohttp_dotnet.Common.Enums;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 设备回调消息
    /// </summary>
    public class EventDeviceCallbackMsg
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
        /// 接收用户ID
        /// </summary>
        [JsonProperty("to_wxid")]
        public string? ToWxid { set; get; }
        /// <summary>
        /// 接收用户昵称
        /// </summary>
        [JsonProperty("to_name")]
        public string? ToName { set; get; }
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
