using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCanva : MonoBehaviour
{
    public Canvas mainCanvas;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnEnable()
    {
    }

    public void Show()
    {
        gameObject.SetActive(true);
        mainCanvas.gameObject.SetActive(false);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
        mainCanvas.gameObject.SetActive(true);
    }
}
