using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_Quit : MonoBehaviour
{
    // Load Character Select
    public void Login()
    {
        SceneManager.LoadScene("Gameplay");
    }
    
    // Close Game
    public void QuitGame()
    {
        Debug.Log ("Quit");
        Application.Quit();
    }
}
