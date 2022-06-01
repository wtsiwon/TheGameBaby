using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MountainOverlay : StageManager
{
    [SerializeField]
    private Image mountainOverlay;
    protected override void OnMouseEnter()
    {
        mountainOverlay.gameObject.SetActive(true);
    }

    protected override void OnMouseExit()
    {
        mountainOverlay.gameObject.SetActive(false);
    }
}
