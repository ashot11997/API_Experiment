using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class APISytem : MonoBehaviour
{
	public Button CallBtn;

	public LoadMountains MountainsLoader;

	private List<PlacesList> PlacesList = new List<PlacesList>();

	public Transform Content;

	public MountainsPrefab Prefab;

	public GameObject LoadingText;

	private void Awake()
	{
		CallBtn.onClick.AddListener(CallMountains);
	}

	void CallMountains() {
		LoadingText.SetActive(true);
		PlacesList.Clear();
		foreach (Transform item in Content)
		{
			Destroy(item.gameObject);
		}

		StartCoroutine(MountainsLoader.Load((mountain, count) => {
			PlacesList.Add(mountain);
			if (PlacesList.Count == count)
			{
				LoadingText.SetActive(false);
				AddPlaces(PlacesList);
			}
		}));
	}

	void AddPlaces(List<PlacesList> Places) {
		foreach (var item in Places)
		{
			var place = Instantiate(Prefab, Content);
			place.Setup(item);
		}
	}
}
