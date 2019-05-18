using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBeer : MonoBehaviour
{

	[SerializeField] List<BeerColorController> beerUnderUniversal;

	private int ind = 0;
	// Start is called before the first frame update


	private void Start () {
		foreach (BeerColorController beer in beerUnderUniversal) {
			beer.gameObject.SetActive(false);
		}

		beerUnderUniversal[ind].ChangeMaterial();
		beerUnderUniversal[ind].gameObject.SetActive(true);


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

		beerUnderUniversal[ind].ChangeMaterial();
		beerUnderUniversal[ind].gameObject.SetActive(true);

	}

	public void SwitchToRightBeer () {

		beerUnderUniversal[ind].gameObject.SetActive(false);
		ind++;
		if (ind >= beerUnderUniversal.Count) {
			ind = 0;
		}
		beerUnderUniversal[ind].ChangeMaterial();
		beerUnderUniversal[ind].gameObject.SetActive(true);
	}
}
