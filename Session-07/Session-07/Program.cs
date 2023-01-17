namespace Session_07 {
    internal class Program {
        public static void Main(string[] args) {

            Guid id = Guid.NewGuid();
            string word = "Hello World";

            ActionRequest request = new ActionRequest();
            request.RequestID = id;
            request.Input = word;
            request.Action = ActionRequest.ActionEnum.Convert;




            ActionResponse response = new ActionResponse();

            ActionResolver resolver = new ActionResolver();
            
            resolver.Logger = new MessageLogger();
            resolver.Logger.Messages = Array.Empty<Message>();

          
            response = resolver.Execute(request);




            // DISPLAY MESSAGES FROM LOGGER
            foreach (Message message in resolver.Logger.Messages) {

                Console.WriteLine(message);

            }
            Console.WriteLine(response.Output);
        }
    }
}