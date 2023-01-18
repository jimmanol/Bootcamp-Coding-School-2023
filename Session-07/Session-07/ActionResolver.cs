using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {
    public class ActionResolver {

        // PROPERTIES
        public MessageLogger Logger { get; set; }
         
        // CTOR
        //public ActionResolver() {

        //  }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {
            
            ActionResponse response = new ActionResponse();
            response.RequestID = request.RequestID;
            response.ResponseID = Guid.NewGuid();
            Message m = new Message();
                    m.ID = Guid.NewGuid();
                    m.TimeStamp = DateTime.Now;

           // Logger.Messages[0] = message;

            // should have try catch
            if (request.Input is string) {

                switch (request.Action) {
                    case ActionRequest.ActionEnum.Uppercase:
                        //Logger.Write(new Message("UPPERCASE"));
                        response.Output = Capitalise(request.Input);
                        m.Msg = "Succesfuly Capitilise";
                        break;
                    case ActionRequest.ActionEnum.Reverse:
                        //Logger.Write(new Message("REVERSE"));
                        response.Output = ReverseStr(request.Input);
                        m.Msg = "Succesful Reverse";
                        break;
                    case ActionRequest.ActionEnum.Convert:
                        try {
                            //Logger.Write(new Message("CONVERT"));
                            response.Output = Conversion(request.Input);
                            m.Msg = "Succesful Conversion";
                        }
                        catch {
                            m.Msg = "Error";
                        }
                        break;
                    default:
                        m.Msg = "Sorry! Not a supported action";
                        break;
                }
            }
            else {
                m.Msg = "Not a String";
            }
            //catch (Exception ex){ throw; log messages }
            //finally (log message)
            
            Logger.Write(m);
            
            return response;
        }

        //private void Log(string msg) {
        //    Message message = new Message(msg);
        //    Logger.Write(message);
        //}


        public string Capitalise(string InputA) {
            string line = InputA;
            string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
            string word = "";
            int ctr = 0;
            foreach (String s in words) {
                if (s.Length > ctr) {
                    word = s;
                    ctr = s.Length;
                }
            }
             return word.ToUpper();
        }

        public string Conversion(string InputB) {
            string result = string.Empty;
            
                int number = int.Parse(InputB);
                
                for (int i = 0; number > 0; i++) {
                    result = number % 2 + result;
                    number = number / 2;
                }
                return result;
            
        }

        public string ReverseStr(string InputC) {
            
            string revName = "";
            for (int i = InputC.Length - 1; i >= 0; i--) {
                revName = revName + InputC[i];
            }
            return revName;
        }






    }
}
