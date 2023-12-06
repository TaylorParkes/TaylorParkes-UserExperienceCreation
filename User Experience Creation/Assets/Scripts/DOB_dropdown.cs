using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class DOB_dropdown : MonoBehaviour
{
    public TMP_Dropdown dayDropdown;
    public TMP_Dropdown monthDropdown;
    public TMP_Dropdown yearDropdown;

    void Start()
    {
        // Adds each day
        UpdateDaysDropdown();

        // Add each month into dropdown
        List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        List<TMP_Dropdown.OptionData> monthOptions = new List<TMP_Dropdown.OptionData>();
        foreach (string month in months)
        {
            monthOptions.Add(new TMP_Dropdown.OptionData(month));
        }
        monthDropdown.AddOptions(monthOptions);

        // Show each year from 2023 to 1900
        for (int year = 2023; year >= 1900; year--)
        {
            yearDropdown.options.Add(new TMP_Dropdown.OptionData(year.ToString()));
        }

        // Tells script when month and year has been changed 
        monthDropdown.onValueChanged.AddListener(delegate { UpdateDaysDropdown(); });
        yearDropdown.onValueChanged.AddListener(delegate { UpdateDaysDropdown(); });
    }

    void UpdateDaysDropdown()
    {
        int selectedMonth = monthDropdown.value + 1; // Select which Month
        int daysInMonth = System.DateTime.DaysInMonth(2023, selectedMonth); // Uses a non leap year to find out the correct days needed

        // Add and Remove incorrect days from each month
        dayDropdown.ClearOptions();
        List<TMP_Dropdown.OptionData> dayOptions = new List<TMP_Dropdown.OptionData>();
        for (int i = 1; i <= daysInMonth; i++)
        {
            dayOptions.Add(new TMP_Dropdown.OptionData(i.ToString()));
        }
        dayDropdown.AddOptions(dayOptions);
    }
}
