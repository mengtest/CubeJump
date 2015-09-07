﻿using UnityEngine;
using System.Collections;

public class QuitShop : MonoBehaviour {

	public Transform shopscreen;
	public Transform over;
	public Transform StopBtn;
	// Use this for initialization
	public void ExitShop(){
		gameObject.SetActive (false);
	}

	public void InShop(){
		shopscreen.GetComponent<Animator>().Play ("shopIn");
	}
	public void OnContinue(){
		Time.timeScale = 1;
		Game.pause = false;
		StopBtn.gameObject.SetActive (true);
	}

	public void GameOverFixDisappear(){
		over.gameObject.SetActive (false);
	}

}