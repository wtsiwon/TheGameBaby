using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldOverlay : GuideSelect
{
    [SerializeField]
    private Button fieldOverlay;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        fieldOverlay.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        fieldOverlay.gameObject.SetActive(false);
        isOver = false;
    }
}
