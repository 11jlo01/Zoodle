using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target; //Target, målet, är spelkaraktären. Detta gör det möjligt att omvandla mellan kamerans och spelkaraktärens positioner.

	// Update is called once per frame
	void LateUpdate () { //void LateUpdate används istället för void Update för att få en senare uppdatering. 
        //Uppdateringen, förflyttningen av kameran, sker nu efter att spelkaraktären förflyttat sig.
		if (target.position.y > transform.position.y) //Förflyttning av kameran sker om spelkaraktärens 
            //y-koordinat har ett större värde än kamerans y-koordinat.
        {
            Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            //Den nya positionen för kameran sätts med hjälp av Vector3. 
            //Kameran behåller sin x och z koordinat medan y-koordinaten ändras till densamma som target, spelkaraktärens, y-koordinat.
            transform.position = newPos; // Den nya positionen sätts lika med kamerans position 
            //så att processen kan upprepas med samma kodslinga varje gång spelkaraktären rör sig, utan att ny kod behövs för varje förflyttning.
          
            
        }
	}
}
//Scriptet CameraFollow gör det möjligt för kameran att följa efter karaktären i höjdled 
//och inte stanna på samma ställe så att karaktären försvinner ur bild.