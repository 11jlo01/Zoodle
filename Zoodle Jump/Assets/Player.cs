using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] //
public class Player : MonoBehaviour {

    public float movementSpeed = 10f; //Gör det möjligt att bestämma/ändra karaktärens hastighet.

    Rigidbody2D rb; //
    float movement = 0f; //
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>(); //
	}
	
	// Update is called once per frame
	void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed; //
	}

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity; //
        velocity.x = movement; //
        rb.velocity = velocity; //
    }
}
//Scriptet player justerar spelfigurens hastighet och gör det möjligt att styra karaktären i sidled med piltangenterna.