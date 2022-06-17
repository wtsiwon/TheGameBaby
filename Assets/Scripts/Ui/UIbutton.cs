using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIbutton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Button overlay;
    private void OnEnable()
    {
        overlay.enabled = false;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        overlay.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        overlay.gameObject.SetActive(true);
    }
}
