﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour {

	[SerializeField] Sprite sprite1;
	[SerializeField] Sprite sprite2;
	[SerializeField] Sprite sprite3;
	[SerializeField] Sprite sprite4;

	[SerializeField] SpriteRenderer[] sprites;

	private int nextInput;

	// Use this for initialization
	void Start() {
		nextInput = 0;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKeyDown(KeyCode.A)) {
			sprites[nextInput].sprite = sprite1;
			nextInput++;
		} else if (Input.GetKeyDown(KeyCode.S)) {
			sprites[nextInput].sprite = sprite2;
			nextInput++;
		} else if (Input.GetKeyDown(KeyCode.D)) {
			sprites[nextInput].sprite = sprite3;
			nextInput++;
		} else if (Input.GetKeyDown(KeyCode.F)) {
			sprites[nextInput].sprite = sprite4;
			nextInput++;
		}

		if (nextInput >= sprites.Length) {
			nextInput = 0;
		}
	}
}
