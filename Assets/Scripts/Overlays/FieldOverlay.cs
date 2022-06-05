using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FieldOverlay : StageManager
{
    [SerializeField]
    private Button fieldOverlay;
    protected override void OnMouseEnter()
    {
        fieldOverlay.gameObject.SetActive(true);
    }

    protected override void OnMouseExit()
    {
        fieldOverlay.gameObject.SetActive(false);
    }
}
