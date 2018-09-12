using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTargetInputField : MonoBehaviour {
    public List<Text> targets;

    // Use this for initialization
    void Start()
    {
        SetTextToTargets();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetTextToTargets()
    {
        string value = GetComponent<InputField>().text;
        foreach (Text label in targets)
        {
            label.text = value;
        }
    }
}
