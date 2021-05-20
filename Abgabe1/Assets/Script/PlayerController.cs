using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 3f;
    public float _rotation = 10f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)){
            Forward();
        }

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            RotateLeft();
        }

        if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
            Backward();
        }

        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            RotateRight();
        }
        
        /*
        // left and right
        float moveHorizontal = Input.GetAxis("Horizontal") * _rotation * Time.deltaTime;

        //up and down
        float moveVertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        //move player up and down z
        transform.Translate(0,0,moveVertical);

        targetDirection = new Vector3(Mathf.Sin(moveHorizontal), 0, Mathf.Cos(moveHorizontal));

        //Rotate player 
        transform.rotation *= Quaternion.LookRotation(targetDirection); */
    } 

    public void Forward()
    {
        Transform oldPos = this.transform;
        //if( oldPos.position.x < Border.xmax & Border.xmin < oldPos.position.x){
            this.transform.Translate(Vector3.forward*Time.deltaTime*_speed);
        //}
        //CheckBorders(oldPos);
    }
        public void Backward()
    {
        Transform oldPos = this.transform;
        //if(CheckBorders(oldPos)){
            this.transform.Translate(Vector3.back*Time.deltaTime*_speed);
       // }
    }

    // braucht Time.deltaTime  -_> wenn Time.timescale = 0 danns stoppt es auch
        public void RotateLeft()
    {
        this.transform.Rotate(0,(-10*Time.deltaTime*_rotation),0);
    }
        public void RotateRight()
    {
        this.transform.Rotate(0,10*Time.deltaTime*_rotation,0);
    }

/*
    bool CheckBorders(Transform oldPos){
        if(oldPos.position.x < Border.xmin ||  Border.xmax < oldPos.position.x || oldPos.position.z < Border.zmin ||  Border.zmax < oldPos.position.z){
            return false;
            //this.transform.Translate(oldPos.position.x,oldPos.position.y,oldPos.position.z);
        } else{
            return true;
        }

        if( ){
            return false;
            //this.transform.Translate(oldPos.position.x,oldPos.position.y,oldPos.position.z);
        } else{
            return true;
        } 
    } */
}