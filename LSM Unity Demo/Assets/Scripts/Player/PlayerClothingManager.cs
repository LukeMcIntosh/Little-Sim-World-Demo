using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothingManager : MonoBehaviour
{
    public SpriteRenderer chestRenderer;

    public List<Sprite> chestSprites = new List<Sprite>();

    public void AssignActiveClotheSprite(int index)
    {
        chestRenderer.sprite = chestSprites[index];
    }
}
