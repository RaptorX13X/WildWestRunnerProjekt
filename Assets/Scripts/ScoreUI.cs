using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private GameObject player;

    public GameObject counter;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.GetComponent<TextMeshProUGUI>().text = "SCORE " + player.GetComponent<PlayerScore>().score.ToString();
    }
}
