using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject closedGate;
    public GameObject openGate;
    public GameObject upLever;
    public GameObject downLever;

    void Start()
    {
        upLever.SetActive(true);
        downLever.SetActive(false);
        closedGate.SetActive(true);
        openGate.SetActive(false);
    }
    
    public void Hit()
    {
        upLever.SetActive(false);
        downLever.SetActive(true);
        closedGate.SetActive(false);
        openGate.SetActive(true);
    }
}
