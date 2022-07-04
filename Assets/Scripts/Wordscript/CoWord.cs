using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoWord : MonoBehaviour
{
    public types type;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var colobj = collision.GetComponent<Words>();
        if(type == colobj.type)
        {
            GameManager.Instance.isCorrect = true;
        }
    }
}
