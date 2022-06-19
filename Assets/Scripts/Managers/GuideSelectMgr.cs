using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideSelectMgr : MonoBehaviour
{
    private Canvas canvas;
    private void Start()
    {
        canvas = FindObjectOfType<Canvas>();
        Instantiate(GameManager.Instance.guideAnimal,canvas.transform);
    }
}
