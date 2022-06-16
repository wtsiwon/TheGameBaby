using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyOverlay : GuideSelect
{
    public GameObject Parrot;
    protected override void Active()
    {
        Instantiate(Parrot, canvas.transform);
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
