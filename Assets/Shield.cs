using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour {


    public float coolDown = 1;
    public float cooldownTimer;
    public GameObject img;
    
    // Use this for initialization
    void Start() {

        img.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
            
        }
        if (cooldownTimer < 0)
        {
            img.SetActive(false);
            cooldownTimer = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space) && cooldownTimer == 0)
        {
            Turnon();
            cooldownTimer = coolDown;
        }

    }

    void Turnon()
    {
        img.SetActive(true);
    }







}
