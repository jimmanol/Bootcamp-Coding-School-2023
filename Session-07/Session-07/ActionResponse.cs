using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session_07.ActionRequest;

namespace Session_07 {
    public class ActionResponse {

        // properties
        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; }

        public string? Output { get; set; }



    }
}
