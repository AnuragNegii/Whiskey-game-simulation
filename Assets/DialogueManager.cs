using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{

    [SerializeField] private Image actorImage;
    [SerializeField] private Text actorName, messageText;
    [SerializeField] RectTransform backgroundBox;

    Message[] currentMessages;
    Actor[] currentActors;

    int activeMessage = 0;
    public static bool isActive = false;

    void Start()
    {
        
    }

    void Update()
    {
        if(isActive == true){
            if(Input.GetKeyDown(KeyCode.Space)){
                NextMessage();
            }
        }
    }

    public void OpenDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessage = 0;
        isActive = true;
        Debug.Log("started conversation! Loaded messages " + messages.Length);
        DisplayMessage();
    }
    private void DisplayMessage(){
        Message messageToDisplay = currentMessages[activeMessage];
        messageText.text = messageToDisplay.messsage;
        
        Actor actorToDisplay = currentActors[messageToDisplay.actorId];
        actorName.text = actorName.name;
        actorImage.sprite = actorToDisplay.sprite;
    }

    public void NextMessage(){
        activeMessage++;
        if(activeMessage < currentMessages.Length){
            DisplayMessage();
        }else{
            Debug.Log("Conversation ended");
            isActive = false;
        }
    }
}
