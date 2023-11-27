using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Login_Check : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI errorMessage;

        
        public void OnButtonClicked()
    {
        if (string.IsNullOrEmpty(usernameInput.text) ||  string.IsNullOrEmpty(passwordInput.text))
     
     {
        errorMessage.text = "Account not Found";
     }
    else
       {
        errorMessage.text = "";

        SceneManager.LoadScene("Character Select");
       }
    }

        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            OnButtonClicked();
        }
    }
}