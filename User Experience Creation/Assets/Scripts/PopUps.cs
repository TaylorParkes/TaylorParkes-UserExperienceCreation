using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUps : MonoBehaviour
{
    
    public GameObject QuitMenu;


    public void OpenPopUp()
    {
        if (QuitMenu.activeInHierarchy == false)
        QuitMenu.SetActive(true);
        
        else QuitMenu.SetActive(false);

    }  
    public GameObject CloseMenu;


    public void ClosePopUp()
    {
        if (CloseMenu.activeInHierarchy == true)
        CloseMenu.SetActive(false);
        
        else CloseMenu.SetActive(true);
    }
}
