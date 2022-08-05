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
        [HttpPost("callback")]
        public virtual XyoHttpReplyDto ProcessMessage(XyoHttpCallBackDto callBackDto)
        {
            if (callBackDto == null) return new XyoHttpReplyDto(0);
            return callBackDto.Event switch
            {
                XyoEventConstant.Login => new XyoHttpReplyDto(OnLogin(callBackDto.Content.ToObject<LoginMsg>())),
                XyoEventConstant.EventInvitedInGroup => new XyoHttpReplyDto(OnEventInvitedInGroup(callBackDto.Content.ToObject<EventInvitedInGroupMsg>())),
                XyoEventConstant.EventDeviceCallback => new XyoHttpReplyDto(OnEventDeviceCallback(callBackDto.Content.ToObject<EventDeviceCallbackMsg>())),
                XyoEventConstant.EventPrivateChat => new XyoHttpReplyDto(OnEventPrivateChat(callBackDto.Content.ToObject<EventPrivateChatMsg>())),
                XyoEventConstant.EventDownloadFile => new XyoHttpReplyDto(OnEventDownloadFile(callBackDto.Content.ToObject<EventDownloadFileMsg>())),
                XyoEventConstant.EventFrieneVerify => new XyoHttpReplyDto(OnEventFrieneVerify(callBackDto.Content.ToObject<EventFrieneVerifyMsg>())),
                XyoEventConstant.EventQRcodePayment => new XyoHttpReplyDto(OnEventQRcodePayment(callBackDto.Content.ToObject<EventQRcodePaymentMsg>())),
                XyoEventConstant.EventGroupChat => new XyoHttpReplyDto(OnEventGroupChat(callBackDto.Content.ToObject<EventGroupChatMsg>())),
                XyoEventConstant.EventGroupMemberAdd => new XyoHttpReplyDto(OnEventGroupMemberAdd(callBackDto.Content.ToObject<EventGroupMemberAddMsg>())),
                XyoEventConstant.EventGroupNameChange => new XyoHttpReplyDto(OnEventGroupNameChange(callBackDto.Content.ToObject<EventGroupNameChangeMsg>())),
                XyoEventConstant.EventGroupMemberDecrease => new XyoHttpReplyDto(OnEventGroupMemberDecrease(callBackDto.Content.ToObject<EventGroupMemberDecreaseMsg>())),
                XyoEventConstant.EventGroupEstablish => new XyoHttpReplyDto(OnEventGroupEstablish(callBackDto.Content.ToObject<EventGroupEstablishMsg>())),
                _ => new XyoHttpReplyDto(0),
            };
        }
        /// <summary>
        /// 创建新的群聊事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventGroupEstablish(EventGroupEstablishMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 群成员减少事件 PS: 群成员退出
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventGroupMemberDecrease(EventGroupMemberDecreaseMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 群名称变动事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventGroupNameChange(EventGroupNameChangeMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 群成员增加事件 PS: 新人进群
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]

        public virtual int OnEventGroupMemberAdd(EventGroupMemberAddMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 群消息事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventGroupChat(EventGroupChatMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 面对面收款事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventQRcodePayment(EventQRcodePaymentMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 好友请求事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventFrieneVerify(EventFrieneVerifyMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 文件下载结束事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventDownloadFile(EventDownloadFileMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 私聊消息事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventPrivateChat(EventPrivateChatMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 设备回调事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventDeviceCallback(EventDeviceCallbackMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 新的账号登录成功/下线
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnLogin(LoginMsg msg)
        {
            return 0;
        }
        /// <summary>
        /// 被邀请入群事件 PS: 企业微信不传递此事件
        /// </summary>
        /// <param name="msg">事件消息实体</param>
        /// <returns></returns>
        [NonAction]
        public virtual int OnEventInvitedInGroup(EventInvitedInGroupMsg msg)
        {
            return 0;
        }
    }
}
