using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing Item")]
public class ClotheItemScriptable : ScriptableObject
{
    public ITEM_SLOT myItemSlot;
    public List<DirectionSpriteList> spritesWithDirctions = new List<DirectionSpriteList>();

    
}
