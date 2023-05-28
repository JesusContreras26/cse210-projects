using System;

// Word Class will be use to hide the word of each word object type
public class Word{
    // Definining and declaring variables that'll use all of them are private
    // So people outside of the programn won't be able to access them
    // Inside of them won't be anything yet
    private string _word;
    private string _hiddenWord; 
    private string _text;

    // Populating my variables with setters and getters
    public void SetWord(string word){
        _word = word;
        // This method will help me to know how many times the character '_' will be repeated
        // I'll repeat '_' _word.Length times
        _hiddenWord = String.Concat(Enumerable.Repeat("_",_word.Length));  
    }

    public void SetText(string text){
        _text = text;
    }
    public string GetTextReplaced(){
        // This method will return the text with the word replaced
        // I used replace method to switch the word with the hiddenWord
        // Also I added spaces at the beginning and at the end of the item
        // That will be replace and the one that will replace it
        // on my main class program I added spaces at the beginning and at the end
        // of the text when it's pass as an argument, doing this first and last word 
        // Will be also replaced when they are selected randomly
        _text = _text.Replace($" {_word} ", $" {_hiddenWord} ");
        return _text;
    }
}