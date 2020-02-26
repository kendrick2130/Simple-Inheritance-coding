using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Inheritance
{
    class SmartPhone : CellularPhone // inheriting from the class
    {
        string IPAddress; // property of smartphone
        public SmartPhone()
        {
            this.PhoneName = "iPhone";
            this.Messaging = "Using touchscreen for Texting over 4G";
            this.VoiceCalling = "Chatting over 4G network";
            this.IPAddress = "192.168.1.0";
        }
        public SmartPhone(string name, string voiceChat, string texting, string Ip): base(name, voiceChat, texting) // calling the base class constructor
        {
            this.IPAddress = Ip;
        }
        public override void TextMessaging() // overriding the base method
        {
            Console.WriteLine(this.Messaging);
        }
        public void BrowsingWeb() // creating a new method for smart phone
        {
            Console.WriteLine(this.IPAddress);
        }
    }
}
