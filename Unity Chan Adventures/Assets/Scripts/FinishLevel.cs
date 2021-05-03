using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public GameObject levelBlocker;
    public GameObject fadeOut;

    public int timeCalc;
    public int scoreCalc;
    public int totalScored;
    

    void OnTriggerEnter()
    {
        GetComponent<BoxCollider>().enabled = false;
        levelBlocker.SetActive(true);
        levelBlocker.transform.parent = null;
        timeCalc = GlobalTimer.extendScore;
        timeLeft.GetComponent<Text>().text = "Time Left: " + timeCalc + " X 100";
        timeCalc *= 100;

        scoreCalc = GlobalScore.currentScore;
        theScore.GetComponent<Text>().text = "Score: " + scoreCalc;

        totalScored = timeCalc + scoreCalc;
        totalScore.GetComponent<Text>().text = "Total: " + totalScored;

        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
        
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.75f);

        theScore.SetActive(true);
        yield return new WaitForSeconds(0.75f);

        totalScore.SetActive(true);
        yield return new WaitForSeconds(2f);

        fadeOut.SetActive(true);

        yield return new WaitForSeconds(2f);
        RedirectToLevel.LoadNextLevel();

    }
}
