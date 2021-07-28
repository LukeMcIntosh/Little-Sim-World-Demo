using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClothingIcon : MonoBehaviour
{
    [Header("LINKS")]
    public UiPanelBase owner;
    public Image myIcon;
    public Image equippedImage;
    public Image sellImage;
    public Image buyImage;
    public Image CoverImage;

    [Header("RUNTIME")]
    public ITEM_SLOT myType;
    public int myItemsId;

    private bool isInShop;

    public void SetUpIcon( bool _isInShop, ITEM_SLOT _myType, int _myItemsId, Sprite _myIconImage)
    {
        isInShop = _isInShop;
        myType = _myType;
        myItemsId = _myItemsId;
        myIcon.sprite = _myIconImage;
    }

    public void OnClicked()
    {
        owner.OnIconClicked(this);
    }

}
