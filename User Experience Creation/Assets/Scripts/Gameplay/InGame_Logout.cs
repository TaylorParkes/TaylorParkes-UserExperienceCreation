using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGame_Logout : MonoBehaviour
{
    public void Logout()
    {
        SceneManager.LoadScene("Character Select");
    }
}