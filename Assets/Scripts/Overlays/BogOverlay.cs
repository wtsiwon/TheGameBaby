using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BogOverlay : GuideSelect
{
    [SerializeField]
    private Button bogButton;

    protected override void OnMouseEnter()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseEnter();
        bogButton.gameObject.SetActive(true);
        isOver = true;
    }

    protected override void OnMouseExit()
    {
        if (GameManager.Instance.titleUp == false) return;
        base.OnMouseExit();
        bogButton.gameObject.SetActive(false);
        isOver = false;
    }
}
