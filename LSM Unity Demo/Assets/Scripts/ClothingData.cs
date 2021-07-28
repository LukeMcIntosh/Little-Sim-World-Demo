using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClothingData : MonoBehaviour
{
    public static ClothingData instance;

    public PlayerClothingManager clothingManager;
    public List<ClothItemScriptable> allClothesScriptables = new List<ClothItemScriptable>();

    private Dictionary<int, int> clotheIdsAndOwnership = new Dictionary<int, int>();

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

        for (int i = 0; i < allClothesScriptables.Count; i++)
        {
            //populate the dict, with int vals as ownership over the item
            if(!clotheIdsAndOwnership.ContainsKey(allClothesScriptables[i].myId))
            {
                clotheIdsAndOwnership.Add(allClothesScriptables[i].myId, PlayerPrefs.GetInt(allClothesScriptables[i].myId.ToString(), 0));
            }
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

    public bool CheckOwnership(int id)
    {
        return clotheIdsAndOwnership[id] > 0 ? true : false;
    }

    public void SetOwnership(bool owned, int id)
    {
        PlayerPrefs.SetInt(id.ToString(), owned ? 1 : 0);
        clotheIdsAndOwnership[id] = owned ? 1 : 0;
    }
}
