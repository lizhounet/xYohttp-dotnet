using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using xYohttp_dotnet.Common.Constant;
using xYohttp_dotnet.Domain.Model.Dto;
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
        public async Task<RobotListVo> GetRobotListAsync()
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.GetRobotList
            };
            return await PostAsync<RobotListVo>(body);
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
        public async Task<dynamic> SendGroupMsgAndAtAsync(string robotWxid, string groupWxid, string memberWxid, string memberName, string msg)
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
        public async Task<dynamic> SendGroupMsgAndAtEnterpriseAsync(string robotWxid, string groupWxid, string memberWxid, string msg)
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
        /// <param name="path">本地图片文件的绝对路径 或 网络图片url 或 图片base64编码</param>
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
        /// <param name="path">本地图片文件的绝对路径 或 网络图片url 或 图片base64编码</param>
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
        /// 获取群列表
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="isRefresh">1为重刷列表再获取，0为取缓存，默认为0</param>
        /// <returns></returns>
        public async Task<List<WxGroupVo>> GetGrouplistAsync(string robotWxid, int isRefresh = 0)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.GetGrouplist,
                robot_wxid = robotWxid,
                is_refresh = isRefresh
            };
            return await PostAsync<List<WxGroupVo>>(body);
        }
        /// <summary>
        /// 获取好友列表
        /// </summary>
        /// <param name="robotWxid">机器人ID</param>
        /// <param name="isRefresh">1为重刷列表再获取，0为取缓存，默认为0</param>
        /// <returns></returns>
        public async Task<List<WxFriendVo>> GetFriendlistAsync(string robotWxid, int isRefresh = 0)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.GetFriendlist,
                robot_wxid = robotWxid,
                is_refresh = isRefresh
            };
            return await PostAsync<List<WxFriendVo>>(body);
        }
        /// <summary>
        /// 启动个人微信
        /// </summary>
        /// <returns>base64格式的二维码</returns>
        public async Task<string> StartWeChatAsync()
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.StartWeChat,
            };
            var httpVo = await _url.PostJsonAsync(body).ReceiveJson<XYoHttpVo<object>>();
            return httpVo.ReturnStr ?? "";
        }
        /// <summary>
        /// 关闭已启动的个人扫码登录窗口
        /// </summary>
        /// <returns></returns>
        public async Task<dynamic> ExitWeChatLoginWinAsync()
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.ExitWeChatLoginWin,
            };
            return await PostAsync<dynamic>(body);
        }

        /// <summary>
        /// 退出指定微信
        /// </summary>
        /// <param name="robotWxid">机器人id</param>
        /// <returns></returns>
        public async Task<dynamic> ExitWeChatAsync(string robotWxid)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.ExitWeChat,
                robot_wxid = robotWxid
            };
            return await PostAsync<dynamic>(body);
        }
        /// <summary>
        /// 读取httpApi功能配置
        /// </summary>
        /// <returns></returns>
        public async Task<XyoCfgInfoDto> GetCfgAsync()
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.GetCfg
            };
            return await PostAsync<XyoCfgInfoDto>(body);
        }
        /// <summary>
        /// 写入httpApi功能配置
        /// </summary>
        /// <returns></returns>
        public async Task<XyoCfgInfoDto> SetCfgAsync(XyoCfgInfoDto cfgInfoDto)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.SetCfg,
                setJson = cfgInfoDto
            };
            return await PostAsync<XyoCfgInfoDto>(body);
        }
        /// <summary>
        /// 同意好友请求
        /// </summary>
        /// <param name="robotWxid">机器人id</param>
        /// <param name="v1">收到好友验证消息中（json）的v1属性</param>
        /// <param name="v2">收到好友验证消息中（json）的v2属性</param>
        /// <param name="type">收到好友验证消息中（json）的type属性</param>
        /// <returns></returns>
        public async Task<dynamic> AgreeFriendVerifyAsync(string robotWxid, string v1, string v2, string type)
        {
            var body = new
            {
                token = _token,
                api = ApiFunctionConstant.AgreeFriendVerify,
                robot_wxid = robotWxid,
                v1,
                v2,
                type
            };
            return await PostAsync<dynamic>(body);
        }

        /// <summary>
        /// 发起请求
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="body"></param>
        /// <returns></returns>
        private async Task<T> PostAsync<T>(object body) where T : class
        {
            var httpVo = await _url.PostJsonAsync(body).ReceiveJson<XYoHttpVo<T>>();
            Console.WriteLine($"{_url}返回:{httpVo}");
            return httpVo.ReturnJson;
        }

    }
}
