using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WinScreenCoins : MonoBehaviour
{
    private TMP_Text text;
    private int currentWinCoins = -1;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentWinCoins == ScoreKeeper.currentCoins){
            return;
        }

        currentWinCoins = ScoreKeeper.currentCoins;

        text.text = "You Win! (and collected " + currentWinCoins.ToString() + " Coins!)\nGame created by:\nAaron Lurie\nKeily Linares";
    }
}
