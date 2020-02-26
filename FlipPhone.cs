using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7_Inheritance
{
    class FlipPhone : CellularPhone
    {
        string NoPhoneCaseNeeded; // property for Flip phone only
        public FlipPhone() // inheriting from the base class
        {
            this.PhoneName = "Rugged Flip Cricket";
            this.VoiceCalling = "I am able to Chat over 3G";
            this.Messaging = "I text using T-9 methology";
            this.NoPhoneCaseNeeded = "If you drop me I will not shatter";

        }
        public FlipPhone(string name, string voiceChat, string texting, string NoCase) : base(name, voiceChat, texting) // calling the base class constructor
        {
            this.NoPhoneCaseNeeded = NoCase;
        }
        public override void TextMessaging() // overriding the base class method
        {
            Console.WriteLine(this.Messaging);
        }
        private void NoCase() // method only for Flip Phone
        {
            Console.WriteLine(this.NoPhoneCaseNeeded);
        }
    }
}
