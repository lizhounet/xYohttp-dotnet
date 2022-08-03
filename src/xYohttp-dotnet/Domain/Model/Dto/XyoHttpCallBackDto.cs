using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.Dto
{
    /// <summary>
    /// xyo http 消息回调dto
    /// </summary>
    public class XyoHttpCallBackDto
    {
        /// <summary>
        /// SDK版本号
        /// </summary>
        public int SdkVer { set; get; }
        /// <summary>
        /// 事件（易语言模板的子程序名）
        /// </summary>
        public string? Event { set; get; }
        /// <summary>
        /// 内容
        /// </summary>
        public JObject Content { set; get; }
    }
}
