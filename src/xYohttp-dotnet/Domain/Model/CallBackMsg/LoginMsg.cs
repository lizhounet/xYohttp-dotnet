using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 登录事件的消息
    /// </summary>
    public class LoginMsg
    {
        /// <summary>
        /// 0 登录成功 / 1 即将离线
        /// </summary>
        [JsonProperty("type")]
        public int? Type { get; set; }
        /// <summary>
        /// 登录/离线 的Wxid
        /// </summary>
        [JsonProperty("Wxid")]
        public string? WxId { get; set; }
        /// <summary>
        /// 来源微信类型 0 正常微信 / 1 企业微信
        /// </summary>
        [JsonProperty("robot_type")]
        public int? RobotType { get; set; }
    }
}
