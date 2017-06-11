
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.SceneManagement;

public class questpress : MonoBehaviour
{

    public string QuestTitle;
    public QuestState newQuestState = QuestState.Success;
    public string message;

    // Use this for initialization
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            QuestLog.SetQuestState(QuestTitle, newQuestState);
            DialogueManager.ShowAlert(message);
            Destroy(this.gameObject);
        }
    }

}
