using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LoadMountains : MonoBehaviour
{

	private string JsonUrl = "https://drive.google.com/uc?id=1i31oF4XbEfW39RX-dQSUxTi9cLbh31my";

	public IEnumerator Load(Action<PlacesList, int> callback)
	{
		Debug.Log("Loading Categories");
		WWW www = new WWW(JsonUrl);
		yield return www;
		if (www.error == null)
		{
			ProcessJson(www.text, callback);
		}


	}

	void ProcessJson(string data, Action<PlacesList, int> callback)
	{
		Tenplate dest = JsonUtility.FromJson<Tenplate>(data);

		foreach (PlacesList x in dest.List)
		{
			callback.Invoke(x, dest.List.Count);
		}
	}
}
