using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControll : MonoBehaviour
{

    public Transform target; //Player Objekt
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //distance between player object and camera
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate offset 
        Vector3 offsetRotated = target.rotation * offset;

        //camera rotation same as player rotation
        transform.rotation = target.rotation;

        //follows player object with a certain offset + rotated if player is rotated
        transform.position = target.transform.position + offsetRotated;
    }
}
