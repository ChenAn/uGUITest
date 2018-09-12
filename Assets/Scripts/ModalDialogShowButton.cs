using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModalDialogShowButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ShowDialog()
    {
        ModalDialog.PopTo(transform.root.GetComponent<Canvas>().transform);
    }
}
