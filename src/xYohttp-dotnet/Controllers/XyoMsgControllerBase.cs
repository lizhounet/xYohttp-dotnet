using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using xYohttp_dotnet.Common.Constant;
using xYohttp_dotnet.Domain.Model.CallBackMsg;
using xYohttp_dotnet.Domain.Model.Dto;

namespace xYohttp_dotnet.Controllers
{
    /// <summary>
    /// xyo消息控制器基类
    /// </summary>
    [ApiController]
    [Route("api/xyoMsg")]
    public class XyoMsgControllerBase : ControllerBase
    {
        /// <summary>
        /// 消息处理fun
        /// </summary>
        /// <param name="callBackDto"></param>
        /// <returns></returns>
        [HttpPost("callback")]
        public virtual async Task<XyoHttpReplyDto> ProcessMessageAsync(XyoHttpCallBackDto callBackDto)
        {
            if (callBackDto == null) return new XyoHttpReplyDto(0);
            return callBackDto.Event switch
            {
                XyoEventConstant.Login => new XyoHttpReplyDto(await OnLoginAsync(callBackDto.Content.ToObject<LoginMsg>())),
                XyoEventConstant.EventInvitedInGroup => new XyoHttpReplyDto(await OnEventInvitedInGroupAsync(callBackDto.Content.ToObject<EventInvitedInGroupMsg>())),
                XyoEventConstant.EventDeviceCallback => new XyoHttpReplyDto(await OnEventDeviceCallbackAsync(callBackDto.Content.ToObject<EventDeviceCallbackMsg>())),
                XyoEventConstant.EventPrivateChat => new XyoHttpReplyDto(await OnEventPrivateChatAsync(callBackDto.Content.ToObject<EventPrivateChatMsg>())),
                XyoEventConstant.EventDownloadFile => new XyoHttpReplyDto(await OnEventDownloadFileAsync(callBackDto.Content.ToObject<EventDownloadFileMsg>())),
                XyoEventConstant.EventFrieneVerify => new XyoHttpReplyDto(await OnEventFrieneVerifyAsync(callBackDto.Content.ToObject<EventFrieneVerifyMsg>())),
                XyoEventConstant.EventQRcodePayment => new XyoHttpReplyDto(await OnEventQRcodePaymentAsync(callBackDto.Content.ToObject<EventQRcodePaymentMsg>())),
                XyoEventConstant.EventGroupChat => new XyoHttpReplyDto(await OnEventGroupChatAsync(callBackDto.Content.ToObject<EventGroupChatMsg>())),
                XyoEventConstant.EventGroupMemberAdd => new XyoHttpReplyDto(await OnEventGroupMemberAddAsync(callBackDto.Content.ToObject<EventGroupMemberAddMsg>())),
                XyoEventConstant.EventGroupNameChange => new XyoHttpReplyDto(await OnEventGroupNameChangeAsync(callBackDto.Content.ToObject<EventGroupNameChangeMsg>())),
                XyoEventConstant.EventGroupMemberDecrease => new XyoHttpReplyDto(await OnEventGroupMemberDecreaseAsync(callBackDto.Content.ToObject<EventGroupMemberDecreaseMsg>())),
                XyoEventConstant.EventGroupEstablish => new XyoHttpReplyDto(await OnEventGroupEstablishAsync(callBackDto.Content.ToObject<EventGroupEstablishMsg>())),
                _ => new XyoHttpReplyDto(0),
            };
        }
        /// <summary>
        /// 创建新的群聊事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventGroupEstablishAsync(EventGroupEstablishMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 群成员减少事件 PS: 群成员退出
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventGroupMemberDecreaseAsync(EventGroupMemberDecreaseMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 群名称变动事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventGroupNameChangeAsync(EventGroupNameChangeMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 群成员增加事件 PS: 新人进群
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]

        public virtual async Task<int> OnEventGroupMemberAddAsync(EventGroupMemberAddMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 群消息事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventGroupChatAsync(EventGroupChatMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 面对面收款事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventQRcodePaymentAsync(EventQRcodePaymentMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 好友请求事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventFrieneVerifyAsync(EventFrieneVerifyMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 文件下载结束事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventDownloadFileAsync(EventDownloadFileMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 私聊消息事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventPrivateChatAsync(EventPrivateChatMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 设备回调事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventDeviceCallbackAsync(EventDeviceCallbackMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 新的账号登录成功/下线
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnLoginAsync(LoginMsg msg)
        {
            return await Task.FromResult(0);
        }
        /// <summary>
        /// 被邀请入群事件 PS: 企业微信不传递此事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual async Task<int> OnEventInvitedInGroupAsync(EventInvitedInGroupMsg msg)
        {
            return await Task.FromResult(0);
        }
    }
}
