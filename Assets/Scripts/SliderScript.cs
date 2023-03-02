using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderScript : MonoBehaviour
{
    Slider slider;
    
    [SerializeField]private bool isMusic;
    [SerializeField]private bool isSFX;

    private void Awake() {
        slider = GetComponent<Slider>();
    }

    private void Update() {
        if(isMusic){
        slider.value = AudioManager.Instance.MusicSource().volume;
        }

        if(isSFX){
        slider.value = AudioManager.Instance.SFXSource().volume;
        }
    }
}
