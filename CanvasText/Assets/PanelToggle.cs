using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelToggle : MonoBehaviour
{

            public Canvas myCanvas; //Your target for the refference
 
        void OnTriggerEnter(Collider myCanvas)
            {
        if (gameObject.tag == "Activate")
        {
            myCanvas.enabled = true;
        }
    }

            void OnTriggerExit()
            {
                myCanvas.enabled = false;
            }
        }
