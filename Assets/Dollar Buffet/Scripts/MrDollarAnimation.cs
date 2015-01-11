using UnityEngine;
using System.Collections;

public class MrDollarAnimation : MonoBehaviour
{
	private int m_currentFrame = 1;
	private Animator m_animator;

	private void Start()
	{
		m_animator = GetComponent<Animator>();
	}

	private void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			m_currentFrame++;
			if(m_currentFrame > 4) m_currentFrame = 1;
			m_animator.SetInteger("EatingFrame", m_currentFrame);
		}
	}
}
