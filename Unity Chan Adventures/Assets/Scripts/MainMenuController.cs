using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public AudioSource buttonPress;

    private void Start()
    {
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene("RedirectLevel");
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void CreditsPlay()
    {
        buttonPress.Play();
        SceneManager.LoadScene("Credits");
    }
}
