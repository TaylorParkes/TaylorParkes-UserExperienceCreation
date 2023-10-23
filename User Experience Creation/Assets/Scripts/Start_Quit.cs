using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Quit : MonoBehaviour
{
    // Load Character Select
    public void Login()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
    // Close Game
    public void QuitGame()
    {
        Debug.Log ("Quit");
        Application.Quit();
    }
}
