using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class SMSNotifierFactory : NotifierFactory
    {
        public override INotifier GenerateNotifier()
        {
            return new SMSNotifier();
        }
    }
}
