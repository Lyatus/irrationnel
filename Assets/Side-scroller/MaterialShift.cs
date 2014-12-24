using UnityEngine;
using System.Collections;

public class MaterialShift : MonoBehaviour {
	public float xps;
	public float yps;
	
	Material material;
	
	void Start () {
		material = GetComponent<MeshRenderer>().material;
	}
	void Update () {
		material.mainTextureOffset += new Vector2(xps*Time.deltaTime,yps*Time.deltaTime);
	}
}
