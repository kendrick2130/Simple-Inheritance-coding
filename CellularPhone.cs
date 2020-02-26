using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Inheritance
{
    class CellularPhone
    {
       public string PhoneName; // porperties shared
       public string VoiceCalling;      
       public string Messaging;

        public CellularPhone()
        {

        }
        public CellularPhone(string name, string voiceChat, string texting) // constructor
        {
            this.PhoneName = name;
            this.VoiceCalling = voiceChat;
            this.Messaging = texting;

        }
        public virtual void TextMessaging() // creating a virtual method to be overriden
        {
            Console.WriteLine("Did you receive my text.");
        }
    }
}
