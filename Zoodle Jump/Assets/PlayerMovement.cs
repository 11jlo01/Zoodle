
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	// Update is called once per frame
	void FixedUpdate () {
		if (rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (rb.position.x < -4.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        if (rb.position.y < 4.5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
