#pragma strict

var sprites : SpriteRenderer[];
var solution : Sprite[];

function Start() {
	
}

function Update() {
	var isValid : boolean = true;
	var isFull : boolean = true;
	for	(var i = 0; i < sprites.length; i++) {
		isFull = isFull && !!sprites[i].sprite;
		isValid = isValid && sprites[i].sprite == solution[i];
	}
	if (isFull) {
		if (isValid) {
			Debug.Log('Complete!');
		} else {
			Debug.Log('Wrong... :(');
		}
		for (var sprite in sprites){
			sprite.sprite = null;
		}	
	}
}
