using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip collectedClip;

    void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            Destroy(gameObject);
            ScoreKeeper.currentCoins = ScoreKeeper.currentCoins + 1;
            controller.PlaySound(collectedClip);
            
        }

    }
}
