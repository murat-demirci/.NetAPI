using factorydesignpattern.Abstract;
using factorydesignpattern.Factory;
using factorydesignpattern.Model;
using factorydesignpattern.Notify;


INotify MailNotfiy = NotifyFactory.CreateNotify(NotifyType.Mail);
MailNotfiy.SendNotification(new User{Name = "Ali", Email = "XXXXXXXXXXXXX"});

INotify SmsNotify = NotifyFactory.CreateNotify(NotifyType.SMS);
SmsNotify.SendNotification(new User{Name = "Ahmet", Email = "XXXXXXXXXXXXX"});