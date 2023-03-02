using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class Characters : ScriptableObject
{
    public new string name;
    public string description;
    public Sprite artwork;

    [TextArea (3,10)]
    public string[] dialouges;

    public void Print(){
        Debug.Log(name + ": " + description + " The owner of the winery");
    }
    
}
