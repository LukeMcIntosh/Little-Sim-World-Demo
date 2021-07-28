using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : UiPanelBase
{

    private void OnEnable()
    {
        Initialize(false);
    }

    public override void Initialize(bool isShop)
    {
        base.Initialize(isShop);

    }

    public override void SetUp()
    {
        for (int i = 0; i < spawnedIcons.Count; i++)
        {
            spawnedIcons[i].equippedImage.gameObject.SetActive(false);

            if (spawnedIcons[i].myItemsId == PreferenceManager.CurrentChest ||
                spawnedIcons[i].myItemsId == PreferenceManager.CurrentHat ||
                spawnedIcons[i].myItemsId == PreferenceManager.CurrentLegs)
            {
                spawnedIcons[i].equippedImage.gameObject.SetActive(true);
            }

            if (ClothingData.instance.CheckOwnership(spawnedIcons[i].myItemsId))
            {
                spawnedIcons[i].CoverImage.gameObject.SetActive(false);
            }
            else
            {
                spawnedIcons[i].CoverImage.gameObject.SetActive(true);
            }
        }
    }

    public override void OnIconClicked(ClothingIcon iconClicked)
    {
        if (iconClicked.myType == ITEM_SLOT.CHEST)
        {
            PreferenceManager.CurrentChest = iconClicked.myItemsId;
        }

        if (iconClicked.myType == ITEM_SLOT.LEGS)
        {
            PreferenceManager.CurrentLegs = iconClicked.myItemsId;
        }

        if (iconClicked.myType == ITEM_SLOT.HEAD)
        {
            PreferenceManager.CurrentHat = iconClicked.myItemsId;
        }

        ClothingData.instance.clothingManager.SetClothing();
        iconClicked.owner.SetUp();
    }
}
