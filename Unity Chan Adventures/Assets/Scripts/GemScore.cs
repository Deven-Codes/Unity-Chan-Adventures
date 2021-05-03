using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemScore : MonoBehaviour
{
    public int score;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += score;      
        collectSound.Play();
        Destroy(gameObject);
    }
}
