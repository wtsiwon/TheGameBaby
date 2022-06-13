using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldOverlay : GuideSelect
{
    [SerializeField]
    private Button fieldButton;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        fieldButton.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        fieldButton.gameObject.SetActive(false);
        isOver = false;
    }
}
