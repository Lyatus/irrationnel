using UnityEngine;
using System.Collections;

public class Pinups : MonoBehaviour {
	public Sprite[] sprites;
	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	void Update () {
		if(Random.Range(0,200)==0)
			spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length-1)];
		else
			spriteRenderer.sprite = null;
	}
}
