using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Create_UI : MonoBehaviour
{
    public TMP_InputField inputField;
    public Button loadSceneButton;

    // List for Buttons
    public List<Button> buttons = new List<Button>();

    
    public void CheckProgress()
    {
        bool inputFieldNotEmpty = !string.IsNullOrEmpty(inputField.text);
        bool allButtonsSelected = true;

        // Check all buttons are interactable
        foreach (Button button in buttons)
        {
            if (!button.interactable)
            {
                allButtonsSelected = false;
                break;
            }
        }

        // Buttons are selected and input field has info in, continue
        if (allButtonsSelected && inputFieldNotEmpty)
        {
            // Enable the create button
            loadSceneButton.interactable = true;
        }
        else
        {
            // Keep button disabled if not ready
            loadSceneButton.interactable = false;
        }
    }

    public void LoadNextScene()
    {
        // Load next scene
        SceneManager.LoadScene("Character Select");
    }
}