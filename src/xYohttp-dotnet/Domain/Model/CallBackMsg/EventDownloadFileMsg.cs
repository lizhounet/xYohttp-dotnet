using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.CallBackMsg
{
    /// <summary>
    /// 文件下载结束 消息
    /// </summary>
    public class EventDownloadFileMsg
    {
        /// <summary>
        /// 下载标识
        /// </summary>
        [JsonProperty("downloadIde")]
        public string? DownLoadIde { get; set; }
        /// <summary>
        /// 文件下载直链
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
        /// <summary>
        /// 文件完整路径
        /// </summary>
        [JsonProperty("savePath")]
        public string? SavePath { get; set; }
        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("fileName")]
        public string? FileName { get; set; }
        /// <summary>
        /// 文件总大小 单位 B
        /// </summary>
        [JsonProperty("fileSize")]
        public int? FileSize { get; set; }
        /// <summary>
        /// 已下载大小 单位 B
        /// </summary>
        [JsonProperty("downloadSize")]
        public string? DownLoadSize { get; set; }
        /// <summary>
        /// 下载进度 0.00 - 1.00
        /// </summary>
        [JsonProperty("schedule")]
        public double? Schedule { get; set; }
        /// <summary>
        /// 平均速度 KB/S 实时速度 在下载时有值 下载完成时归零
        /// </summary>
        [JsonProperty("speed")]
        public int Speed { get; set; }
        /// <summary>
        /// 下载状态 0 未开始 1 开始下载 2 下载中 3 结束下载 -1 下载错误
        /// </summary>
        [JsonProperty("downloadType")]
        public int? DownLoadType { get; set; }
        /// <summary>
        /// 调用API
        /// </summary>
        [JsonProperty("api")]
        public string? Api { get; set; }
        /// <summary>
        /// 机器人账号id
        /// </summary>
        [JsonProperty("robot_wxid")]
        public string? RobotWxId { get; set; }
        /// <summary>
        ///  对方的ID（好友/群ID/公众号ID）
        /// </summary>
        [JsonProperty("to_wxid")]
        public string? ToWxid { get; set; }
    }
}
