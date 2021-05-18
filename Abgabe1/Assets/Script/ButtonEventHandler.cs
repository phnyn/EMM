using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{
    public Transform player;
    public PlayerController playerController; 
    bool forward, backward, left, right;

    void Start() 
    { 
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for (int i = 0; i < vbs.Length; ++i) {
        // Register with the virtual buttons TrackableBehaviour
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        }
        playerController = player.GetComponent<PlayerController>();
    }
    void OnButtonPressed(VirtualButtonBehaviour vb){
        Debug.Log(vb.VirtualButtonName);
        switch(vb.VirtualButtonName){
            case "btn1": //rechts
                right = true;
                Debug.Log("right");
                break;
            case "btn2":
                forward = true;
                Debug.Log("up");
                break;
            case "btn3":
                backward = true;
                Debug.Log("down");
                break;
            case "btn4":
                left = true;
                Debug.Log("left");
                break;
        }
    }

    void OnButtonReleased(VirtualButtonBehaviour vb){
        switch(vb.VirtualButtonName){
            case "btn1": //rechts
                right = false;
                Debug.Log("right");
                break;
            case "btn2":
                forward = false;
                Debug.Log("up");
                break;
            case "btn3":
                backward = false;
                Debug.Log("down");
                break;
            case "btn4":
                left = false;
                Debug.Log("left");
                break;
        }
    }

    void FixedUpdate(){
        if(forward){
            playerController.Forward();
        } else if(backward){
            playerController.Backward();
        } 
        
        if(left){
            playerController.RotateLeft();
        } else if(right){
            playerController.RotateRight();
        }
    }

}
