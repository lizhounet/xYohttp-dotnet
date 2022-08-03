using Newtonsoft.Json;

namespace xYohttp_dotnet.Domain.Model.Vo
{
    /// <summary>
    /// 好友Vo
    /// </summary>
    public class WxFriendVo
    {
        /// <summary>
        /// 微信id
        /// </summary>
        [JsonProperty("wxid")]
        public string? Wxid { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        [JsonProperty("wx_num")]
        public string? WxNum { get; set; }
        /// <summary>
        /// 性别1=男，2=女
        /// </summary>
        [JsonProperty("sex")]
        public int Sex { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("note")]
        public string? Note { get; set; }
        /// <summary>
        /// 微信昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }
        /// <summary>
        ///  省
        /// </summary>
        [JsonProperty("province")]
        public string? Province { get; set; }
        /// <summary>
        ///  国家
        /// </summary>
        [JsonProperty("country")]
        public string? Country { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        public string? City { set; get; }
        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("avatar")]
        public string? Avatar { set; get; }
    }
}
