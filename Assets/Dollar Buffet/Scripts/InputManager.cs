using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	public Transform m_cubePrefab;

	private void Update()
	{
		if(m_cubePrefab && Input.GetKeyDown(KeyCode.Space))
		{
			Transform.Instantiate(m_cubePrefab, new Vector3(0, 0, 1), Quaternion.identity);
		}
	}
}
