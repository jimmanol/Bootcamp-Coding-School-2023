namespace Session_07 {
    internal class Program {
        public static void Main(string[] args) {

            Guid id = Guid.NewGuid();
            string word = "hELLO";

            ActionRequest request = new ActionRequest();
            request.RequestID = id;
            request.Input = word;
            request.Action = ActionRequest.ActionEnum.Convert;




            ActionResponse response = new ActionResponse();

            ActionResolver resolver = new ActionResolver();

            response = resolver.Execute(request);





            // DISPLAY MESSAGES FROM LOGGER
            foreach (Message message in resolver.Logger.Messages) {

                Console.WriteLine(message);

            }
        }
    }
}