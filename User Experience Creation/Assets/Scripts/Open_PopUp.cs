using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open_PopUp : MonoBehaviour
{

    public GameObject AreYouSure;


    public void ClickButton()
    {
        if (AreYouSure.activeInHierarchy == false)
        AreYouSure.SetActive(true);
        
        else AreYouSure.SetActive(false);
    }
}
