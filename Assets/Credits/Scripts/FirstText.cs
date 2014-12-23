using UnityEngine;
using System.Collections;

public class FirstText : MonoBehaviour {


    GUIText myText;

    float speed = 0.05f;
    Vector2 direction;
	// Use this for initialization
	void Start () {
        direction = new Vector2(0.0f, 1.0f);
        myText = this.GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        myText.transform.Translate(direction.x * speed * Time.deltaTime,
                                       direction.y * speed * Time.deltaTime,
                                       0);
	}
}
