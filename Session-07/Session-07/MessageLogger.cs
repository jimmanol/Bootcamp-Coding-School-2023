using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class MessageLogger {

        // properties

        public Message[] Messages { get; set; }


        // methods
        public MessageLogger() {
                Messages = new Message[1000];
        }

        public void ReadAll() {
            foreach (Message Msg in Messages) {

                Console.WriteLine(Msg);

            }
        }

        public void Clear() {
            Messages = Array.Empty<Message>(); ;
        }

        public void Write(Message Msg) {
           //Messages.Append(Msg);
           Console.WriteLine(Msg.Msg);
        }



    }
}
