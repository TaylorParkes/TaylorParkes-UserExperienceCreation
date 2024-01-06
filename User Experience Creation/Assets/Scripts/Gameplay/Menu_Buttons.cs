using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Buttons : MonoBehaviour
{
    // Reference to your vendor pop-up GameObject
    public GameObject vendorPopup;
    public GameObject mapPopup;
    public GameObject spellsPopup;
    public GameObject invPopup;

    void Start()
    {
        // Disable the vendor pop-up initially
        vendorPopup.SetActive(false);
    }

    void Update()
    {
        // Check if the 'V' key is pressed
        if (Input.GetKeyDown(KeyCode.V))
        {
            // Toggle the visibility of the vendor pop-up
            vendorPopup.SetActive(!vendorPopup.activeSelf);
        }

        if(Input.GetKeyDown(KeyCode.M))
        {
            mapPopup.SetActive(!mapPopup.activeSelf);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            spellsPopup.SetActive(!spellsPopup.activeSelf);
        }
               
        if(Input.GetKeyDown(KeyCode.E))
        {
            invPopup.SetActive(!invPopup.activeSelf);
        }
    }
}