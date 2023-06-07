namespace Note
{
    public class Operation
    {
        public void OperationCall()
        {
            Dictionary<string,Action> actions = new Dictionary<string,Action>();
            ListNote listNote = new ListNote();
            InNote inNote = new InNote();
            RearNote rearNote = new RearNote();
            actions["List"] = () => listNote.GetAndContinueNote();
            actions["Create"] = () => inNote.DirectoryChecker();
            actions["Open"] = () => rearNote.GetNeedNote();

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
