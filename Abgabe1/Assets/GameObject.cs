using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObject : MonoBehaviour
{
    public Transform myPrefab;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i < 8;i++){
            Vector3 vec = new Vector3(UnityEngine.Random.Range(-5,5),0,UnityEngine.Random.Range(-5,5));

            Instantiate(myPrefab,vec, Quaternion.Euler(UnityEngine.Random.Range(-50,50),UnityEngine.Random.Range(-50,50),UnityEngine.Random.Range(-50,50)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
