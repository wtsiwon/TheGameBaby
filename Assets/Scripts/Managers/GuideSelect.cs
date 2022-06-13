using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public enum EguideType
{
    Cat,
    Fish,
    Frog,
    Parrot,
    Rabbit
}
public abstract class GuideSelect : MonoBehaviour
{
    [SerializeField]
    protected SpriteRenderer Overlay;
    [SerializeField]
    protected EguideType eguideType;
    protected bool isOver;
    protected virtual void OnMouseEnter()
    {
        Overlay.gameObject.SetActive(true);
    }
    protected virtual void OnMouseExit()
    {
        Overlay.gameObject.SetActive(false);
    }
}
