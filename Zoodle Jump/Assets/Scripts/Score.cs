using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text ScoreText;
    float highestScore = 0;
	
	// Update is called once per frame
	void Update () {
        if(player.position.y > highestScore)
        {
            highestScore = player.position.y;
        }
        ScoreText.text = highestScore.ToString("0");
	}
}
