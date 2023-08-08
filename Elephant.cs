using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapElephant
{
    class Elephant
    {
		private string name;
        private int earSize;
        public string Name
		{
			get { return name; }
			set { name = value; }
		}		
		public int EarSize
		{
			get { return earSize; }
			set { earSize = value; }
		}

		public void WhoAmI()
		{
            Console.WriteLine("My name is {0}", Name);
            Console.WriteLine("My ears are {0} inches long", EarSize);
        }

		public void HearMessage(string message, Elephant whoSaidIt)
		{
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);
        }

		public void SpeakTo(Elephant whoToTalkTo, string message)
		{
			whoToTalkTo.HearMessage(message, this) ;
		}
	}
}
