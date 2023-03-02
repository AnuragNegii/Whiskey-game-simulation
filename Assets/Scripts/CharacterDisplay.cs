using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CharacterDisplay : MonoBehaviour
{
    [SerializeField] private Characters characters;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private Image artworkImage;
    [SerializeField] private TextMeshProUGUI dialouges;

    [SerializeField] Animator animator;
    private Queue<string> sentences = new Queue<string>();

    void Start()
    {
        nameText.text = characters.name;
        artworkImage.sprite = characters.artwork;
        sentences = new Queue<string>();
    }


    public void StartDialogue(){
        animator.SetBool("IsOpen", true);
        sentences.Clear();
        foreach(string dialouge in characters.dialouges){
            sentences.Enqueue(dialouge);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count== 0){
            EndDialouge();
            return;
        }
        string sentence = sentences.Dequeue();
       StartCoroutine(TypeSentence(sentence));
    }

    public void EndDialouge()
    {
        animator.SetBool("IsOpen", false);
    }

    IEnumerator TypeSentence(string sentence){
        dialouges.text = "";
        foreach(char letter in sentence.ToCharArray()){
            dialouges.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }

    public void TriggerDialuge(){

    }

}
