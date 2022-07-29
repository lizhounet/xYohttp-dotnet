using Newtonsoft.Json;
using System.Collections.Generic;

namespace xYohttp_dotnet.Domain.Model.Vo
{
    public class GetRobotListVo
    {
        public int Number { set; get; }
        [JsonProperty("data")]
        public List<Robot> Data { set; get; } = new List<Robot>();
    }
    public class Robot
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pid")]
        public int PId { get; set; }
        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("username")]
        public string? UserName { get; set; }
        /// <summary>
        /// 微信ID
        /// </summary>
        [JsonProperty("wxid")]
        public string? WxId { get; set; }
        /// <summary>
        /// 个人微信号
        /// </summary>
        [JsonProperty("wx_num")]
        public string? WxNum { get; set; }
        /// <summary>
        /// 头像
        /// </summary>
        [JsonProperty("wx_headimgurl")]
        public string? WxHeadImgurl { get; set; }
        /// <summary>
        /// 是否为企业微信 个人微信0 企业微信1
        /// </summary>
        [JsonProperty("Enterprise wechat")]
        public int EnterpriseWechat { get; set; }
        /// <summary>
        /// 个人微信是0 企业微信是客户ID
        /// </summary>
        [JsonProperty("Enterprise wechat clientId")]
        public int EnterpriseWechatClientId { get; set; }
    }
}
