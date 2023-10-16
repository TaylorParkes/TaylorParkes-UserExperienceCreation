using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitMenu_PopUp : MonoBehaviour
{
    
    public GameObject QuitMenu;


    public void OpenQuitMenu()
    {
        if (QuitMenu.activeInHierarchy == false)
        QuitMenu.SetActive(true);
        
        else QuitMenu.SetActive(false);

    }  
    public GameObject CloseMenu;


    public void CloseQuitMenu()
    {
        if (CloseMenu.activeInHierarchy == true)
        CloseMenu.SetActive(false);
        
        else CloseMenu.SetActive(true);
    }
}