using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatBox : MonoBehaviour
{
    public TMP_InputField inputField;
    public TextMeshProUGUI chatText;

    void Start()
    {
        // Subscribe to the onEndEdit event of the input field to handle user input
        inputField.onEndEdit.AddListener(SubmitMessage);
    }

    void SubmitMessage(string message)
    {
        if (!string.IsNullOrEmpty(message))
        {
            // Append the message to the chat text
            chatText.text += $"User: {message}\n";

            // Clear the input field
            inputField.text = "";

            // Optionally, scroll to the bottom to show the latest message
            ScrollToBottom();
        }
    }

    void ScrollToBottom()
    {
        // If you have a ScrollRect, adjust its vertical normalized position to scroll to the bottom
        ScrollRect scrollRect = chatText.GetComponentInParent<ScrollRect>();
        if (scrollRect != null)
        {
            Canvas.ForceUpdateCanvases(); // Ensure layout is updated before adjusting position
            scrollRect.verticalNormalizedPosition = 0f;
        }
    }
}