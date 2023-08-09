using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using factorydesignpattern.Abstract;
using factorydesignpattern.Model;

namespace factorydesignpattern.Concrete
{
    public class SmsNotify : INotify
    {
        public void SendNotification(User user)
        {
            Console.WriteLine($"{user.Name} icin telefon numarasına sms gönderildi");
        }
    }
}