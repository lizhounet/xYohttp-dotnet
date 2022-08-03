using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using xYohttp_dotnet.Common.Constant;
using xYohttp_dotnet.Domain.Model.CallBackMsg;
using xYohttp_dotnet.Domain.Model.Dto;

namespace xYohttp_dotnet.Controllers
{
    /// <summary>
    /// xyo消息控制器基类
    /// </summary>
    public class XyoMsgControllerBase : ControllerBase
    {
        public virtual XyoHttpReplyDto ProcessMessage(XyoHttpCallBackDto callBackDto)
        {
            if (callBackDto == null) return new XyoHttpReplyDto(0);
            return callBackDto.Event switch
            {
                XyoEventConstant.Login => new XyoHttpReplyDto(OnLogin(callBackDto.Content.ToObject<LoginMsg>())),
                XyoEventConstant.EventInvitedInGroup => new XyoHttpReplyDto(OnEventInvitedInGroup(callBackDto.Content.ToObject<EventInvitedInGroupMsg>())),
                XyoEventConstant.EventDeviceCallback => new XyoHttpReplyDto(OnEventDeviceCallback(callBackDto.Content.ToObject<EventDeviceCallbackMsg>())),
                XyoEventConstant.EventPrivateChat => new XyoHttpReplyDto(OnEventpublicChat(callBackDto.Content.ToObject<EventPrivateChatMsg>())),
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
        [NonAction]
        public virtual int OnEventGroupEstablish(EventGroupEstablishMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventGroupMemberDecrease(EventGroupMemberDecreaseMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventGroupNameChange(EventGroupNameChangeMsg msg)
        {
            return 0;
        }
        [NonAction]

        public virtual int OnEventGroupMemberAdd(EventGroupMemberAddMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventGroupChat(EventGroupChatMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventQRcodePayment(EventQRcodePaymentMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventFrieneVerify(EventFrieneVerifyMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventDownloadFile(EventDownloadFileMsg msg)
        {
            return 0;
        }
        [NonAction]
        public virtual int OnEventpublicChat(EventPrivateChatMsg msg)
        {
            return 0;
        }
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
