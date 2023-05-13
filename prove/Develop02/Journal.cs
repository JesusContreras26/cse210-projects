using System;

public class Journal{

    //I create a list of entries when I'll save each of my entries
    //as an entry object by doing this I'll be able to access any feature
    //of the entry class
    public List<Entry> _entries = new List<Entry>();

    //I'll use the list length in order to iterate inside of it
    public int _listLenght;

    //addEntries method will add the entries to the entry list and 
    //its values for the differents methods and variables
    //when the user decide to add an entry 
    public void AddEntries(){
        _entries.Add(new Entry());
        _listLenght = _entries.Count;
        _entries[_listLenght - 1]._prompt =_entries[_listLenght - 1]._randomPrompt.PromptDis();
        _entries[_listLenght - 1]._entry = Console.ReadLine();
        Console.WriteLine();
        _entries[_listLenght - 1].Store();
    }
    
    //EntriesDisp methos will display all the entries making use of the EntryDisp method 
    //in the entry class, each entry will have its own EntryDisp method
    public void EntriesDisp(){
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].EntryDisp();
        }
    }
    
    //Load will load a file that has been already save; from that file I'll get an special
    //string which one I can manipulate to store the old entries to my entry list with its
    //differents behaviors and attributes likewise when a new file got loaded a new journal object
    //will be created, there is where the old entries will be saved and if I want to add new ones 
    //they will be store on the entry list after the old ones, I'll get filename from the user 
    //and send it to the function as a parameter 

    public void Load(string fileName){
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries.Clear();
        foreach (string line in lines){
            _entries.Add(new Entry());
            string[] parts = line.Split(",");
            _listLenght = _entries.Count;
            _entries[_listLenght - 1]._date = parts[0];
            _entries[_listLenght - 1]._prompt = parts[1];
            _entries[_listLenght - 1]._entry = parts[2].Replace("~" , ",");
            _entries[_listLenght - 1].Store();
        }
        
    }

    //Save method will save the entries to the file, the file name I'll get it from the user
    //and I'll give it to the method as a parameter, I'll save it as a special string that will be
    //in my _storeEntry variable, the value from that variable has been generated from the Store() method
    //in the entry class before.
    
    public void Save(string fileName){
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(Entry _entry in _entries){
                outputFile.WriteLine($"{_entry._storeEntry}");
            }
        }
    } 


}