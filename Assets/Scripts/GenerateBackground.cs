using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour
{
    
    [SerializeField] private GameObject background;
    [SerializeField] private int spawningZPos = 32;
    [SerializeField] private int lengthOfSection = 32;
    //[SerializeField] private bool isSpawning = false;
    //[SerializeField] private int secNumber;
    public int numberOfTilesSpawningAtStart = 5;



    


    public void SpawnBackground()
    {
       

        Instantiate(background, new Vector3(-19.1f, -6.5f, 1 * spawningZPos), transform.rotation);
        spawningZPos += lengthOfSection;

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnTrigger"))
        {

            SpawnBackground();
            //spawningZPos -= lengthOfSection;

            
        }

    }
}
