using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
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
public class Words : MonoBehaviour
{
    private Vector2 firstpos;
    public types type;
    public bool isDrag;
    public Canvas canvas;
    private void Awake()
    {
        firstpos = transform.position;
        canvas = FindObjectOfType<Canvas>();
    }
    private void OnMouseDown()
    {
        //���� �巡�� ���� �̹���(��)�� ����
        GameManager.Instance.draggingobj = gameObject;
        GetComponent<SpriteRenderer>().sortingOrder += 1;
        isDrag = true;
        print("��¿Ƽ��");
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
        if (GameManager.Instance.isCorrect == false)
        {
            gameObject.transform.position = firstpos;
        }
        else if (GameManager.Instance.isCorrect == true)
        {
            print("�ƴ�");
            //GameManager.Instance.currentobj.GetComponent<CoWord>().coWord.SetActive(true);
            StartCoroutine(Nextstep());
            Instantiate(GameManager.Instance.objs[GameManager.Instance.Stage].coobj[GameManager.Instance.Step], transform.position, Quaternion.identity);
        }
        GetComponent<SpriteRenderer>().sortingOrder -= 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("�浹�� �ǳ�?");
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
    private IEnumerator Nextstep()
    {
        Instantiate(GameManager.Instance.clear, canvas.transform);
        GameManager.Instance.clear.transform.DOScaleX(1, 1.1f);
        GameManager.Instance.clear.transform.DOScaleY(1, 1.1f);
        yield return new WaitForSeconds(2f);
        GameManager.Instance.Step++;
        GameManager.Instance.Resetstep();
    }
}
