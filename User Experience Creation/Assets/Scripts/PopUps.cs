using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{
    // Opening Menu PopUps
    public GameObject OpenMenu;
    
    public void OpenPopUp()
    {
        if (OpenMenu.activeInHierarchy == false)
        OpenMenu.SetActive(true);
        
        else OpenMenu.SetActive(false);

    } 
    // Close Menu PopUps
    public GameObject CloseMenu;
    
    public void ClosePopUp()
    {
        if (CloseMenu.activeInHierarchy == true)
        CloseMenu.SetActive(false);
        
        else CloseMenu.SetActive(true);
    }
}
