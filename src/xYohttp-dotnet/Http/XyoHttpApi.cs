using System;
using System.Threading.Tasks;
using Flurl.Http;
using xYohttp_dotnet.Common.Constant;
using xYohttp_dotnet.Domain.Model.Vo;

namespace xYohttp_dotnet.Http
{
    /// <summary>
    /// xYo_httpApi_WeChat 的http接口类
    /// </summary>
    public sealed class XyoHttpApi
    {
        private readonly string _url;
        private readonly string _token;
        public XyoHttpApi(string url, string token)
        {
            _url = url;
            _token = token;
        }
        /// <summary>
        /// 获取登录账号列表
        /// </summary>
        /// <returns></returns>
        public async Task<GetRobotListVo> GetRobotListAsync()
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.GetRobotList
            };
            return await PostAsync<GetRobotListVo>(body);
        }
        /// <summary>
        /// 发送文字消息
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> SendTextMsgAsync(string robotWxid, string toWxid, string msg)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendTextMsg,
                robot_wxid = robotWxid,
                to_wxid = toWxid,
                msg
            };
            return await PostAsync<dynamic>(body);
        }

        /// <summary>
        /// 发起请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="body"></param>
        /// <returns></returns>
        private async Task<T> PostAsync<T>(object body) where T : class, new()
        {
            var httpVo = await _url.PostJsonAsync(body).ReceiveJson<XYoHttpVo<T>>();
            Console.WriteLine($"{_url}返回:{httpVo}");
            return httpVo.ReturnJson ?? new T();

        }
    }
}
