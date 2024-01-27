namespace FileOperationExample
{
    public static class FileService
    {
        public static string dirPath = "C:/Users/User/src_/tmp/FileOperationExample/ProjectFile/";
        public static void ReadFile()
        {
            string filePath = dirPath + "ReadFile.txt";
            if (File.Exists(filePath))
            {
                using (StreamReader _StreamReader = new(filePath))
                {
                    string content = _StreamReader.ReadToEnd();
                    Console.WriteLine("File Content:");
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("File not found: " + filePath);
            }
        }
        public static void WriteToFile()
        {
            string filePath = dirPath + "WriteFile.txt";
            using (StreamWriter _StreamWriter = new(filePath))
            {
                _StreamWriter.WriteLine("Hello, this is a line of text.");
                _StreamWriter.WriteLine("This is another line.");
                _StreamWriter.Write("This text is written without a new line.");
                _StreamWriter.Flush();
            }

            Console.WriteLine("Text has been written to the file: " + filePath);
        }
        public static void WriteToFileAsAppend()
        {
            string filePath = dirPath + "WriteFile.txt";
            using (StreamWriter _StreamWriter = new(filePath, true))
            {
                _StreamWriter.WriteLine("This line will be appended to the file.");
                _StreamWriter.Flush();
            }

            Console.WriteLine("Text has been appended to the file: " + filePath);
        }
    }
}

