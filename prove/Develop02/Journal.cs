using System;

//Journal Class

public class Journal
{

    // List to store entries
    public List<Entry>_textEntries = new List<Entry>();

    //A method that displas the entries made
    public void Display()
    {
        foreach (Entry entry in _textEntries)
        {
            entry.written();
        }
    }

    // A method that displays the person's full name as used in western 
    // countries or <given name family name>.
}