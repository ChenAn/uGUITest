using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WidthInputField : MonoBehaviour {

    public List<Transform> targets;

	// Use this for initialization
	void Start () {
        SetWidthToTargets();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SetWidthToTargets()
    {
        float width = float.Parse(GetComponent<InputField>().text);
        foreach (Transform trans in targets)
        {
            Vector2 size = trans.GetComponent<RectTransform>().sizeDelta;
            size.x = width;
            trans.GetComponent<RectTransform>().sizeDelta = size;
        }
    }
}
