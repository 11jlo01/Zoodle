using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //Säkerställer att det alltid finns en Rigidbody2D-komponent kopplad till koden
public class Player : MonoBehaviour {

    public float movementSpeed = 10f;//Gör det möjligt att bestämma/ändra karaktärens hastighet.
    public Vector3 startPos;

    Rigidbody2D rb; //Objektet Rigidbody2D också kallad rb

    float movement = 0f; //Variabeln movement tilldelas värdet 0.
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>(); //rb tilldelas komponenten Rigidbody2D
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed; //Vi vill kunna flytta karaktären horistontalt, allstå i x-led. 
        //Variabeln movement tilldelas ett värde baserat på hur vi styr den (piltangenterna) och hastigheten den förflyttar sig med.
	}

    void FixedUpdate() //Rörelser ligger i FixedUpdate
    {
        Vector2 velocity = rb.velocity; //Hämtar hastigheten, gör det möjligt att bestämma hur snabbt spelkaraktären 
        //ska röra sig då vänster respektive höger piltangent trycks ned.
        velocity.x = movement; //Variabeln movement tilldelas samma värde som hastigheten i x-led.
        rb.velocity = velocity; //Velocity tilldelas samma värde som hastigheten hos våran rigidbody, 
        //alltså kan samma kodslinga nu användas igen, man kan säga att den blir nollställd. 
        //Ny kod behövs allstå inte skrivas för varje gång karaktären flyttar sig igen. 
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "DeadZone")
    //    {
    //        //GetComponent<Rigidbody2D>() = false; 
    //    }
    //}
   
}
//Scriptet player justerar spelfigurens hastighet och gör det möjligt att styra karaktären i sidled med piltangenterna.