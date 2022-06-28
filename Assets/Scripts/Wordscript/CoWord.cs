using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoWord : MonoBehaviour
{
    public bool isCorrect;
    public GameObject coWord;
    public types type;
    public Canvas canvas;

    private void OnEnable()
    {
        canvas = FindObjectOfType<Canvas>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var colobj = collision.GetComponent<Words>();
        if(type == colobj.type)
        {
            isCorrect = true;
            coWord.SetActive(true);
            StartCoroutine(Nextstep());
        }
    }
    private IEnumerator Nextstep()
    {
        Instantiate(GameManager.Instance.clear,canvas.transform);
        GameManager.Instance.clear.transform.DOScaleX(1, 1.1f);
        GameManager.Instance.clear.transform.DOScaleY(1, 1.1f);
        yield return new WaitForSeconds(2f);
        GameManager.Instance.Resetstep();
        GameManager.Instance.Step++;
    }
}
