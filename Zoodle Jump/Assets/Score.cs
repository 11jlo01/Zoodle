using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text ScoreText;
	
	// Update is called once per frame
	void Update () {
        ScoreText.text = player.position.y.ToString("0");
	}
}
