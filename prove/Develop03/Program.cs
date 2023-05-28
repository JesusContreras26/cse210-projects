using System;

class Program
{
    static void Main(string[] args)
    {   
        Random _random = new Random();

        DicScriptures _dicScriptures = new DicScriptures();
        //List of dictionary that will use to select random scriptures every time the program runs
        List<Dictionary<string, string>> Scriptures = _dicScriptures.getScriptures();

        
        //Conditional to populate reference and scripture classes depending of what scripture has been chosen
        int _randomNumber = _random.Next(0, 3);
        if (Scriptures[_randomNumber].Count-1 > 3){
            Reference _reference = new Reference(Scriptures[_randomNumber]["Book"], int.Parse(Scriptures[_randomNumber]["Chapter"]), int.Parse(Scriptures[_randomNumber]["FirstVerse"]), int.Parse(Scriptures[_randomNumber]["LastVerse"]));
            string Scripture = Scriptures[_randomNumber]["Scripture"];
            Scripture _scripture = new Scripture(_reference.GetReference(), $" {Scripture} ");
            _scripture.HideWords();
        } else {    
            Reference _reference = new Reference(Scriptures[_randomNumber]["Book"], int.Parse(Scriptures[_randomNumber]["Chapter"]), int.Parse(Scriptures[_randomNumber]["FirstVerse"]));
            string Scripture = Scriptures[_randomNumber]["Scripture"];
            Scripture _scripture = new Scripture(_reference.GetReference(), $" {Scripture} ");
            _scripture.HideWords();
        }
        


    }
}