using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



[RequireComponent(typeof(AudioSource))]
public class Video : MonoBehaviour {
    public MovieTexture movTexture;
   
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.mainTexture = movTexture;
        movTexture.Play();
       
    }
    void Update()
    {
        if (Input.anyKey)
            Application.LoadLevel("menu");
        
    }

}
