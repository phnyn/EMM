using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (0<moveVertical){
            if(transform.position.z < 5){
                transform.position +=  new Vector3(0,0,0.1f)*_speed;
            }
        }
        if (moveVertical<0){
            if(-5 < transform.position.z){
                transform.position +=  new Vector3(0,0,-0.1f)*_speed;
            }
        }
        if (moveHorizontal<0){
            if(-5 < transform.position.x){
                transform.position +=  new Vector3(-0.1f,0,0)*_speed;
            }
        }
        if (0<moveHorizontal){
            if(transform.position.x < 5){
                transform.position += new Vector3(0.1f,0,0)*_speed;
            }
        } 

        if(Input.GetKey(KeyCode.Y)){
            transform.rotation = Quaternion.Euler(10,0,0); 
        }
    }

}