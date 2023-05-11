using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private GameObject collectible;
    [SerializeField] private GameObject player;
    

    private void Start()
    {
        
    }

    public void Collect()
    {
        collectible.SetActive(false);
    }

    public void AddPoints()
    {
        player.GetComponent<PlayerScore>().AddScore();
    }

    public void AddHealth()
    {
        player.GetComponent<HealthController>().AddHealth();
    }
}
