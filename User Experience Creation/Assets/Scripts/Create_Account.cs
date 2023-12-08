using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Create_Account : MonoBehaviour
{
    public GameObject CreateAccountScreen;
    public Toggle TermsOfServiceBox;
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;
    public TextMeshProUGUI errorMessage;
    public TMP_InputField emailInput;

        
        public void OnButtonClicked()
    {
        // Check all boxes have info in them
        if (string.IsNullOrEmpty(usernameInput.text) ||  string.IsNullOrEmpty(passwordInput.text) || string.IsNullOrEmpty(emailInput.text))
     
     {
        // Error for when info isn't filled in
        errorMessage.text = "Please fill in all Information";
     }
     
        else if (!TermsOfServiceBox.isOn)
     {
        // TOS Box Ticked
        errorMessage.text = "Please accept the Terms of Service";
     }
        else
       {
        errorMessage.text = "";
       
        // Return to main menu screen
        if (CreateAccountScreen != null)
        {
            CreateAccountScreen.SetActive(false);
        }
       }
    }

       // Enter continues through to next page
        void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            OnButtonClicked();
        }
    }
}