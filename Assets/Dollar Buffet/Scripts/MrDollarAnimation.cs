using UnityEngine;
using System.Collections;

public class MrDollarAnimation : MonoBehaviour
{
	public AudioClip[] m_eatingSounds;

	private int m_currentFrame = 1;
	private Animator m_animator;

	private void Start()
	{
		m_animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if(BigRedButton.Instance.Pressed || Input.GetKeyDown(KeyCode.Space))
		{
			int randomSound = Random.Range(0, m_eatingSounds.Length);
			GetComponent<AudioSource>().PlayOneShot(m_eatingSounds[randomSound], 0.32F);

			m_currentFrame++;
			if(m_currentFrame > 4) m_currentFrame = 1;
			m_animator.SetInteger("EatingFrame", m_currentFrame);
		}
	}
}
