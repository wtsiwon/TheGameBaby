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
    protected EguideType eguideType;
    protected bool isOver;
    protected abstract void OnMouseEnter();
    protected abstract void OnMouseExit();
}
