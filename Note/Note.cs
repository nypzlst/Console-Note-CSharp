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
                StreamWriter sw = new StreamWriter($"C:\\Users\\nypozalysta\\Documents\\MyDir\\{DataTimes()}.txt");
                sw.WriteLine("Hello\n world");
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
                Console.WriteLine("Do you want to continue? y/n");
                string answer = Console.ReadLine();
                if(answer == "n")
                {
                    Console.WriteLine("Exit");
                }
                else
                {
                    Runtime call = new Runtime();
                    call.StartConNote();
                }
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
        public string DataTimes()
        {
            DateTime now = DateTime.Now;
            string data = now.ToString("hhmmssddmmyyyy");
            return data;
        }
        
    }
}
