namespace Note
{
    class Runtime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi in the console notes");
            var call = new Runtime(); 
            Console.WriteLine("==================================");
            call.StartConNote();
        }
       public  void StartConNote()
        {
            Console.WriteLine("Enter key to use CosNote\nList = Get list notes\nCreate = Create new note\nOpen = Open existing note");
            Operation operation = new Operation();
            operation.OperationCall();
        }
    }
  
}