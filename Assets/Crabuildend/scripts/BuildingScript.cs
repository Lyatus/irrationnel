using UnityEngine;
using System.Collections;

public class BuildingScript : MonoBehaviour {

	private Transform[] childs;
	private int pos = 1;
	private int maxSize;
	void Start () {
		childs = GetComponentsInChildren<Transform>();
		maxSize = childs.Length;
		foreach (Transform ts in childs) {
			ts.renderer.enabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && pos < maxSize)
        {
			childs[pos].renderer.enabled = true;
			childs[pos+1].renderer.enabled = true;
			childs[pos+1].particleSystem.Play();
			pos+=2;
		}
	}
}
