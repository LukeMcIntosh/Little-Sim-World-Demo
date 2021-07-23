using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject clothingIconPrefab;

    public GameObject hatsParent;
    public GameObject chestParent;
    public GameObject legsParent;


    private List<ClothingIcon> spawnedIcons = new List<ClothingIcon>();

    private void OnEnable()
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
                    ClothingIcon icon  =go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();

                    icon.myIcon.sprite = ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0];
                    icon.myItemsId = ClothingData.instance.allClothesScriptables[i].myId;

                    spawnedIcons.Add(icon);
                }

                if (ClothingData.instance.allClothesScriptables[i].myItemSlot == ITEM_SLOT.LEGS)
                {
                    GameObject go = Instantiate(clothingIconPrefab, legsParent.transform);
                    ClothingIcon icon = go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();

                    icon.myIcon.sprite = ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0];
                    icon.myItemsId = ClothingData.instance.allClothesScriptables[i].myId;

                    spawnedIcons.Add(icon);
                }

                if (ClothingData.instance.allClothesScriptables[i].myItemSlot == ITEM_SLOT.HEAD)
                {
                    GameObject go = Instantiate(clothingIconPrefab, hatsParent.transform);
                    ClothingIcon icon = go.GetComponent<ClothingIcon>();

                    icon = go.GetComponent<ClothingIcon>();

                    icon.myIcon.sprite = ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0];
                    icon.myItemsId = ClothingData.instance.allClothesScriptables[i].myId;

                    spawnedIcons.Add(icon);
                }

                //icon = go.GetComponent<ClothingIcon>();

                //icon.myIcon.sprite = ClothingData.instance.allClothesScriptables[i].spritesWithDirctions[0].spritesForMyDirection[0];
                //icon.myItemsId = ClothingData.instance.allClothesScriptables[i].myId;

                //spawnedIcons.Add(icon);

            }
        }
    }
}
