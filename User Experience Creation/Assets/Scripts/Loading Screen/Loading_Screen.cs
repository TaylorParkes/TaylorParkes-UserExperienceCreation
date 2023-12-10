using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading_Screen : MonoBehaviour
{
    public float LoadTime = 3f; // Time for the loading screen

    void Start()
    {
        Invoke("LoadNextScene", LoadTime);
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
