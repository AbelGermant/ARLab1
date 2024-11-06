using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class click : MonoBehaviour, IPointerClickHandler
{
    private static string BaseText = "Clicked :";
    private int ClickCount = 0;

    // Add a public field for the TextMeshProUGUI component
    public TextMeshProUGUI uiText;

    private void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // increment the click count
        ClickCount++;

        // set the text to the base text + the click count
        if (uiText != null)
        {
            uiText.text = BaseText + ClickCount;
        }
    }
}
