namespace Note
{
    public class Operation
    {
        public void OperationCall()
        {
            Dictionary<string,Action> actions = new Dictionary<string,Action>();
            ListNote listNote = new ListNote();
            InNote inNote = new InNote();
            actions["Key1"] = () => listNote.GetNote();
            actions["Key2"] = () => inNote.DirectoryChecker();

            string key = Console.ReadLine();
            if (actions.ContainsKey(key))
            {
                actions[key].Invoke();
            }
            else
            {
                Console.WriteLine("Error Key");
            }
        }


    }
}
