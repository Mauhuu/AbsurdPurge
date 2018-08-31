using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {

    public GameObject img;
    
    // Use this for initialization
    void Start() {

        img.SetActive(false);
    }

    // Update is called once per frame
    void Update() { 
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            img.SetActive(true);
            
        }
        
    }
   

}
