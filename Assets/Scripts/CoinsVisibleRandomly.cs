using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsVisibleRandomly : MonoBehaviour
{

    public GameObject[] objectsToToggle;

    void Start()
    {
      
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(Random.value > 0.7f);
        }


    }
}
