using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WordDisplay : MonoBehaviour
{

    public float fallSpeed = 1f;
    public Text text;

	public void SetWord(string word)
	{
		text.text = word;
	}

	public void RemoveLetter ()
    {
		text.text = text.text.Remove(0, 1);
    }

	public void RemoveWord()
    {
		Destroy(gameObject);
    }

    //opadanie
    private void Update()
    {
        transform.Translate(0f, -fallSpeed * Time.deltaTime, 0f);
    }

}
