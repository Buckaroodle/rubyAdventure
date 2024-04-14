using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TMP_Text text;
    private int currentTextScore = -1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (currentTextScore == ScoreKeeper.currentScore){
            return;
        }

        currentTextScore = ScoreKeeper.currentScore;
        text.text = "Fixed Robots: " + currentTextScore.ToString();

    }
}
