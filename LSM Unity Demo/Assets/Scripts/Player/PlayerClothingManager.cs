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

public enum MOVE_DIRECTION
{
    UP,
    DOWN,
    LEFT,
    RIGHT
}



public class PlayerClothingManager : MonoBehaviour
{
    [Header("LINKS")]
    public SpriteRenderer headRenderer;
    public SpriteRenderer chestRenderer;
    public SpriteRenderer legRenderer;

    public ClotheItemScriptable activeHead;
    public ClotheItemScriptable activeChest;
    public ClotheItemScriptable activeLegs;

 
    private MOVE_DIRECTION currentInput;

    private void Start()
    {

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
                    chestRenderer.sprite = activeChest.spritesWithDirctions[i].spritesForMyDirection[index];
                }
            }
        }

        if (activeHead != null)
        {
            for (int i = 0; i < activeHead.spritesWithDirctions.Count; i++)
            {
                if (activeHead.spritesWithDirctions[i].myDirection == currentInput)
                {
                    headRenderer.sprite = activeHead.spritesWithDirctions[i].spritesForMyDirection[index];
                }
            }
        }

        if (activeLegs != null)
        {
            for (int i = 0; i < activeLegs.spritesWithDirctions.Count; i++)
            {
                if (activeLegs.spritesWithDirctions[i].myDirection == currentInput)
                {
                    legRenderer.sprite = activeLegs.spritesWithDirctions[i].spritesForMyDirection[index];
                }
            }
        }

    }
}
