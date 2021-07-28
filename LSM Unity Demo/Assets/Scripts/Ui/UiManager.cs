using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject inventoryPanel;
    public GameObject shopPanel;
    public Button interactButton;

    private bool isNearShop = false;

    public void UseInteractButton()
    {
        if (isNearShop)
        {
            shopPanel.SetActive(true);
        }
        else
        {
            inventoryPanel.SetActive(true);
        }
    }

    public void SetInteractButtonFunc()
    {
        isNearShop = !isNearShop;

        if (isNearShop)
        {
            interactButton.GetComponentInChildren<Text>().text = "TRADE ITEMS";
        }
        else
        {
            interactButton.GetComponentInChildren<Text>().text = "MY ITEMS";
        }
    }
}
