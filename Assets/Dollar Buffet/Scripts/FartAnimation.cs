using UnityEngine;
using System.Collections;

public class FartAnimation : MonoBehaviour
{
	public float m_animationTime;
	public AudioClip[] m_fartSounds;
	private float m_elapsed = 0.0f;

	void Start()
	{
		int randomSound = Random.Range(0, m_fartSounds.Length);
		GetComponent<AudioSource>().PlayOneShot(m_fartSounds[randomSound]);
	}

	void Update()
	{
		m_elapsed += Time.deltaTime;
		if(m_elapsed >= m_animationTime)
		{
			Destroy(this.gameObject);
		}
	}
}
