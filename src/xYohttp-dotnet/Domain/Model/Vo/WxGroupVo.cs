using Newtonsoft.Json;

namespace xYohttp_dotnet.Domain.Model.Vo
{
    /// <summary>
    /// 微信群Vo
    /// </summary>
    public class WxGroupVo
    {
        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("avatar")]
        public string? Avatar { get; set; }
        /// <summary>
        /// 自己是否为群主:0不是，1是
        /// </summary>
        [JsonProperty("is_manager")]
        public string? IsManager { get; set; }
        /// <summary>
        /// 群主wxid
        /// </summary>
        [JsonProperty("manager_wxid")]
        public string? ManagerWxid { get; set; }
        /// <summary>
        ///  群昵称
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; }
        /// <summary>
        /// 群成员数量
        /// </summary>
        [JsonProperty("total_member")]
        public int TotalMember { get; set; }
        /// <summary>
        /// 群ID
        /// </summary>
        [JsonProperty("wxid")]
        public string? WxId { set; get; }
    }
}
