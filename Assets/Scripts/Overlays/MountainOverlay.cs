using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MountainOverlay : GuideSelect
{
    [SerializeField]
    private Button mountainOverlay;

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        mountainOverlay.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        mountainOverlay.gameObject.SetActive(false);
        isOver = false;
    }
}
