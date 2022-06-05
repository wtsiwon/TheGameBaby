using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BogOverlay : StageManager
{
    [SerializeField]
    private Button bogOverlay;

    protected override void OnMouseEnter()
    {
        bogOverlay.gameObject.SetActive(true);
    }

    protected override void OnMouseExit()
    {
        bogOverlay.gameObject.SetActive(false);
    }
}
