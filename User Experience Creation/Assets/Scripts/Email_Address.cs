using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Email_Address : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TextMeshProUGUI errorMessage;
    public GameObject SentEmailScreen;
        
        public void OnButtonClicked()
    {
      // Box needs some info before sending email
      if (string.IsNullOrEmpty(emailInput.text))
        {
        errorMessage.text = "Please Add Email";
        }
        
        else
        {
            // If info is detected send email
            errorMessage.text = "";

            if (SentEmailScreen != null)
            {
                SentEmailScreen.SetActive(true);
            }
        }
    }
}