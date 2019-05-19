using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerColorController : MonoBehaviour
{
	public BeerInfo beerInfo;
	[SerializeField] Renderer renderer;

	

	Dictionary<int, string> srmToColor = new Dictionary<int, string>() 
	{{1, "ffff45"},
		{ 2, "ffff45"},
	{3, "ffe93e"},
	{4, "fed849"},
	{5, "fed849"},
 {6, "ffa846"},
 {7, "ffa846"},
 {8, "f49f44"},
 {9, "f49f44"},
 {10, "f49f44"},
 {11, "d77f59"},
 {12, "d77f59"},
 {13, "d77f59"},
 {14, "94523a"},
 {15, "94523a"},
 {16, "94523a"},
 {17, "804541"},
 {18, "804541"},
 {19, "804541"},
 {20, "5b342f"},
 {21, "5b342f"},
 {22, "5b342f"},
 {23, "4c3b2b"},
 {24, "4c3b2b"},
 {25, "4c3b2b"},
 {26, "4c3b2b"},
 {27, "38302e"},
 {28, "38302e"},
 {29, "38302e"},
 {30, "38302e"},
 {31, "38302e"},
 {32, "38302e"},
 {33, "38302e"},
 {34, "38302e"},
 {35, "38302e"},
 {36, "31302c"},
 {37, "31302c"},
 {38, "31302c"},
 {39, "31302c"},
 {40, "31302c"}};


	// Start is called before the first frame update
	void Start()
    {
		
    }

	public void ChangeMaterial () {
		Material mat = renderer.material;
		string srm = beerInfo.color;

		float aprox;
		float.TryParse(srm, out aprox);
		int final_value = Mathf.RoundToInt(aprox);

		string hex;
		srmToColor.TryGetValue(final_value, out hex);
		hex = "#" + hex;
		Color newCol;
		ColorUtility.TryParseHtmlString(hex, out newCol);

		mat.SetColor("_Tint", newCol);
	}
}
