﻿
using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{
	void Start() 
	{
		this.gameObject.AddComponent<BoardManager>();
		this.gameObject.AddComponent<ScoreManager>();
		this.gameObject.AddComponent<PlayerManager>();
	}
}
