namespace Email_And_Sms_Notification_API
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
