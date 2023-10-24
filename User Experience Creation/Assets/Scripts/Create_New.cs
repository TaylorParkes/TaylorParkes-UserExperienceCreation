using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Create_New : MonoBehaviour
{     
    
    public void NewCharacter()
    {
        SceneManager.LoadScene("Character Create");
    }
}
