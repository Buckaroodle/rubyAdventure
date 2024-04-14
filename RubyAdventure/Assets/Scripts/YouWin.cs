using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    [SerializeField]private GameObject YouWinGameObject;

    // Start is called before the first frame update
    void Start()
    {
        YouWinGameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreKeeper.currentScore >= 2){
            YouWinGameObject.SetActive(true);
        }
        else {
            YouWinGameObject.SetActive(false);
        }
       // Debug.Log(ScoreKeeper.currentScore);
    }
}
