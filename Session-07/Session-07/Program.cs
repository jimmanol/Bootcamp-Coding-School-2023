namespace Session_07 {
    internal class Program {
        public static void Main(string[] args) {

            ActionRequest request = new ActionRequest() {
                   Input = "Hello World",
                   Action= ActionRequest.ActionEnum.Reverse
            };
            

            ActionResponse response = new ActionResponse();

            ActionResolver resolver = new ActionResolver();
            
            resolver.Logger = new MessageLogger();
            resolver.Logger.Messages = Array.Empty<Message>();

          
            response = resolver.Execute(request);


            //// DISPLAY MESSAGES FROM LOGGER
            //foreach (Message message in resolver.Logger.Messages) {

            //    Console.WriteLine(message);

            //}
            Console.WriteLine(response.Output);

            Console.ReadLine();
        
        }
    }
}