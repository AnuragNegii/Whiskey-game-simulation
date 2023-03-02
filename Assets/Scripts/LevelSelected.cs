using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelected : MonoBehaviour
{   
    [SerializeField] string levelName;
    [SerializeField] int level;

    public void OpenScene(){
        SceneManager.LoadScene(levelName);
    }
}
