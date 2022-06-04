using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public abstract class StageManager : MonoBehaviour
{
    protected BoxCollider2D box;
    
    protected abstract void OnMouseEnter();
    protected abstract void OnMouseExit();
}
