using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInput : MonoBehaviour {
    public Text gt;
    private string[] word = {"strong"};

    void Start(){
        gt = GetComponent<Text>();
    }

    public void Update(){
        foreach(char letter in Input.inputString){
            string firstLetter = word[0].Substring(0, 1);
            if(firstLetter == letter){
                word[0] = word[0].Remove(0, 1);
            }
        }
    }
}
