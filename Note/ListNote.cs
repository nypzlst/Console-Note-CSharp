namespace Note
{
   public class ListNote
    {
        public int GetNote()
        {
            string[] filleInDir = Directory.GetFiles(InNote.dirName); 
            int count = 0;
            foreach (string fille in filleInDir)
            {
                
                string fileName = Path.GetFileName(fille);
                Console.WriteLine($"{count} = {fileName}");
                count++;
            }
            return count;
        }
    }
}
