using UnityEngine;
using System.Collections;

public class MoveCube : MonoBehaviour
{	
	Vector3 m_direction;

	void Start()
	{
		m_direction = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(-2.0f, 2.0f));
	}

	void Update()
	{
		transform.eulerAngles = new Vector3(Time.time*120.0f, Time.time*60.0f, 0.0f);

		transform.position += m_direction*Time.deltaTime;

		Vector3 randomDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
		transform.position += randomDirection*Time.deltaTime;
	}
}
