using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.SceneManagement;

public class questpickup : MonoBehaviour {
    
    bool enter;
    public string QuestTitle;
    public QuestState newQuestState = QuestState.Success;
    public string message;
    public string LeveltoLoad;
    void Start()

    {
        enter = false;
      
      
    }

    // Update is called once per frame
    void Update()
    {
        if (enter == true && Input.GetKeyDown(KeyCode.E))
        {
            QuestLog.SetQuestState(QuestTitle, newQuestState);
            Destroy(this.gameObject);
            SceneManager.LoadScene(LeveltoLoad);
        }
    }


    // Use this for initialization
    void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player"))
        {
            
            DialogueManager.ShowAlert(message);
            enter = true;
        }
	}

}
