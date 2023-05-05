using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSections : MonoBehaviour
{
    [SerializeField] private ObjectsVisibleRandomly _obstaclesVisibleRandomly;
    [SerializeField] private ObjectsVisibleRandomly _coinsVisibleRandomly;
    [SerializeField] private ObjectsVisibleRandomly _powerUpsVisibleRandomly;

    //public GameObject player;
    [SerializeField] private GameObject startSection;
    [SerializeField] private GameObject[] section;
    [SerializeField] private int spawningZPos = 32;
    [SerializeField] private int lengthOfSection = 32;
    //[SerializeField] private bool isSpawning = false;
    //[SerializeField] private int secNumber;
    public int numberOfTilesSpawningAtStart = 5;



    public void Awake()
    {
        //secNumber = Random.Range(0, numberOfTiles);

        Instantiate(startSection, new Vector3(-0.75f, 0, 0), Quaternion.identity);

        for (int i = 0; i <= numberOfTilesSpawningAtStart; i++)
        {


            SpawnTile(Random.Range(0, section.Length));
            
        }


    }


    public void SpawnTile(int indexTile)
    {
        _obstaclesVisibleRandomly.RandomSet();
        _coinsVisibleRandomly.RandomSet();
        _powerUpsVisibleRandomly.RandomSet();

        Instantiate(section[indexTile], new Vector3(-0.75f, 0, 1 * spawningZPos) , transform.rotation);
        spawningZPos += lengthOfSection;
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnTrigger"))
        {

            SpawnTile(Random.Range(0, section.Length));
            //spawningZPos -= lengthOfSection;

            Debug.Log("EnterTrigger - Instantiate Next Segment");
        }

    }
}
