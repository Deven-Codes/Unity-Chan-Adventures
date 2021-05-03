using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public GameObject timeDisplay02;
    public bool isTakingTime = false;
    public int theSeconds = 150;
    public int delaySeconds = 1;
    public static int extendScore;

    private void Update() 
    {
        extendScore = theSeconds;
        if(!isTakingTime) 
        {
            StartCoroutine("SubtractSecond");
        }
    }

    IEnumerator SubtractSecond() 
    {
        isTakingTime = true;
        theSeconds -= delaySeconds;
        timeDisplay01.GetComponent<Text>().text = theSeconds.ToString();
        timeDisplay02.GetComponent<Text>().text = theSeconds.ToString();

        yield return new WaitForSeconds(delaySeconds);

        isTakingTime = false;
    }
}
