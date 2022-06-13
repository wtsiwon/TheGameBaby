using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MountainOverlay : GuideSelect
{
    [SerializeField]
    private Button mountainButton;

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        mountainButton.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        mountainButton.gameObject.SetActive(false);
        isOver = false;
    }
}
