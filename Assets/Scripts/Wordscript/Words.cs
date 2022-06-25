using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Words : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform RT;
    public Image coWord;

    private void Awake()
    {
        RT = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //지금 드래그 중인 이미지(나)를 저장
        GameManager.Instance.draggingimg = GetComponent<Image>();
    }
    public void OnDrag(PointerEventData eventData)
    {
        RT.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        GameManager.Instance.draggingimg = null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.currentimg = collision.GetComponent<Image>();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GameManager.Instance.currentimg = null;
    }
}
