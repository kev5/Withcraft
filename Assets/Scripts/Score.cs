﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {

    public int score;
    public int toWin;

	// Use this for initialization
	void Start () {
        score = 0;
    }
	
	// Update is called once per frame
	void Update () {
		if(score >= toWin) {
            SceneManager.LoadScene("WinScreen");
        }
	}
}
