using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NonPlayerCharacter : MonoBehaviour
{
    public float displayTime = 4.0f;
    public GameObject dialogBox;
    public GameObject pressX;
    float timerDisplay;
    public AudioClip sfx;
    private AudioSource audioSource;
    
    void Start()
    {
        pressX.SetActive(true);
        dialogBox.SetActive(false);
        timerDisplay = -1.0f;

        audioSource = GetComponent<AudioSource>();
    }
    
    void Update()
    {
        if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                dialogBox.SetActive(false);
            }
        }
    }
    
    public void DisplayDialog()
    {
        timerDisplay = displayTime;
        pressX.SetActive(false);
        dialogBox.SetActive(true);
        PlaySound(sfx);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }
}
