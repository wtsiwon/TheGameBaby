using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public enum types
{
    �� = 1,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��,
    ��
}
public class Words : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private RectTransform RT;
    public Image coWord;
    public types type;

    private void Awake()
    {
        RT = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        //���� �巡�� ���� �̹���(��)�� ����
        GameManager.Instance.draggingobj = this.gameObject;
    }
    public void OnDrag(PointerEventData eventData)
    {
        RT.position = eventData.position;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        GameManager.Instance.draggingobj = null;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coword"))
        {
            GameManager.Instance.currentobj = collision.gameObject;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Coword"))
        {
            GameManager.Instance.currentobj = collision.gameObject;
        }
    }
}
