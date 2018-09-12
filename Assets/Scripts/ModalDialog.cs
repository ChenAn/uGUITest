using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalDialog : MonoBehaviour {
    public Transform header;
    public Transform content;

	// Use this for initialization
	void Start () {
        Transform cancelButtonTransform = header.Find("CancelButton");
        cancelButtonTransform.GetComponent<Button>().onClick.AddListener(OnCancelButtonClicked);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCancelButtonClicked()
    {
        ModalDialog.Dismiss(this);
    }

    public static void PopTo(Transform parentTransform)
    {
        GameObject prefab = (GameObject)Resources.Load("Prefabs/ModalDialog");
        GameObject obj = Instantiate(prefab, parentTransform) as GameObject;
        
    }

    public static void Dismiss(ModalDialog dialog)
    {
        MonoBehaviour.Destroy(dialog.gameObject);
    }
}
