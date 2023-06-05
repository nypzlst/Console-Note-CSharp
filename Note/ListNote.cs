namespace Note
{
   public class ListNote
    {
        public void GetNote()
        {
            string[] filleInDir = Directory.GetFiles(InNote.dirName);

            foreach (string fille in filleInDir)
            {
                string fileName = Path.GetFileName(fille);
                Console.WriteLine(fileName);
            }
        }
    }
}
