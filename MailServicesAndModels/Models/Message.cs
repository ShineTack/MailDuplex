using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MailServicesAndModels.Models
{
    public class Message
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime SendDate { get; set; }
        [DataMember]
        public User Recipient { get; set; }
        [DataMember]
        public User Sender { get; set; }
        [DataMember]
        public string MessageHeader { get; set; }
        [DataMember]
        public string MessageBody { get; set; }
    }
}
