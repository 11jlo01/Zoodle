
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Update is called once per frame

    Rigidbody2D rb;
    public Transform camera;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

	void FixedUpdate () {
        if (rb.position.y < camera.position.y - 6f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        //if (rb.position.x < 4.5-f)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
        //if (rb.position.x > 4.5f)
        //{
        //    FindObjectOfType<GameManager>().EndGame();
        //}
    }
}
