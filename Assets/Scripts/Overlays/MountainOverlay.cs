using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MountainOverlay : StageManager , IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Button mountainOverlay;

    private void OnMouseEnter()
    {
        mountainOverlay.gameObject.SetActive(true);
    }
    private void OnMouseExit()
    {
        mountainOverlay.gameObject.SetActive(false);
    }
    public override void OnPointerEnter(PointerEventData eventData)
    {
        //mountainOverlay.gameObject.SetActive(true);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        //mountainOverlay.gameObject.SetActive(false);
    }
}
