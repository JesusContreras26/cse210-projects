using System;

public class DicScriptures{

        //List of dictionary that will use to select random scriptures every time the program runs
        private List<Dictionary<string, string>> Scriptures = new List<Dictionary<string, string>>();

        private void assignDictionary(){
        Scriptures.Add(new Dictionary<string, string>());
        Scriptures[0].Add("Book", "John");
        Scriptures[0].Add("Chapter", "3");
        Scriptures[0].Add("FirstVerse", "16");
        Scriptures[0].Add("Scripture", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        Scriptures.Add(new Dictionary<string, string>());
        Scriptures[1].Add("Book", "Proverbs");
        Scriptures[1].Add("Chapter", "3");
        Scriptures[1].Add("FirstVerse", "5");
        Scriptures[1].Add("LastVerse", "6");
        Scriptures[1].Add("Scripture", "Trust in the Lord with all thine heart; and lean not unto thine cown understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        Scriptures.Add(new Dictionary<string, string>());
        Scriptures[2].Add("Book", "Mosiah");
        Scriptures[2].Add("Chapter", "2");
        Scriptures[2].Add("FirstVerse", "41");
        Scriptures[2].Add("Scripture", "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");

        Scriptures.Add(new Dictionary<string, string>());
        Scriptures[3].Add("Book", "James");
        Scriptures[3].Add("Chapter", "1");
        Scriptures[3].Add("FirstVerse", "5");
        Scriptures[3].Add("LastVerse", "6");
        Scriptures[3].Add("Scripture", "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him. But let him ask in faith, nothing wavering. For he that wavereth is like a wave of the sea driven with the wind and tossed.");
        }

        public List<Dictionary<string, string>> getScriptures(){
            assignDictionary();
            return Scriptures;
        }


}