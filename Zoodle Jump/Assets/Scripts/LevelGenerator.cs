using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab; //Objektet vi jobbar med här är plattform som är en prefab

    public int numberOfPlatforms = 200; //Gör det möjligt att ändra/bestämma antalet plattformar
    public float levelWidth = 3f; //Gör det möjligt att bestämma plattformarnas position i x-led. (Hur långt ut från mitten de får vara)
    public float minY = .2f;
    public float maxY = 1.5f; //Gör det möjligt att ändra/bestämma plattformarnas, i förhållande till varandra, position i y-led.

    // Use this for initialization
    void Start () {

        Vector3 spawnPosition = new Vector3(); // Vector3 används av Unity för att processera positioner (var saker befinner sig).
        
		for (int i = 0; i < numberOfPlatforms; i++) //En for-loop, variabeln i tilldelas värdet 0, 
            //därefter kollar funktionen om i är mindre än antal plattformar och om det stämmer så ökar i med 1 och det som står i måsvingarna utförs. 
            //Loopen fortsätter ända tills det att vilkoret i är mindre än antal plattformar inte längre uppfylls.
        {
            spawnPosition.y += Random.Range(minY, maxY); //Gör att man kan bestämma minsta respektive största möjliga mellanrum mellan plattformarna i y-led. 
            //Om avståndet är för långt blir nivån omöjlig, ju kortade avstånd, skillnad mellan max och min, detso lättare blir det att spela
            spawnPosition.x = Random.Range(-levelWidth, levelWidth); //Bestämmer plattformarnas positioner i x-led så att de hamnar i bild.
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
} //LevelGenerator och ExtremeJumpGenerator har inställningar så att man kan bestämma till exempel hur stort avståndet mellan plattformarna är samt hur många plattformar som finns.
