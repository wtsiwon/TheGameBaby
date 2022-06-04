using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MountainOverlay : StageManager
{
    [SerializeField]
    private Button mountainOverlay;

    protected override void OnMouseEnter()
    {
        mountainOverlay.gameObject.SetActive(true);
    }

    protected override void OnMouseExit()
    {
        mountainOverlay.gameObject.SetActive(false);
    }
}
