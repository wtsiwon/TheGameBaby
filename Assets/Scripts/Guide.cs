using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Guide : MonoBehaviour
{

    protected Animation anim;
    private void Start()
    {
        anim = GetComponent<Animation>();
    }


    private void Enable()
    {
        anim.Play();
        transform.DOScale(2, 1.2f);
    }
}
