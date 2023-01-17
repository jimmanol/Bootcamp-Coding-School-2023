using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {

        // properties

        public Message[] Messages = Array.Empty<Message>();


        // methods

        public void ReadAll() {
            foreach (Message Msg in Messages) {

                Console.WriteLine(Msg);

            }
        }

        public void Clear() {
            Messages = Array.Empty<Message>(); ;
        }

        public void Write(Message Msg) {
           
        }



    }
}
