using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Graphic_DropDown : MonoBehaviour
{
    public TMP_Dropdown DisplayDropdown;
    public TMP_Dropdown ResolutionDropdown;
    public TMP_Dropdown TextureDropdown;
    public TMP_Dropdown ShadowsDropdown;

    void Start()
    {

        // Add each display options into dropdown
        List<string> displays = new List<string> {"Fullscreen","Windowed", "Windowed Fullscreen"};

        List<TMP_Dropdown.OptionData> DisplayOptions = new List<TMP_Dropdown.OptionData>();
        foreach (string display in displays)
        {
            DisplayOptions.Add(new TMP_Dropdown.OptionData(display));
        }
        DisplayDropdown.AddOptions(DisplayOptions);
                
                
        // Add each texture options into dropdown
        List<string> Textures = new List<string> {"High", "Medium" , "Low"};

        List<TMP_Dropdown.OptionData> TextureOptions = new List<TMP_Dropdown.OptionData>();
        foreach (string Texture in Textures)
        {
            TextureOptions.Add(new TMP_Dropdown.OptionData(Texture));
        }
        TextureDropdown.AddOptions(TextureOptions);
        
        
        // Add each Resolution options into dropdown
        List<string> Resolutions = new List<string> {"2560 x 1440", "1920 x 1080" , "1280 x 720"};

        List<TMP_Dropdown.OptionData> ResolutionOptions = new List<TMP_Dropdown.OptionData>();
        foreach (string Resolution in Resolutions)
        {
            ResolutionOptions.Add(new TMP_Dropdown.OptionData(Resolution));
        }
        ResolutionDropdown.AddOptions(ResolutionOptions);

        // Add each Resolution options into dropdown
        List<string> Shadows = new List<string> {"High", "Medium" , "Low"};

        List<TMP_Dropdown.OptionData> ShadowOptions = new List<TMP_Dropdown.OptionData>();
        foreach (string Shadow in Shadows)
        {
            ShadowOptions.Add(new TMP_Dropdown.OptionData(Shadow));
        }
        ShadowsDropdown.AddOptions(ShadowOptions);

    }
}