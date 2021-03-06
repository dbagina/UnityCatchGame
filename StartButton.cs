﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	//references to the game objects we want to interact with when starting the game
	public GameObject buttonsPanel;

	//this will act with the Start button to start the game
	public void StartGame () {
		buttonsPanel.SetActive (false);
		//start spawning objects once the start button is clicked
		SceneManager.LoadScene (2);
	}
}
