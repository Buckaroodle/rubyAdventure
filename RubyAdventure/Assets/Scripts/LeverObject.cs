using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverObject : MonoBehaviour
{
    public GameObject closedGate;
    public GameObject openGate;
    public GameObject upLever;
    public GameObject downLever;

    public void LeverHit()
    {
       // Debug.Log("TEST");
        upLever.SetActive(false);
        downLever.SetActive(true);
        closedGate.SetActive(false);
        openGate.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        upLever.SetActive(true);
        downLever.SetActive(false);
        closedGate.SetActive(true);
        openGate.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
