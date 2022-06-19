using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public abstract class GuideSelect : MonoBehaviour
{
    [SerializeField]
    protected Canvas canvas;

    [SerializeField]
    protected Button selectBtn;

    [SerializeField]
    protected SpriteRenderer Overlay;

    protected bool isOver;

    [SerializeField]
    protected GameObject Checkboard;
    private void Start()
    {
        selectBtn.onClick.AddListener(() =>
        {
            if (GameManager.Instance.titleUp == false) return;
            CheckActive();
        });
    }
    protected abstract void CheckActive();
    
        
        
    protected virtual void OnMouseEnter()
    {
        Overlay.gameObject.SetActive(true);
        selectBtn.gameObject.SetActive(true);
    }
    protected virtual void OnMouseExit()
    {
        Overlay.gameObject.SetActive(false);
        selectBtn.gameObject.SetActive(false);
    }
}