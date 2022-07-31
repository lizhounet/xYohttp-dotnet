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
        /// 发送文字消息_企业
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> SendTextMsgEnterpriseAsync(string robotWxid, string toWxid, string msg)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendTextMsgEnterprise,
                robot_wxid = robotWxid,
                to_wxid = toWxid,
                msg
            };
            return await PostAsync<dynamic>(body);
        }
        /// <summary>
        /// 发送群消息并艾特成员
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="groupWxid">群ID</param>
        /// <param name="memberWxid">要艾特的群成员ID，艾特多人用英文逗号“,”</param>
        /// <param name="memberName">要艾特的群成员昵称，可空 会自动读取</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        public async Task<dynamic> SendGroupMsgAndAtAsync(string robotWxid, string groupWxid,string memberWxid,string memberName, string msg)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendGroupMsgAndAt,
                robot_wxid = robotWxid,
                group_wxid = groupWxid,
                member_wxid = memberWxid,
                member_name = memberName,
                msg
            };
            return await PostAsync<dynamic>(body);
        }
        /// <summary>
        /// 发送群消息并艾特成员_企业
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="groupWxid">群ID</param>
        /// <param name="memberWxid">要艾特的群成员ID，艾特多人用英文逗号“,”</param>
        /// <param name="msg">消息内容</param>
        /// <returns></returns>
        public async Task<dynamic> SendGroupMsgAndAtEnterpriseAsync(string robotWxid, string groupWxid, string memberWxid,  string msg)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendGroupMsgAndAtEnterprise,
                robot_wxid = robotWxid,
                group_wxid = groupWxid,
                member_wxid = memberWxid,
                msg
            };
            return await PostAsync<dynamic>(body);
        }


        /// <summary>
        /// 发送图片消息
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="toWxid">对象WXID（好友ID/群ID/公众号ID）</param>
        /// <param name="path">机器人本地图片文件的绝对路径 或 网络图片urll 或 图片base64编码</param>
        /// <returns></returns>
        public async Task<dynamic> SendImageMsgAsync(string robotWxid, string toWxid, string path)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendImageMsg,
                robot_wxid = robotWxid,
                to_wxid = toWxid,
                path
            };
            return await PostAsync<dynamic>(body);
        }
        /// <summary>
        /// 发送图片消息_企业
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="toWxid">对象WXID（好友ID/群ID/公众号ID）</param>
        /// <param name="path">机器人本地图片文件的绝对路径 或 网络图片urll 或 图片base64编码</param>
        /// <returns></returns>
        public async Task<dynamic> SendImageMsgEnterpriseAsync(string robotWxid, string toWxid, string path)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SendImageMsgEnterprise,
                robot_wxid = robotWxid,
                to_wxid = toWxid,
                path
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
