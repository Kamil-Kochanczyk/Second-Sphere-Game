﻿using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
	void Start()
	{
		DontDestroyOnLoad(gameObject);
	}
}