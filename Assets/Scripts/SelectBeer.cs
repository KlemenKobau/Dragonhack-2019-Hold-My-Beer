using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBeer : MonoBehaviour
{

	[SerializeField] List<BeerColorController> beerUnderUniversal;
	[SerializeField] HandleUIPoint handleUIPoint;

	private int ind = 0;
	// Start is called before the first frame update


	private void Start () {
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
