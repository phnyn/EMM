using UnityEngine;
using Vuforia;

public class ButtonEventHandler : MonoBehaviour
{
    float _speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for(int i=0; i < vbs.Length; ++i){
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        }
    }

    void OnButtonPressed(VirtualButtonBehaviour vb){

        switch(vb.VirtualButtonName){
            case "btn1":
                if(transform.position.z <4.5){
                    transform.position += new Vector3(0,0,0.1f)*_speed;
                }
                break;
            case "btn2":
                 if( -4.5 <transform.position.z){
                    transform.position += new Vector3(0,0,0.1f)*_speed;
                }
                break;
            case "btn3":
                break;
            case "btn4":
                break;
        }
    }

    void OnButtonReleased(VirtualButtonBehaviour vb){
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
