using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MountainsPrefab : MonoBehaviour
{
	public Text Title;
	public Text Category;
	public Text Description;
	public RawImage Thumbnail;

	public void Setup(PlacesList place, string category){
		Title.text = char.ToUpper(place.Name[0]) + place.Name.Substring(1);
		Description.text = place.Description;
		Category.text = category;
		StartCoroutine(LoadImage(place.ThumbnailUrl, texture =>{
			Thumbnail.texture = texture;
		}));
	}

	IEnumerator LoadImage(string url, Action<Texture> texture) {
		WWW www = new WWW(url);
		yield return www;
		texture.Invoke(www.texture);
	}

}