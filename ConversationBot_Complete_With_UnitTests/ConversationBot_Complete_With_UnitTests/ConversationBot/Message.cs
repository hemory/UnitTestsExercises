using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationBot
{
    public class Message
    {
        public string GreetUser(string firstName, string lastName)
        {
            return $"Hello {firstName} {lastName}";
        }


        public List<string> GetFarewellMessages()
        {
            List<string> messages = new List<string>
            {
                "goodbye",
                "adios",
                "deuces",
                "see you later"
            };

            return messages;
        }


    }





}
