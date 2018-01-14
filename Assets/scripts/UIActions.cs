﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIActions : MonoBehaviour {

	public void Restart()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("thelevel");
	}

	public void ToggleView()
	{
		Slot[] slots = FindObjectOfType<PlayerManager>().slots;
		for(int i = 0; i < slots.Length; i++)
		{
			if(i != 13)
			{
				slots[i].GetComponent<MeshRenderer>().enabled = !slots[i].GetComponent<MeshRenderer>().enabled;
				slots[i].GetComponent<BoxCollider>().enabled = !slots[i].GetComponent<BoxCollider>().enabled;
			}
		}
	}
}
