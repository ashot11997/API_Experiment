using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APISytem : MonoBehaviour
{
	public Button CallBtn;

	public LoadMountains MountainsLoader;

	private void Awake()
	{
		CallBtn.onClick.AddListener(CallMountains);
	}

	void CallMountains() {
		StartCoroutine(MountainsLoader.Load((mountain, count) => {

		}));
	}
}
