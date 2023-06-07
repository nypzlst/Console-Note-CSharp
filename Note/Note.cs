using System.IO;
namespace Note
{
   
    public class InNote
    {
        public static string dirName = "C:\\Users\\nypozalysta\\Documents\\MyDir";
        public  void WriteInFile()
        {
            try
            {
                StreamWriter sw = new StreamWriter($"C:\\Users\\nypozalysta\\Documents\\MyDir\\{NameFille()}.txt");
                string note = Console.ReadLine();
                int count = 0;
                for(int i = 0; i < note.Length; i++)
                {
                    sw.Write(note[i]);
                    count++;
                    if(count==150 )
                    {
                        sw.Write("\n");
                        count = 0;
                    }
                }
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption " + e.Message);
            }
            finally
            {
                ExitProg exit =  new ExitProg();
                exit.Exit();
            }
        }

        public void DirectoryChecker()
        {
            try
            {
                if (Directory.Exists(dirName))
                {
                    WriteInFile();
                }
                else
                { 
                    DirectoryInfo di = Directory.CreateDirectory(dirName);
                    WriteInFile();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("The directory error"+e.ToString());
            }
        }
        public string NameFille()
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            return name;
        }
        
    }
}
