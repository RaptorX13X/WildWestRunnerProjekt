using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject distanceCount;
    public GameObject counter;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.GetComponent<TextMeshProUGUI>().text = "SCORE " + player.GetComponent<PlayerScore>().score.ToString();
        distanceCount.GetComponent<TextMeshProUGUI>().text =
            "DISTANCE " + player.GetComponent<DistanceCounter>().distance.ToString("##.") + "m";
    }
}
