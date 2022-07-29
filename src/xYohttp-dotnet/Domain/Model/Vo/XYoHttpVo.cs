using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace xYohttp_dotnet.Domain.Model.Vo
{
    /// <summary>
    /// xyo http响应实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XYoHttpVo<T> where T : class
    {
        public int Code { set; get; }
        /// <summary>
        /// 结果
        /// </summary>
        public string? Result { set; get; }
        public T? ReturnJson { set; get; }
        /// <summary>
        /// 是否调用成功
        /// </summary>
        public bool IsSuccess
        {
            get
            {
                return this.Code == 0;
            }
        }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
