using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyOverlay : GuideSelect
{
    protected override void CheckActive()
    {
        Checkboard.gameObject.SetActive(true);
    }

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        isOver = true;
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        isOver = false;
    }
}
