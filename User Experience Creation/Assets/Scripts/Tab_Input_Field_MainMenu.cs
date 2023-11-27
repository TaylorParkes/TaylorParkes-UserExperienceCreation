using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Tab_Input_Field_MainMenu : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            TMP_InputField currentInputField = EventSystem.current.currentSelectedGameObject.GetComponent<TMP_InputField>();

            if (currentInputField == usernameInput)
            {
                passwordInput.Select();
            }
            else if (currentInputField == passwordInput)
            {
                usernameInput.Select();
            }
        }
    }
}
