using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Word : MonoBehaviour, IPointerDownHandler, IPointerUpHandler,IDragHandler
{
    public GameObject DragObject;//드레그 할때 나타날 오브젝트
    private GameObject instance;
    public Canvas canvas;
    public string word;
    public bool isCorrect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string name = collision.GetComponent<Container>().Name;
        if (collision.CompareTag("Container") && name == word)
        {
            isCorrect = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Container"))
        {
            isCorrect = false;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        instance.transform.position = Input.mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        instance = Instantiate(DragObject, canvas.transform);
        instance.transform.position = Input.mousePosition;
        
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        if(instance != null && isCorrect == true)
        instance = null;
    }
}
