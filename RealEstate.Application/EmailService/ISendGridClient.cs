﻿using RealEstate.Application.EmailService.Entities;

namespace RealEstate.Application.EmailService
{
    public interface ISendGridClient
    {
        Task<bool> SendMail(string reciever, string subject, string body, List<string> attachments = null);
        Task<bool> SendMail(MailRecipientDTO Receiver, string subject, string body, List<string> attachments = null);
        Task<bool> SendMail(List<MailRecipientDTO> Receivers, string subject, string body, List<string> attachments = null);
    }
}
