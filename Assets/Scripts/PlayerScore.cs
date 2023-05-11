using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void AddScore()
    {
        score += 1;
        Debug.Log("Score = " + score);
    }
}
