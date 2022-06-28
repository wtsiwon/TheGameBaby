using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public enum EguideType
{
    Rabbit,
    Cat,
    Frog,
    Fish,
    Parrot
}
public class Guide : MonoBehaviour
{
    public EguideType eguideType;
    private void OnEnable()
    {
        Invoke(nameof(GoGuideSelect), 2.5f);
    }
    public void GoGuideSelect()
    {
        SceneManager.LoadScene("SelectGuide");
    }
}
