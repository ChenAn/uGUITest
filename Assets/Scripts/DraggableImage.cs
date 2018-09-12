using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class DraggableImage : MonoBehaviour, IScrollHandler
{
    public float zoomSpeed = 0.1f;
    public float minZoom = 0.1f;
    public float maxZoom = 3.0f;

    private Vector3 initScale;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Awake()
    {
        initScale = transform.localScale;
    }

    public void OnScroll(PointerEventData eventData)
    {
        OnScroll(eventData.scrollDelta.y);
    }

    public void OnScroll(float deltaY)
    {
        Vector3 delta = Vector3.one * (deltaY * zoomSpeed);
        Vector3 newScale = transform.localScale + delta;
        newScale = Vector3.Max(initScale * minZoom, newScale);
        newScale = Vector3.Min(initScale * maxZoom, newScale);

        transform.localScale = newScale;
    }
}
