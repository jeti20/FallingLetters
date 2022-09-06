using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] //variables to show up in unity
public class Word //sama klasa 
{
    public string word;
    private int typeIndex;

    WordDisplay dispaly;

    public Word (string _word, WordDisplay _display) //konstruktor 
    {
        word = _word;
        typeIndex = 0;

        dispaly = _display;
        dispaly.SetWord(word);
    }

    public char GetNextLetter()
    {
        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        dispaly.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            dispaly.RemoveWord();
        }
        return wordTyped;
    }
}
