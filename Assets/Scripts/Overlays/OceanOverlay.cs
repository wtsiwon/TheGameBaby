using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OceanOverlay : StageManager
{
    [SerializeField]
    private Button oceanOverlay;
    protected override void OnMouseEnter()
    {
        oceanOverlay.gameObject.SetActive(true);
    }
    protected override void OnMouseExit()
    {
        oceanOverlay.gameObject.SetActive(false);
    }
}
