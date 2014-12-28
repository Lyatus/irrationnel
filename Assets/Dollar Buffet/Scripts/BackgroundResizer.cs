using UnityEngine;
using System.Collections;

public class BackgroundResizer : MonoBehaviour
{
	private void Start()
	{
		Resize();
	}

	//Call this function whenever the camera aspect ratio
	//or orthographic size changes
	public void Resize()
	{
		//Compute background scale to fit screen
		float scaleY = Camera.main.orthographicSize * 2.0f;
		float scaleX = scaleY * Camera.main.aspect;
		transform.localScale = new Vector2(scaleX, scaleY);
	}
}
