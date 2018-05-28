using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour {

    public float jumpForce = 10f; //Hur stor kraften är som ger studsen

	void OnCollisionEnter2D(Collision2D collision) //Ger information om vad ett som händer med då ett objekt krockar med ett annat objekt 
    {
        if (collision.relativeVelocity.y <= 0f) //Collision är en variabel som innehåller information om kollisionen (hastighet, typ av objekt osv)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>(); //Objekten som kolliderar är av typen Rigidbody2D
                if (rb != null) //Om objektet av typen Rigidbody2D inte är lika med null
                    {
                          Vector2 velocity = rb.velocity;
                          velocity.y = jumpForce;
                          rb.velocity = velocity; //Adderar kraft som ger studs uppåt
                    }
        }

        
    } //Då ett objekt krockar med ett annat så utförs koden inom måsvingarna (funktionen)
}
