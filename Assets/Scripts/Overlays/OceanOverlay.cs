using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanOverlay : GuideSelect
{
    [SerializeField]
    private Button oceanOverlay;
    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        oceanOverlay.gameObject.SetActive(true);
        isOver = true;
    }
    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        oceanOverlay.gameObject.SetActive(false);
        isOver = false;
    }
}
