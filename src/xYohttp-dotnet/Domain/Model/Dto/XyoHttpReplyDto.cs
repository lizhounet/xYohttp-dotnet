using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.Dto
{
    /// <summary>
    /// Xyo消息回调返回 对消息处理的状态
    /// </summary>
    public class XyoHttpReplyDto
    {
        public XyoHttpReplyDto(int code) { 
            Code = code;
        }
        /// <summary>
        /// 消息处理方式：-1中断推送 0忽略此消息 1拦截此消息
        /// </summary>
        public int Code { set; get; }
    }
}
