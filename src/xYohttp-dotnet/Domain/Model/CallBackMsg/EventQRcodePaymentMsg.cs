using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 面对面收款 消息
    /// </summary>
    public class EventQRcodePaymentMsg
    {
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        ///  收款者wxid
        /// </summary>
        [JsonProperty("to_wxid")]
        public string? ToWxid { get; set; }
        /// <summary>
        ///  付款者wxid
        /// </summary>
        [JsonProperty("payer_wxid")]
        public string? PayerWxId { get; set; }
        /// <summary>
        ///  付款者昵称
        /// </summary>
        [JsonProperty("payer_nickname")]
        public string? PayerNickName { get; set; }
        /// <summary>
        ///  payer_pay_id
        /// </summary>
        [JsonProperty("payer_pay_id")]
        public string? PayerPayId { get; set; }
        /// <summary>
        ///  received_money_index
        /// </summary>
        [JsonProperty("received_money_index")]
        public string? ReceivedMoneyIndex { get; set; }
        /// <summary>
        ///  金额
        /// </summary>
        [JsonProperty("money")]
        public string? Money { get; set; }
        /// <summary>
        ///  total_money
        /// </summary>
        [JsonProperty("total_money")]
        public string? TotalMoney { get; set; }
        /// <summary>
        ///  备注
        /// </summary>
        [JsonProperty("remark")]
        public string? Remark { get; set; }
        /// <summary>
        ///  scene_desc
        /// </summary>
        [JsonProperty("scene_desc")]
        public string? SceneDesc { get; set; }
        /// <summary>
        ///  -1 扫码后退出 / 1 已扫码，未付款 / 2 付款完成 / 3 付款完成后的日志 / 4 付款完成后的日志（商家版），这里重点说明一下，如要做收款播报，只需要判断等于2或者等3的时候就可以了
        /// </summary>
        [JsonProperty("scene")]
        public int? Scene { set; get; }
        /// <summary>
        /// 时间
        /// </summary>
        [JsonProperty("time")]
        public string? Time { set; get; }
    }
}
