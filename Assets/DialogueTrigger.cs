using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    [SerializeField]private Message[] messages;
    [SerializeField] private Actor[] actors;

    public void StartDialogue(){
       FindObjectOfType<DialogueManager>().OpenDialogue(messages, actors);
    }
}   


[System.Serializable]
public class Message{
    public int actorId;
    public string messsage;
}

[System.Serializable]
public class Actor{
    public string name;
    public Sprite sprite;
}