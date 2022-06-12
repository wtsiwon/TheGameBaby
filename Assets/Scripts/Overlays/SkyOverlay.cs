using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyOverlay : GuideSelect
{
    [SerializeField]
    private Button skyOverlay;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        skyOverlay.gameObject.SetActive(true);
        isOver = true;
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        skyOverlay.gameObject.SetActive(false);
        isOver = false;
    }
}
