using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingData : MonoBehaviour
{
    public static ClothingData instance;

    public PlayerClothingManager clothingManager;
    public List<ClothItemScriptable> allClothesScriptables = new List<ClothItemScriptable>();

   public Dictionary<ClothItemScriptable, bool> chestClothesAndUnlockState = new Dictionary<ClothItemScriptable, bool>();
    public Dictionary<ClothItemScriptable, bool> legsClothesAndUnlockState = new Dictionary<ClothItemScriptable, bool>();
   public Dictionary<ClothItemScriptable, bool> hatsClothesAndUnlockState = new Dictionary<ClothItemScriptable, bool>();

    public int startingChestId;
    public int startingLegsId;

    void OnEnable()
    {
        PlayerPrefs.DeleteAll();

        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }

        for (int i = 0; i < allClothesScriptables.Count; i++)
        {
            switch(allClothesScriptables[i].myItemSlot)
            {
                case ITEM_SLOT.CHEST:
                    {
                        if(!chestClothesAndUnlockState.ContainsKey(allClothesScriptables[i]))
                        {
                            chestClothesAndUnlockState.Add(allClothesScriptables[i],
                                ToBool(PlayerPrefs.GetInt(allClothesScriptables[i].myId.ToString(), 0)));
                        }
                        break;
                    }
                case ITEM_SLOT.HEAD:
                    {
                        hatsClothesAndUnlockState.Add(allClothesScriptables[i],
                            ToBool(PlayerPrefs.GetInt(allClothesScriptables[i].myId.ToString(), 0)));
                        break;
                    }
                case ITEM_SLOT.LEGS:
                    {
                        legsClothesAndUnlockState.Add(allClothesScriptables[i],
                            ToBool(PlayerPrefs.GetInt(allClothesScriptables[i].myId.ToString(), 0)));       
                        break;
                    }
            }
        }

        if (PlayerPrefs.GetInt(startingChestId.ToString()) == 0)
        {
            PlayerPrefs.SetInt(startingChestId.ToString(), 1);
            PreferenceManager.CurrentChest = startingChestId;
            PlayerPrefs.SetInt(startingLegsId.ToString(), 1);
            PreferenceManager.CurrentLegs = startingLegsId;
        }
    }

    private bool ToBool(int value)
    {
        return value > 0 ? true : false;
    }

    public ClothItemScriptable GetClothItem(int id)
    {
        for (int i = 0; i < allClothesScriptables.Count; i++)
        {
            if(allClothesScriptables[i].myId == id)
            {
                return allClothesScriptables[i];
            }
        }

        return null;
    }
}
