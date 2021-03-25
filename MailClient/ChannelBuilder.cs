using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MailClient
{
    static class ChannelBuilder
    {
        public static DuplexChannelFactory<T> GetChannelFactory<T>(
            InstanceContext context, System.ServiceModel.Channels.Binding binding, string address)
        {
            return new DuplexChannelFactory<T>(context, binding, address);
        }
    }
}
