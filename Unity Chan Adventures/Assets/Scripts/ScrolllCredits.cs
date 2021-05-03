using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrolllCredits : MonoBehaviour
{
    public GameObject credits;

    private void Start()
    {
        StartCoroutine(RollCreds());
    }

    IEnumerator RollCreds()
    {
        yield return new WaitForSeconds(0.5f);
        credits.SetActive(true);
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene("MainMenu");
    }

}
