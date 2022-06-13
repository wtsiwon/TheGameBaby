using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanOverlay : GuideSelect
{
    [SerializeField]
    private Button oceanButton;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        oceanButton.gameObject.SetActive(true);
        isOver = true;
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        oceanButton.gameObject.SetActive(false);
        isOver = false;
    }
}
