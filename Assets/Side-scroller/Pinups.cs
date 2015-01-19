using UnityEngine;
using System.Collections;

public class Pinups : MonoBehaviour {
	public Sprite[] sprites;
	SpriteRenderer spriteRenderer;
	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	void Update () {
		if(Random.Range(0,50)==0)
			spriteRenderer.sprite = sprites[Random.Range(0,sprites.Length-1)];
		else if(Random.Range(0,1)==0)
			spriteRenderer.sprite = null;
	}
}
