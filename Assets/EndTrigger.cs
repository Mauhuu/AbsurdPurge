using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public GameObject youWinText, playerObjective, restartButton, enSpawner;

    private void Start()
    {
        enSpawner.SetActive(true);
        youWinText.SetActive (false);
        playerObjective.SetActive(true);
        restartButton.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player")) {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject target in gameObjects)
                GameObject.Destroy(target);
            GameObject[] enemySpawners = GameObject.FindGameObjectsWithTag("Spawner");
            foreach (GameObject target in enemySpawners)
                GameObject.Destroy(target);
            enSpawner.SetActive(false);
            youWinText.SetActive (true);
            playerObjective.SetActive (false);
            restartButton.SetActive(true);
            Destroy(gameObject);
        }
    }

  
}
