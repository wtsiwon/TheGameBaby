using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public enum EguideType
{
    Rabbit,
    Frog,
    Cat,
    Fish,
    Parrot
}
public abstract class GuideSelect : MonoBehaviour
{
    [SerializeField]
    protected Canvas canvas;
    [SerializeField]
    protected Button selectBtn;
    [SerializeField]
    protected SpriteRenderer Overlay;
    [SerializeField]
    protected EguideType eguideType;
    protected bool isOver;

    private Dictionary<EguideType, GameObject> animals = new Dictionary<EguideType, GameObject>();
    private void Start()
    {
        selectBtn.onClick.AddListener(() =>
        {
            Active();
        });
    }
    protected abstract void Active();
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