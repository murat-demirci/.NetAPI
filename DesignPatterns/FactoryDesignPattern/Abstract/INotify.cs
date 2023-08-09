using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using factorydesignpattern.Model;

namespace factorydesignpattern.Abstract
{
    public interface INotify
    {
        void SendNotification(User user);
    }
}