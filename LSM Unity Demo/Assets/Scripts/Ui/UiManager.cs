using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject backgroundPanel;


    public void OnOpenBackgroudPanel()
    {
        backgroundPanel.SetActive(true);
    }

    public void OnCloseBackgroundPanel()
    {
        backgroundPanel.SetActive(false);
    }


}
