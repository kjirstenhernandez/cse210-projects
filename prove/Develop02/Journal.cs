public class Journal {
    public string _filename;
    public string _createFile;
    public void SavetoFile()
    {
        using(StreamWriter writetext = new StreamWriter(_filename + ".txt"))
        {
            writetext.WriteLine("writing this line");
        }

    }

}