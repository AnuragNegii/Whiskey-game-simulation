using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [SerializeField] private Sound[] musicSounds, sfxSounds;
    [SerializeField] AudioSource musicSource, sfxSource;
    public AudioSource MusicSource(){return musicSource;}
    public AudioSource SFXSource(){return sfxSource;}

    private void Awake(){
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    private void Start() {
        PlayMusic("Theme");
    }

    public void PlayMusic(string name){
        Sound sound = Array.Find(musicSounds, x => x.name == name);

        if(sound == null){
            Debug.Log("sound not Found");
        }
        else{
            musicSource.clip = sound.clip;
            musicSource.Play();
        }
    }
    public void PlaySFX(string name){
        Sound sound = Array.Find(sfxSounds, x => x.name == name);

        if(sound == null){
            Debug.Log("sound not Found");
        }
        else{
            sfxSource.PlayOneShot(sound.clip);
        }
    }

    public void ToggleMusic(){
        musicSource.mute = !musicSource.mute;
    }
    public void ToggleSFX(){
        sfxSource.mute = !sfxSource.mute;
    }

    public void MusicVolume(float volume){
        musicSource.volume = volume;
    }
    public void SFXVolume(float volume){
        sfxSource.volume = volume;
    }

    public void ClickSound(){
        AudioManager.Instance.PlaySFX("Click");
    }

}
