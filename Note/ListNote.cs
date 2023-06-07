namespace Note
{
   public class ListNote
    {
        public void GetNote()
        {
            string[] filleInDir = Directory.GetFiles(InNote.dirName); 
            int count = 0;
            foreach (string fille in filleInDir)
            {
                
                string fileName = Path.GetFileName(fille);
                Console.WriteLine($"{count} = {fileName}");
                count++;
            }
        }
        public void GetAndContinueNote()
        {
            ListNote note = new ListNote();
            note.GetNote();
            ExitProg exit = new ExitProg();
            exit.Exit();
        }
    }
}
