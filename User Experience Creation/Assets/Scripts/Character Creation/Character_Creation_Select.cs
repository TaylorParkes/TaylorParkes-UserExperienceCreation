using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character_Creation_Select : MonoBehaviour
{
    private List<Selectable> selectedItems = new List<Selectable>();
    public Sprite selectedImage;
    public Sprite defaultImage;
    
    
    public void SelectItem(Selectable item)
    {
        if (!selectedItems.Contains(item))
        {
            selectedItems.Add(item);
            // Swap to Selected Image
            Image image = item.GetComponent<Image>();
            if (image != null && selectedImage != null)
            {
                image.sprite = selectedImage;
            }
        }
        else
        {
            selectedItems.Remove(item);
            // Swap back to default image
            Image image = item.GetComponent<Image>();
            if (image != null && defaultImage != null)
            {
                image.sprite = defaultImage;
            }
        }
    }

    // Works on selected item
    public void OnSelectedItems()
    {
        foreach (var selectedItem in selectedItems)
        {
            // Work on each time an item is selected
            Debug.Log("Selected Item: " + selectedItem.name);
        }
    }
}