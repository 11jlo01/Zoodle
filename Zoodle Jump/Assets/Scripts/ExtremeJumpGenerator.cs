using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtremeJumpGenerator : MonoBehaviour {

    public GameObject platformPrefab;

    public int numberOfPlatforms = 200;
    public float levelWidth = 3f;
    public float minY = .2f;
    public float maxY = 1.5f;

    // Use this for initialization
    void Start()
    {

        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
} //ExtremeJumpGenerator fungerar på samma sätt som LevelGenerator gör. Skillnaden är att det nu är objektet, plattformen, studsmatta som genereras.

