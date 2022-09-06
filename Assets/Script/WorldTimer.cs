using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTimer : MonoBehaviour
{
    public WordManager wordManager;

    public float wordDely = 1.5f;
    public float nextWordtime = 0f;

    private void Update()
    {
        if (Time.time >= nextWordtime)
        {
            wordManager.AddWord();
            nextWordtime = Time.time + wordDely;
            wordDely *= 0.99f;
        }
    }
}
