using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public static int scoreValue = 0;
    public static int highScoreValue = 0;
    public Text score;

    public Text highScore;

    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
        highScoreValue = PlayerPrefs.GetInt("highScore") ;

        highScore.text = "HighScore: " + highScoreValue;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }

    private void OnDisable() {
        if(scoreValue > highScoreValue) {
            PlayerPrefs.SetInt("highScore", scoreValue);
            PlayerPrefs.Save();
        }    
    }
}
