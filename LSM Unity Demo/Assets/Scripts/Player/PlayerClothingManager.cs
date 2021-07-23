using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DirectionSpriteList
{
    public MOVE_DIRECTION myDirection;
    public List<Sprite> spritesForMyDirection = new List<Sprite>();
}

public enum ITEM_SLOT
{
    HEAD,
    CHEST,
    LEGS
}

public class PlayerClothingManager : MonoBehaviour
{
    [Header("LINKS")]
    public SpriteRenderer headRenderer;
    public SpriteRenderer chestRenderer;
    public SpriteRenderer legRenderer;

    [Header("RUNTIME")]
    public ClothItemScriptable activeHead;
    public ClothItemScriptable activeChest;
    public ClothItemScriptable activeLegs;

 
    private MOVE_DIRECTION currentInput;

    private void Start()
    {
        activeChest = ClothingData.instance.GetClothItem(PreferenceManager.CurrentChest);
        activeHead = ClothingData.instance.GetClothItem(PreferenceManager.CurrentHat);
        activeLegs = ClothingData.instance.GetClothItem(PreferenceManager.CurrentLegs);
        
        //todo
        currentInput = MOVE_DIRECTION.DOWN;
    }

    public void SetCurrentInput(MOVE_DIRECTION c)
    {
        currentInput = c;
    }

    public void AssignActiveClotheSprite(int index)
    {
        if(activeChest!=null)
        {
            


            for (int i = 0; i < activeChest.spritesWithDirctions.Count; i++)
            {
                if(activeChest.spritesWithDirctions[i].myDirection == currentInput)
                {
                    //if there is no sprite of that index set up, defult to index Zero
                    if (activeChest.spritesWithDirctions[i].spritesForMyDirection.Count < index + 1)
                    {
                        chestRenderer.sprite = activeChest.spritesWithDirctions[i].spritesForMyDirection[0];
                    }
                    else
                    {

                        chestRenderer.sprite = activeChest.spritesWithDirctions[i].spritesForMyDirection[index];
                    }
                }
            }
        }

        if (activeHead != null)
        {
            for (int i = 0; i < activeHead.spritesWithDirctions.Count; i++)
            {
                if (activeHead.spritesWithDirctions[i].myDirection == currentInput)
                {
                    if (activeHead.spritesWithDirctions[i].spritesForMyDirection.Count < index + 1)
                    {
                        headRenderer.sprite = activeHead.spritesWithDirctions[i].spritesForMyDirection[0];
                    }
                    else
                    {
                        headRenderer.sprite = activeHead.spritesWithDirctions[i].spritesForMyDirection[index];
                    }
                }
            }
        }

        if (activeLegs != null)
        {
            for (int i = 0; i < activeLegs.spritesWithDirctions.Count; i++)
            {
                if (activeLegs.spritesWithDirctions[i].myDirection == currentInput)
                {
                    if (activeLegs.spritesWithDirctions[i].spritesForMyDirection.Count < index + 1)
                    {
                        legRenderer.sprite = activeLegs.spritesWithDirctions[i].spritesForMyDirection[0];
                    }
                    else
                    {
                        legRenderer.sprite = activeLegs.spritesWithDirctions[i].spritesForMyDirection[index];
                    }
                }
            }

            Debug.Log(legRenderer.sprite.name);
        }

    }
}
