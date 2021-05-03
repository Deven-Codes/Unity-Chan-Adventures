using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pausedMenu;
    public AudioSource pauseSound;

    // Pause the game 
    private void pauseGame()
    {
        Time.timeScale = 0; // pause every thing  
        gamePaused = true;
        Cursor.visible = true;
        levelMusic.Pause();
        pausedMenu.SetActive(true);
    }

    //Unpause the game
    private void unPauseGame()
    {
        Time.timeScale = 1; // every thing will run at normal speed
        gamePaused = false;
        levelMusic.UnPause();
        pausedMenu.SetActive(false);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            pauseSound.Play();
            if (gamePaused == false)
            {
                pauseGame();
            }
            else
            {
                unPauseGame();
            }
        } 
    }

    public void ResumeGame()
    {
        pauseSound.Play();
        unPauseGame();
    }

    public void RestartLevel()
    {
        unPauseGame();
        SceneManager.LoadScene("RedirectLevel");
    }

    public void QuitToMenu()
    {
        unPauseGame();
        SceneManager.LoadScene("MainMenu");
    }
}
