namespace Shop.Infrastructure.Service;

public class FileReadingService
{
    public string[,] ReadFiles(string directoryPath)
    {

        int noFilesInDirectory = Directory.GetFiles(directoryPath).Length;
        int coloumns = 3;

        // the number of rows equals the number of files, with 3 pieces of information per file.
        string[,] fileData = new string[noFilesInDirectory, coloumns];

        if (Directory.Exists(directoryPath))
        {

            try
            {
                string[] files = Directory.GetFiles(directoryPath);

                for (int i = 0; i < noFilesInDirectory; i++)
                {
                    string fileContent = File.ReadAllText(files[i]);
                    
                    string[] parts = fileContent.Split(',');

                    if (parts.Length == 3)
                    {
                        fileData[i, 0] = parts[0].Trim();
                        fileData[i, 1] = parts[1].Trim();
                        fileData[i, 2] = parts[2].Trim();
                    }
                    else
                    {
                        Console.WriteLine("The file doesn't contain 3 parts");
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"Couldn't read file + {e}");
                throw;
            }
        }
        else
        {
            Console.WriteLine($"The directory {directoryPath} doesn't exist");
        }
        
        return fileData;
    }
}