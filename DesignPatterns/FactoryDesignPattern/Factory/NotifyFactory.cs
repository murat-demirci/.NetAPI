using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using factorydesignpattern.Abstract;
using factorydesignpattern.Concrete;
using factorydesignpattern.Notify;

namespace factorydesignpattern.Factory
{
    public class NotifyFactory
    {
        public static INotify CreateNotify(NotifyType notifyType)
        {
            return notifyType switch
            {
                NotifyType.SMS => new SmsNotify(),
                NotifyType.Mail => new MailNotify(),
                _ => throw new ArgumentException("Invalid Notify Type"),
            };
        }
    }
}