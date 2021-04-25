using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public Transform myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0,0,0), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(5,0,3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(-3,0,-9), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
