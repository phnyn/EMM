using UnityEngine;
using Vuforia;
using UnityEngine.Events;

public class ButtonEventHandler : MonoBehaviour
{
    //public Transform transform;
    public GameObject vbs;
    float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {   vbs = GameObject.Find("btn1");
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0; i < vbs.Length; ++i){
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    void OnButtonPressed(VirtualButtonBehaviour vb){
        switch(vb.VirtualButtonName){
            case "btn1": //rechts
                    transform.localPosition = Vector3.forward * Time.deltaTime *_speed;
                    Debug.Log("rechts");
                break;
            case "btn2": //oben
                                transform.Translate(0,0,1);
                                Debug.Log("oben");

                    // transform.position += Vector3.forward * Time.deltaTime * _speed;
                break;
            case "btn3": //unten
                            transform.Translate(0,0,1);
                            Debug.Log("Unten");

                    //transform.position += Vector3.forward * Time.deltaTime * _speed;
                break;
            case "btn4": //links
                                transform.Translate(0,0,1);
                                Debug.Log("Links");

                     //transform.position += Vector3.forward * Time.deltaTime * _speed;
                break;
        }
    }

    void OnButtonReleased(VirtualButtonBehaviour vb){
        
    }

}
