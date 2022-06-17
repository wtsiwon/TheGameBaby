using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MountainOverlay : GuideSelect
{
    public GameObject Rabbit;
    protected override void Active()
    {
        Instantiate(Rabbit, canvas.transform);
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
