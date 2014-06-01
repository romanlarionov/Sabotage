﻿
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MouseMovement : MonoBehaviour 
{
	private GameObject gameManager;
	private BoardManager boardManagerScript;
	private IList<Tile> tiles;
	private Tile _hitTile;

	void Start()
	{
		gameManager = GameObject.FindGameObjectWithTag("GameManager");
		boardManagerScript = gameManager.GetComponent<BoardManager>();
		tiles = boardManagerScript.tiles;
	}

	void Update() 
	{
		if (Input.GetMouseButtonDown(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Debug.DrawRay(ray.origin, ray.direction, Color.red);
			
			RaycastHit hit;

			// If the ray hits something when the left mouse button is down.
			if (Physics.Raycast(ray, out hit, Mathf.Infinity))
			{
				GameObject hitObject = hit.collider.gameObject;
				// If the GameObject hit is a Tile.
				if (hitObject.name.Equals("Tile"))
				{
					// Loop through the list of tile until the GameObject matches... not elegant, but it works.
					foreach (Tile t in tiles)
					{
						if (t.tile == hitObject)
						{
							_hitTile = t;
						}
					}
					Debug.Log("It hit a Tile!!");
				}
			}
		}
	} // Update
} // MouseMovement










