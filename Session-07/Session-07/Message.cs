using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_07.ActionRequest;

namespace Session_07 {
    public class Message {


        // properties

        public Guid ID { get; set; }
        public DateTime TimeStamp { get; set; }

        // change from class diagram: Message property cannot be the same as class name
        public string? Msg { get; set; }

        public Message() {
            ID= Guid.NewGuid();
        }

        //public Message(string text) {
        //    ID = Guid.NewGuid();
        //    TimeStamp= DateTime.Now;
        //    text = text;

        //}





    }
}
