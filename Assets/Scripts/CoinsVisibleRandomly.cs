using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoinsVisibleRandomly : MonoBehaviour
{

    [SerializeField] private GameObject[] objectsToToggle;
    [SerializeField] private float visibilityRatio = 0.55f;

    private void Awake()
    {
      
        foreach (GameObject obj in objectsToToggle)
        {
            obj.SetActive(Random.value > visibilityRatio);
        }

    }
}
