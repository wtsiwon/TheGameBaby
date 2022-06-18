using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckBoard : MonoBehaviour
{
    [Header("Inspecter")]
    [SerializeField]
    private Button Nextbutton;
    [SerializeField]
    private Image Nextbuttonimg;
    [SerializeField]
    private Button Rebutton;
    [SerializeField]
    private Image Rebuttonimg;
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
            Debug.Log("È¦");
        });
        Rebutton.onClick.AddListener(() =>
        {
            gameObject.SetActive(false);
            GameManager.Instance.titleUp = true;
            Debug.Log("¸®");
        });
    }
}
