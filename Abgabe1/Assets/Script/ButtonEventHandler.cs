using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{
    public Transform player;
    public float _speed = 3f;
    void Start() 
    {        
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for (int i = 0; i < vbs.Length; ++i) {
        // Register with the virtual buttons TrackableBehaviour
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
            Debug.Log("Hier: "+ vbs[i].GetComponent<VirtualButtonBehaviour>().VirtualButtonName);
        }
    }

    void OnButtonPressed(VirtualButtonBehaviour vb){
        String button = vb.VirtualButtonName;

        //rechts
        if(button == "btn1"){ 
            player.transform.rotation *= Quaternion.Euler(20,0,0); 
            Debug.Log("right");
        }

        if(button == "btn2"){
            player.transform.position += new Vector3(0,0,0.5f)*_speed;
            Debug.Log("up");

        }

        if(button == "btn3"){
            player.transform.position += new Vector3(0,0,-0.5f)*_speed;
            Debug.Log("down");

        }
        //links
        if(button == "btn4"){
            player.transform.Rotate(Vector3.left*_speed); 
            Debug.Log("left");
        }

        /*
        switch(vb.VirtualButtonName){
            case "btn1": //rechts
                    Debug.Log("right");
                break;
            case "btn2": //oben
                    player.transform.position += new Vector3(0,0,0.1f)*_speed;
                    Debug.Log("up");
                break;
            case "btn3": //unten
                    Debug.Log("down");
                break;
            case "btn4": //links
                    Debug.Log("left");
                break;
        }  */
    }

    void OnButtonReleased(VirtualButtonBehaviour vb){
        
    }

}
