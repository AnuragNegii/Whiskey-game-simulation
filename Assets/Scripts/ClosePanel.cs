using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    [SerializeField]private GameObject Panel;

    public void Close(){
        if(Panel != null){
            Panel.SetActive(false);
        }

    }
}
