using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private Animator _animator;

    public GameObject OpenPanel = null;

    private bool _isInsideTrigger = false;

	// Use this for initialization
	void Start () {
        _animator = GetComponentInChildren<Animator>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = true;
            OpenPanel.SetActive(true);
        }
        else if (other.tag == "NPC")
        {
            _isInsideTrigger = true;
            _animator.SetBool("open", true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            _isInsideTrigger = false;
            _animator.SetBool("open", false);
        }

        else if (other.tag == "NPC")
        {
            _isInsideTrigger = true;
            _animator.SetBool("open", false);
        }
    }

    private bool IsOpenPanelActive
    {
        get
        {
            return OpenPanel.activeInHierarchy;
        }
    }

    // Update is called once per frame
    void Update () {
        
        if(Input.GetKeyDown(KeyCode.E) && _isInsideTrigger)
        {
            _animator.SetBool("open", true);
        }
	}
}
