using UnityEngine;
using System.Collections.Generic;

public class PreferenceManager
{

    //public static void UpdateAClothOwnership(ITEM_SLOT slot, int id, int value)
    //{
    //    switch (slot)
    //    {
    //        case ITEM_SLOT.CHEST:
    //            {
    //                if(id == )
    //                break;
    //            }

    //        case ITEM_SLOT.LEGS:
    //            {
    //                CollectableTwo += value;
    //                break;
    //            }

    //        case ITEM_SLOT.HEAD:
    //            {

    //                break;
    //            }
    //    }


    //}
    //public static int GetAClothOwnership(COLLECTABLE_TYPE type)
    //{
    //    int rtnVal = 0;
    //    switch (type)
    //    {
    //        case COLLECTABLE_TYPE.COLLECTABLE_ONE:
    //            {
    //                rtnVal = CollectableOne;
    //                break;
    //            }

    //        case COLLECTABLE_TYPE.COLLECTABLE_TWO:
    //            {
    //                rtnVal = CollectableTwo;
    //                break;
    //            }
    //    }
    //    return rtnVal;


    //}

    //static string COLLECTABLE_ONE = "COLLECTABLE_ONE";
    //public static int CollectableOne
    //{
    //    get
    //    {
    //        return PlayerPrefs.GetInt(COLLECTABLE_ONE, 0);
    //    }

    //    set
    //    {
    //        PlayerPrefs.SetInt(COLLECTABLE_ONE, value);
    //    }
    //}

    //static string COLLECTABLE_TWO = "COLLECTABLE_TWO";
    //public static int CollectableTwo
    //{
    //    get
    //    {
    //        return PlayerPrefs.GetInt(COLLECTABLE_TWO, 0);
    //    }

    //    set
    //    {
    //        PlayerPrefs.SetInt(COLLECTABLE_TWO, value);
    //    }
    //}

    static string CURRENT_HAT = "CURRENT_HAT";
public static int CurrentHat
{
    get
    {
        return PlayerPrefs.GetInt(CURRENT_HAT, 0);
    }

    set
    {
        PlayerPrefs.SetInt(CURRENT_HAT, value);
    }
}

    static string CURRENT_CHEST = "CURRENT_CHEST";
    public static int CurrentChest
    {
        get
        {
            return PlayerPrefs.GetInt(CURRENT_CHEST, 0);
        }

        set
        {
            PlayerPrefs.SetInt(CURRENT_CHEST, value);
        }
    }

    static string CURRENT_LEGS = "CURRENT_LEGS";
    public static int CurrentLegs
    {
        get
        {
            return PlayerPrefs.GetInt(CURRENT_LEGS, 0);
        }

        set
        {
            PlayerPrefs.SetInt(CURRENT_LEGS, value);
        }
    }

}
