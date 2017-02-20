using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour {

    //RawImage rawimage = GetComponent<RawImage>();

	// Use this for initialization
	void Start () {
	    WebCamTexture webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
	}

	// Update is called once per frame
	void Update () {

	}
}
