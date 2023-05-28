using System;

//Scripture will be the class that'll have more importance
public class Scripture{

    //Defining and declaring variables, I need a list of words object for each
    //Word of the string in order hide and replace them likewise a need string list object
    //To first get them all split as an array member and then I'll populate my list of word objects
    //also I'll need a random object to select a random member of the word list
    private List<Word> _words = new List<Word>();
    private string _scripture;
    private string[] _allWords;
    private Random _random = new Random();
    private string _reference;


    //Constructor for the scripture class, it'll accept
    //A reference and the scripture itself
    public Scripture(string reference, string scripture){
        _scripture = scripture;
        _reference = reference;
        _allWords = _scripture.Split(" ");
        int counter = 0;

        //Here I'll populate list words object making use of a 
        //fore-ach loop and the string list with the words inside of them
        //I did also populate the word variable inside of each word object
        foreach (string word in _allWords){
            _words.Add(new Word());
            _words[counter].SetWord(word);
            counter += 1;
        }
    }

    //HideWords method will be the one that'll almost all of the logic of my program
    public void HideWords(){ 
        //I need a variable to control the user decision, I'll define it as null at
        //The begining
        string _userDecision = null;
            //This do loop will make user press enter until there isn't any word object 
            //Inside of my list of objects also It'll allow me to print the whole scripture
            //without any word hidden yet
            do{ 
                DisplayScripture();
                Console.WriteLine($"Press enter to continue or type 'quit' to finish:");
                _userDecision = Console.ReadLine();
                Console.Clear();
                //Conditional if the user type quit finishing the program
                if (_userDecision != "quit"){
                    //For loop to hide three words each time the user press enter
                    //Although if a word is twice or more in the string and that word is
                    //Selected it'll hide more than four, likewise at the end could be left
                    //two or one word depending if all word's sum is a number divisible of 3
                    //or if in a moment there were hidden more than 3 words for what I mentioned
                    //before. 
                    for(int i = 0; i <= 2; i++){
                        //this conditional will control to make the program
                        //run when there is still left a word object inside of the list words
                        if(_words.Count >= 1){
                            int _randomNumber = _random.Next(0 , _words.Count-1);
                            _words[_randomNumber].SetText(_scripture);
                            _scripture =_words[_randomNumber].GetTextReplaced();
                            _words.RemoveAt(_randomNumber);
                        }else{

                            break;
                        }
                    }

                } else{

                    break;
                }

            }while(_words.Count-1 >= 0);
        //Last call to DisplayScripture method to print the scripture completely hidden before the program finishes
        DisplayScripture();
    }

    //DisplayScripture method to display the scripture it's a private method because it'll be used only inside of the class
    private void DisplayScripture(){
        Console.WriteLine($"{_reference}{_scripture}");
    }

}