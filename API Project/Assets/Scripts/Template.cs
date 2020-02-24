using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Tenplate
{
	public List<PlacesList> List;
}

[Serializable]
public class PlacesList
{
	public string Name;
	public string ThumbnailUrl;
	public string Description;
	public string Address;
	public string Category;
	public string Distance;
	public string LongDescription;

}