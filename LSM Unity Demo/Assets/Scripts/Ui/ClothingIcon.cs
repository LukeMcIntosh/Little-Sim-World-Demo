using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothingIcon : MonoBehaviour
{
    public Inventory inventory;
    public Image myIcon;
    public ITEM_SLOT myType;
    public Image equippedImage;
    public int myItemsId;

    public void OnClicked()
    {
        if(myType == ITEM_SLOT.CHEST)
        {
            PreferenceManager.CurrentChest = myItemsId;
        }

        if (myType == ITEM_SLOT.LEGS)
        {
            PreferenceManager.CurrentLegs = myItemsId;
        }

        if (myType == ITEM_SLOT.HEAD)
        {
            PreferenceManager.CurrentHat = myItemsId;
        }

        ClothingData.instance.clothingManager.SetClothing();
        inventory.SetEquipped();
    }

}
