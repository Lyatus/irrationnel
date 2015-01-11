using UnityEngine;
using System.Collections;

public class FadeToBlackScript : MonoBehaviour {

	public GUITexture texture;

	private GameObject crabe;
	private GUIText text;
	private float opacity =0.0f;
	
	void Start () {
		texture.color = new Color (texture.color.r, texture.color.g, texture.color.b, opacity);
		crabe = GameObject.FindGameObjectWithTag("crabe");
        text = GameObject.FindWithTag("text").GetComponent<GUIText>();
        text.enabled = false;
	}

	void Update(){
		if (!crabe.renderer.isVisible) {
			if(opacity <1.0f)
				opacity += 0.01f;
            else
            {
                text.enabled = true;
                Invoke("NextScene", 4);
            }
		}
	}

	void FixedUpdate(){
		texture.color = new Color (texture.color.r, texture.color.g, texture.color.b, opacity);
	}

    void NextScene() { Application.LoadLevel("Scene 3"); }


}