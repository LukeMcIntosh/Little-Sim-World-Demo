using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPanelBase : MonoBehaviour
{
    public GameObject clothingIconPrefab;
    public GameObject hatsParent;
    public GameObject chestParent;
    public GameObject legsParent;

    protected List<ClothingIcon> spawnedIcons = new List<ClothingIcon>();

    public virtual void Initialize(bool isShop)
    {
        if (spawnedIcons.Count == 0)
        {
            for (int i = 0; i < ClothingData.instance.allClothesScriptables.Count; i++)
            {
                //ClothingIcon icon;
                //GameObject go = new GameObject();

                if (ClothingData.instance.allClothesScriptables[i].myItemSlot == ITEM_SLOT.CHEST)
                {
                    GameObject go = Instantiate(clothingIconPrefab, chestParent.transform);
                    ClothingIcon icon = go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();
                    icon.SetUpIcon(false, ClothingData.instance.allClothesScriptables[i].myItemSlot, ClothingData.instance.allClothesScriptables[i].myId,
                        ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0]);
                    icon.owner = this;

                    spawnedIcons.Add(icon);
                }

                if (ClothingData.instance.allClothesScriptables[i].myItemSlot == ITEM_SLOT.LEGS)
                {
                    GameObject go = Instantiate(clothingIconPrefab, legsParent.transform);
                    ClothingIcon icon = go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();
                    icon.SetUpIcon(false, ClothingData.instance.allClothesScriptables[i].myItemSlot, ClothingData.instance.allClothesScriptables[i].myId,
                        ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0]);
                    icon.owner = this;

                    spawnedIcons.Add(icon);
                }

                if (ClothingData.instance.allClothesScriptables[i].myItemSlot == ITEM_SLOT.HEAD)
                {
                    GameObject go = Instantiate(clothingIconPrefab, hatsParent.transform);
                    ClothingIcon icon = go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();
                    icon.SetUpIcon(false, ClothingData.instance.allClothesScriptables[i].myItemSlot, ClothingData.instance.allClothesScriptables[i].myId,
                        ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0]);
                    icon.owner = this;

                    spawnedIcons.Add(icon);
                }

            }

        }

        SetUp();
    }

    public virtual void SetUp()
    {
    }

    public virtual void OnIconClicked(ClothingIcon iconClicked)
    {
    }
}
