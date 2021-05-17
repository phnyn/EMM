using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float _speed = 5f;
    private float _rotation = 5f;
    private Vector3 targetDirection;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // left and right
        float moveHorizontal = Input.GetAxis("Horizontal") * _rotation * Time.deltaTime;

        //up and down
        float moveVertical = Input.GetAxis("Vertical") * _speed * Time.deltaTime;

        //move player up and down z
        transform.Translate(0,0,moveVertical);

        targetDirection = new Vector3(Mathf.Sin(moveHorizontal), 0, Mathf.Cos(moveHorizontal));

        //Rotate player 
        transform.rotation *= Quaternion.LookRotation(targetDirection);
    } 

}