using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Arrows : MonoBehaviour
{
    public TMP_Text displayText;
    public string[] texts;
    private int currentIndex = 0;

    void Start()
    {
        UpdateText();
    }

    void UpdateText()
    {
        displayText.text = texts[currentIndex];
    }

    public void NextText()
    {
        currentIndex = (currentIndex + 1) % texts.Length;
        UpdateText();
    }

    public void PrevText()
    {
        currentIndex = (currentIndex - 1 + texts.Length) % texts.Length;
        UpdateText();
    }
}