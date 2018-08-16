using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameObject youWinText;

    private void Start()
    {
        youWinText.SetActive (false);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player")) {
            youWinText.SetActive (true);
            Destroy(gameObject);
        }
    }
}
