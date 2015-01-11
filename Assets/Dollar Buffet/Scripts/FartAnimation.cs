using UnityEngine;
using System.Collections;

public class FartAnimation : MonoBehaviour
{
	public float m_animationTime;
	private float m_elapsed = 0.0f;

	void Update()
	{
		m_elapsed += Time.deltaTime;
		if(m_elapsed >= m_animationTime)
		{
			Destroy(this.gameObject);
		}
	}
}
