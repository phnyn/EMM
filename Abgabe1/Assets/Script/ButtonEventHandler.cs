using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{
    public Transform player;
    public PlayerController playerController; 
    public float _speed = 5f;
    public float _rotation = 5f;

    bool forward, backward, left, right;

    void Start() 
    { 
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour> ();
        for (int i = 0; i < vbs.Length; ++i) {
        // Register with the virtual buttons TrackableBehaviour
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
            Debug.Log("Hier: "+ vbs[i].GetComponent<VirtualButtonBehaviour>().VirtualButtonName);
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

        //up & down
        //player.transform.position += updown;
        //player.transform.Translate(0,0,moveVertical);
        /*
        String button = vb.VirtualButtonName;
        float moveHorizontal = Time.deltaTime * _rotation;
        float moveVertical = Time.deltaTime * _speed;

        //rechts
        if(button == "btn1"){ 
            moveHorizontal *= 0.9f;
            player.transform.rotation *= Quaternion.Euler(0,20,0); 
            Debug.Log("right");
        }

        //up
        if(button == "btn2"){
            player.transform.position += (new Vector3(0,0,0.5f)+targetDirection)*_speed;
            Debug.Log("up");
        }

        //down
        if(button == "btn3"){
            player.transform.position += (new Vector3(0,0,-0.5f)+targetDirection)*_speed;
            Debug.Log("down");
        }
        //links
        if(button == "btn4"){
            moveHorizontal *= -0.9f;
            player.transform.rotation *= Quaternion.Euler(0,-20,0); 
            Debug.Log("left");
        }

        //targetDirection = new Vector3(Mathf.Sin(moveHorizontal), 0, Mathf.Cos(moveHorizontal));
        //Rotate player 
        //player.transform.rotation *= Quaternion.LookRotation(targetDirection); */
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
