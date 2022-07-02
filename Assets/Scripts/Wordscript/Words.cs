using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public enum types
{
    ㄱ = 1,
    ㄴ,
    ㄷ,
    ㄹ,
    ㅁ,
    ㅂ,
    ㅅ,
    ㅇ,
    ㅈ,
    ㅊ,
    ㅋ,
    ㅌ,
    ㅍ,
    ㅎ
}
public class Words : MonoBehaviour
{
    private Transform T;
    public types type;
    public bool isDrag;
    public Vector3 firstpos;

    private void Awake()
    {
        firstpos = transform.position;
        T = GetComponent<Transform>();
    }
    private void OnMouseDown()
    {
        //지금 드래그 중인 이미지(나)를 저장
        GameManager.Instance.draggingobj = this.gameObject;
        isDrag = true;
        print("어쩔티비");
    }
    private void Update()
    {
        if (isDrag == true)
        {
            Vector2 mousepos;
            mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            gameObject.transform.position = mousepos;
        }
    }
    private void OnMouseUp()
    {
        isDrag = false;
        GameManager.Instance.draggingobj = null;
        if(GameManager.Instance.isCorrect == false)
        {
            gameObject.transform.position = firstpos;
        }
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
            GameManager.Instance.currentobj = null;
        }
    }
}
