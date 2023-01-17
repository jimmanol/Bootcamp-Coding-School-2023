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
        public ActionResolver() {

          }

        // METHODS
        public ActionResponse Execute(ActionRequest request) {
            string output = "";
            
            ActionResponse response = new ActionResponse();
            response.RequestID= request.RequestID;
            response.ResponseID = Guid.NewGuid();
            Message m = new Message();
                    m.ID = Guid.NewGuid();
                    m.TimeStamp = DateTime.Now;
            if (request.Input is string) {

                switch (request.Action) {
                    case ActionRequest.ActionEnum.Uppercase:
                        output = Capitalise(request.Input);
                        m.Msg = "Succesfuly Capitilise";
                        break;
                    case ActionRequest.ActionEnum.Reverse:
                        output = ReverseStr(request.Input);
                        m.Msg = "Succesful Reverse";
                        break;
                    case ActionRequest.ActionEnum.Convert:
                        try {
                            output = Conversion(request.Input);
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
            
            Logger.Write(m);
            
            response.Output = output;
            
            return response;
        }

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
