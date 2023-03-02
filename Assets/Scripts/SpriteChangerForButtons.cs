using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;


public class SpriteChangerForButtons : MonoBehaviour
{
    
    [SerializeField] private Sprite[] sprite;
    Image image;

    [SerializeField]private bool isPressed;
    private void Awake() {
        image = GetComponent<Image>();
        
        image.sprite = sprite[0];
    }
    private void Update() {

        if (isPressed){
            ButtonPushed();
        }
        else{
            image.sprite =sprite[0];
        }
    }

    public void ButtonPushedOnWindow(){
        AudioManager.Instance.PlaySFX("Click");
        if(isPressed == true){
            isPressed = false;
            return;
        }
        isPressed = true;

    }

    private void ButtonPushed(){
        image.sprite = sprite[1];
    }

}
