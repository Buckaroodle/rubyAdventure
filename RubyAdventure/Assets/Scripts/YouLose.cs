using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouLose : MonoBehaviour
{
    [SerializeField]private GameObject LossContents;

    // Start is called before the first frame update
    void Start()
    {
        LossContents.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (RubyController.Instance.health <= 0){
            LossContents.SetActive(true);
        }
        else {
            LossContents.SetActive(false);
        }
        //Debug.Log(ScoreKeeper.currentScore);
    }
}
