using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsContainer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HideAllParts()
    {
        foreach (Transform transform in transform)
        {
            transform.gameObject.SetActive(false);
        }

    }

    public void ShowPart(GameObject obj)
    {
        HideAllParts();
        obj.SetActive(true);
    }
}
