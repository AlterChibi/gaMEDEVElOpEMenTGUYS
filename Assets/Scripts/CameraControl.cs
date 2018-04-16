using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public GameObject Char1;

    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - Char1.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Char1.transform.position + offset;
	}
}
