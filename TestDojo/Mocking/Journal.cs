using System.IO.Abstractions;

namespace TestDojo.Mocking
{
    public class Journal
    {
        // example from https://learn.microsoft.com/en-us/dotnet/api/system.io.file.readalltext?view=net-7.0

        public void FileProcess(string filepath)
        {
            // This text is added only once to the file.
            if (!File.Exists(filepath))
            {
                // Create a file to write to.
                string createText = "Hello and Welcome" + Environment.NewLine;
                File.WriteAllText(filepath, createText);
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(filepath, appendText);

            // Open the file to read from.
            string readText = File.ReadAllText(filepath);
            Console.WriteLine(readText);
        }
    }
}
