using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{
    public GameObject OpenMenu;
    public GameObject CloseMenu;
    
    public void OpenPopUp()
    {
        // If the pop-up is hidden in Hierarchy, open on click
        if (OpenMenu.activeInHierarchy == false)
        OpenMenu.SetActive(true);
        
        else OpenMenu.SetActive(false);
    }  
    public void ClosePopUp()
    { 
        // If the pop-up is open in Hierarchy, click to close
        if (CloseMenu.activeInHierarchy == true)
        CloseMenu.SetActive(false);
        
        else CloseMenu.SetActive(true);
    }
}
