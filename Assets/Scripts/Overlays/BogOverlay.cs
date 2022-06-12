using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BogOverlay : GuideSelect
{
    [SerializeField]
    private Button bogOverlay;

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        bogOverlay.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        bogOverlay.gameObject.SetActive(false);
        isOver = false;
    }
}
