using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : UiPanelBase
{
    public Text moneyText;
   [HideInInspector] public int moneyValue;

    private void OnEnable()
    {
        Initialize(true);        
    }

    private void Start()
    {
        moneyValue = PlayerPrefs.GetInt("Money", 1000);
        UpdateMoneyReadout(0);
    }

    public override void Initialize(bool isShop)
    {
        base.Initialize(isShop);
    }

    public override void SetUp()
    {
        for (int i = 0; i < spawnedIcons.Count; i++)
        {
            if (spawnedIcons[i].myItemsId == PreferenceManager.CurrentChest ||
               spawnedIcons[i].myItemsId == PreferenceManager.CurrentHat ||
               spawnedIcons[i].myItemsId == PreferenceManager.CurrentLegs)
            {
                spawnedIcons[i].CoverImage.gameObject.SetActive(true);
                continue;
            }
            else
            {
                spawnedIcons[i].CoverImage.gameObject.SetActive(false);
            }

            if (ClothingData.instance.CheckOwnership(spawnedIcons[i].myItemsId))
            {
                spawnedIcons[i].sellImage.gameObject.SetActive(true);
                spawnedIcons[i].buyImage.gameObject.SetActive(false);
            }
            else
            {
                spawnedIcons[i].sellImage.gameObject.SetActive(false);
                spawnedIcons[i].buyImage.gameObject.SetActive(true);
            }
        }
    }

    public override void OnIconClicked(ClothingIcon iconClicked)
    {
        if (iconClicked.buyImage.gameObject.activeSelf)
        {
            ClothingData.instance.SetOwnership(true, iconClicked.myItemsId);
            UpdateMoneyReadout(-200);          
        }
        else
        {
            ClothingData.instance.SetOwnership(false, iconClicked.myItemsId);
            UpdateMoneyReadout(200);
        }

        SetUp();
    }

    public void UpdateMoneyReadout(int deltaMoney)
    {
        moneyValue += deltaMoney;
        PlayerPrefs.SetInt("Money", moneyValue);
        moneyText.text = "Money: " + moneyValue.ToString();
    }
}
