using UnityEngine;
using System.Collections;
using PixelCrushers.DialogueSystem;

public class pushscript : MonoBehaviour
{

    bool enter;
    public Rigidbody rb;
 

    void Start()

    {
        enter = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true && Input.GetKeyDown(KeyCode.E)) 
        {
           rb.velocity = new Vector3(-2, 0, 0);
            
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player")) 
                                                    
        {                                            
            enter = true;                            
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player")) 
            enter = false;
        }
    }
