using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings_Screen : MonoBehaviour
{
    public static bool PausedGame = false;
    public GameObject PauseMenu;


    void Update()
    {
        // Pause the game when player presses Escape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(PausedGame)
            {
                Resume();
            }
            else // Unpause game if Escape is pressed again
            {
                Paused();
            }
        }
    }

    public void Resume()
    {
        // Resumes Ingame time
        PauseMenu.SetActive(true);
        PausedGame = true;
    }

    void Paused()
    {
        // Stops Ingame time
       PauseMenu.SetActive(false);
       PausedGame = false; 
    }
}