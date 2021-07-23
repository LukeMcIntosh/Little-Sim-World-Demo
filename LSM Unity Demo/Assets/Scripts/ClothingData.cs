using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingData : MonoBehaviour
{
    public static ClothingData instance;

    public PlayerClothingManager clothingManager;
    public List<ClothItemScriptable> allClothesScriptables = new List<ClothItemScriptable>();

    public int startingChestId;
    public int startingLegsId;
    public int startingHatId;

    void OnEnable()
    {


        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
            return;
        }

    
        if (PlayerPrefs.GetInt(startingChestId.ToString()) == 0)
        {
            PlayerPrefs.SetInt(startingChestId.ToString(), 1);
            PreferenceManager.CurrentChest = startingChestId;

            PlayerPrefs.SetInt(startingLegsId.ToString(), 1);
            PreferenceManager.CurrentLegs = startingLegsId;

            PlayerPrefs.SetInt(startingHatId.ToString(), 1);
            PreferenceManager.CurrentHat = startingHatId;
        }
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
