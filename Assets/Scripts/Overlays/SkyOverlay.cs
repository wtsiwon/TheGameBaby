using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyOverlay : GuideSelect
{
    [SerializeField]
    private Button skyButton;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        skyButton.gameObject.SetActive(true);
        isOver = true;
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        skyButton.gameObject.SetActive(false);
        isOver = false;
    }
}
