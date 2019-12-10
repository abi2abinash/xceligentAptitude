using System;

namespace AxceligentAptitude
{
    internal class Alexa
    {
        public Alexa()
        {
        }

        public string GreetingMessage { get; set; }
        public string OwnerName { get; set; }

        public string FullMessage { get; set; }

        internal string Talk()
        {
            if (!string.IsNullOrEmpty(GreetingMessage))
            {

                return GreetingMessage.Replace("{OwnerName}", OwnerName);
            }
            else
            {
                return "print hello, i am Alexa";
            }
        }

        internal void Configure(Func<Alexa, Alexa> function)
        {
             function(this);
        }
    }
}