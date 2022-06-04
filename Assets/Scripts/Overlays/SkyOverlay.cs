using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyOverLay : StageManager
{
    [SerializeField]
    private Button skyOverlay;
    protected override void OnMouseEnter()
    {
        skyOverlay.gameObject.SetActive(true);
    }
    protected override void OnMouseExit()
    {
        skyOverlay.gameObject.SetActive(false);
    }
}
