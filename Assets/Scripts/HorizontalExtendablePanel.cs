using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HorizontalExtendablePanel : MonoBehaviour
{
    public float extendedWidth = 200.0f;

    public MonoBehaviour eventSystem = null;

    private bool isExtended = false;
    private Coroutine coroutine;
    private float originalWidth = 0;
    private static float duration = 0.5f;
    private AnimationCurve animCurve = AnimationCurve.Linear(0, 0, duration, 1);

    public MonoBehaviour CoroutineTarget
    {
        get
        {
            return eventSystem != null ? eventSystem : this;
        }
    }

    public bool IsExtended
    {
        get
        {
            return isExtended;
        }
    }

    // Use this for initialization
    void Start()
    {
        originalWidth = (transform as RectTransform).sizeDelta.x;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleExtendStatus(bool isAnimation = false)
    {
        if (coroutine != null) CoroutineTarget.StopCoroutine(coroutine);
        float dstWidth = 0.0f;
        if (isExtended)
        {
            dstWidth = originalWidth;
        }
        else
        {
            dstWidth = extendedWidth;
        }
        if (isAnimation)
        {
            coroutine = CoroutineTarget.StartCoroutine(StartAnimation(dstWidth));
        }
        else
        {
            (transform as RectTransform).sizeDelta = new Vector2(dstWidth, (transform as RectTransform).sizeDelta.y);
        }
        isExtended = !isExtended;
    }

    public void SetExtendStatus(bool isExtend)
    {
        if (isExtend == this.isExtended) return;
        ToggleExtendStatus(true);
    }

    private IEnumerator StartAnimation(float dstWidth)
    {
        float startTime = Time.time;
        Vector2 currentSize = (transform as RectTransform).sizeDelta;
        float srcWidth = currentSize.x;
        float distance = dstWidth - srcWidth;

        while ((Time.time - startTime) < duration)
        {
            (transform as RectTransform).sizeDelta = new Vector2(srcWidth + distance * animCurve.Evaluate((Time.time - startTime) / duration), currentSize.y);
            yield return 0;
        }
        (transform as RectTransform).sizeDelta = new Vector2(dstWidth, currentSize.y);
        coroutine = null;
    }
}
