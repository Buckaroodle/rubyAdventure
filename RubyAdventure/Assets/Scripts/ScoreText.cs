using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TMP_Text text;
    private int currentTextScore = -1;
    private int currentTextCoins = -1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentTextScore == ScoreKeeper.currentScore && currentTextCoins == ScoreKeeper.currentCoins){
            return;
        }

        currentTextScore = ScoreKeeper.currentScore;
        currentTextCoins = ScoreKeeper.currentCoins;
        text.text = "Fixed Robots: " + currentTextScore.ToString() + "\nCoins: " + currentTextCoins.ToString();

    }
}
