using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
	public Transform m_cubePrefab;
	public Transform m_fartPrefab;
	public float m_fartChance;

	private void Update()
	{
		if(m_cubePrefab && (BigRedButton.Instance.Pressed || Input.GetKeyDown(KeyCode.Space)))
		{
			Transform.Instantiate(m_cubePrefab, new Vector3(0, 0, 1), Quaternion.identity);

			if(m_fartPrefab && Random.Range(0.0f, 1.0f) < m_fartChance)
			{
				Transform.Instantiate(m_fartPrefab, new Vector3(-6, -2, 0), Quaternion.identity);
			}
		}
	}
}
