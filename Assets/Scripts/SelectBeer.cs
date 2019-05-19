using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SelectBeer : MonoBehaviour
{
	[SerializeField] GameObject myPrefab;
	private List<BeerColorController> beerUnderUniversal = new List<BeerColorController>();
	[SerializeField] HandleUIPoint handleUIPoint;

	private int ind = 0;
	// Start is called before the first frame update


	private void Start () {

		for (int i = 1; i <= CrossSceneArgs.allBeers; i++)
		{
			string assetPath = "Assets/Json/Parsed/Beer" + i + ".asset";
			BeerInfo beerInfo = AssetDatabase.LoadAssetAtPath<BeerInfo>(assetPath);

			//GameObject newPrefab = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
			myPrefab.GetComponent<BeerColorController>().beerInfo = beerInfo;
			beerUnderUniversal.Add(myPrefab.GetComponent<BeerColorController>());
		}

		foreach (BeerColorController beer in beerUnderUniversal) {
			beer.gameObject.SetActive(false);
		}

		SetupBeer(beerUnderUniversal[ind]);


	}

	private void Update () {
#if UNITY_EDITOR
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			SwitchToLeftBeer();
		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			SwitchToRightBeer();
		}

#endif
	}

	public void SwitchToLeftBeer () {
		beerUnderUniversal[ind].gameObject.SetActive(false);
		ind--;
		if (ind < 0) {
			ind = beerUnderUniversal.Count - 1;
		}

		SetupBeer(beerUnderUniversal[ind]);

	}

	public void SwitchToRightBeer () {

		beerUnderUniversal[ind].gameObject.SetActive(false);
		ind++;
		if (ind >= beerUnderUniversal.Count) {
			ind = 0;
		}

		SetupBeer(beerUnderUniversal[ind]);
	}

	void SetupBeer (BeerColorController beerColorController) {
		beerUnderUniversal[ind].ChangeMaterial();
		handleUIPoint.pir = beerColorController.beerInfo;
		handleUIPoint.ChangeInfo();
		beerUnderUniversal[ind].gameObject.SetActive(true);
	}
}
