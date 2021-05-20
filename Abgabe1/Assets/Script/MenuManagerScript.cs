using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject menu;
    public Button _restart, _return;
    bool canvas;
    // Start is called before the first frame update
    void Start(){
        menu.SetActive(false);
        canvas = false;
        _restart.onClick.AddListener(Restart);
        _return.onClick.AddListener(Return);
    }

    // Update is called once per frame
    void Update()
    { 

        if(Input.GetKey(KeyCode.Escape)){
            Debug.Log(canvas);
            if(canvas == false){
                menu.SetActive(true);
                Time.timeScale = 0;
                canvas = true;
            }
        }
    }

    //TODO wenn Escape nochmal dann auch raus!
    void Return(){
        menu.SetActive(false);
        Time.timeScale = 1;
        canvas = false;
        Debug.Log("Return");
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        Debug.Log("Restart");
    }

}
