using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldOverlay : GuideSelect
{
    public GameObject Cat;
    
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        isOver = true;
    }
    protected override void Active()
    {
        Instantiate(Cat, canvas.transform);
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        isOver = false;
    }
}
