﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public GameObject youWinText;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }
    void Start()
    {
        youWinText.SetActive(false);
    }

    public void Win()
    {
        youWinText.SetActive(true);


    }
}
