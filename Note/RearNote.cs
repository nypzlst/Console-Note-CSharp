namespace Note
{
    public class RearNote 
    {

        void Reading()
        {
            
        }
       public void GetNeedNote()
        {
            ListNote listNote = new ListNote();
            listNote.GetNote();
            Console.WriteLine("Write the index of the desired file");
            int index = Convert.ToInt32(Console.ReadLine());
            RearNote rearNote = new RearNote();
            rearNote.SearchNote(index);
        }

        public void SearchNote(int index)
        {
            ListNote listNote = new ListNote();
            string[] filleInDir = Directory.GetFiles(InNote.dirName);
            if(index >= 0)
            {
                string filePath = filleInDir[index];
                try
                {
                    string[] fileContent = File.ReadAllLines(filePath);
                    Console.WriteLine("Содержимое файла:");
                    foreach (string line in fileContent)
                    {
                        Console.WriteLine(line); 
                    }
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                }
                finally
                {
                    ExitProg exit = new ExitProg();
                    exit.Exit();
                }
            }
        }

    }
}
