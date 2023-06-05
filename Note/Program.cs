

namespace Note
{

    class Runtime
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hi in the console notes");
            var call = new Runtime();
            call.StartConNote();
        }
       public  void StartConNote()
        {
            Console.WriteLine("Enter key to use CosNote\nKey1 = Get list notes\nKey2 = Create new note");
            Operation operation = new Operation();
            operation.OperationCall();
        }
    }
  
}