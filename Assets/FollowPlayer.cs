using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {


    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}

    void FixedUpdate()
    {
        Vector2 toTarget = player.transform.position - transform.position;
        float speed = 10f;

        transform.Translate(toTarget * speed * Time.deltaTime);
    }
}
