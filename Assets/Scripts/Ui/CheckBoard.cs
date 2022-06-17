using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckBoard : MonoBehaviour
{
    [SerializeField]
    private Button Nextbutton;
    [SerializeField]
    private Button Rebutton;
    [SerializeField]
    private GameObject animal;
    [SerializeField]
    private Canvas canvas;


    private void OnEnable()
    {
        GameManager.Instance.titleUp = false;
        Nextbutton.onClick.AddListener(() =>
        {
            Instantiate(animal, canvas.transform);
            gameObject.SetActive(false);
            GameManager.Instance.guideAnimal = animal;
        });
        Rebutton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            GameManager.Instance.titleUp = true;
        });
    }
}
