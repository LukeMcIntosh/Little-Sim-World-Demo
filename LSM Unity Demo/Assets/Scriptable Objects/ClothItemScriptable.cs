using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Clothing Item")]
public class ClothItemScriptable : ScriptableObject
{
    public int myId;
    public ITEM_SLOT myItemSlot;
    [Space(20)]
    public List<DirectionSpriteList> spritesWithDirctions = new List<DirectionSpriteList>();
}
