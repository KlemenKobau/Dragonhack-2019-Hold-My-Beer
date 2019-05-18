﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerColorController : MonoBehaviour
{
	[SerializeField] BeerInfo beerInfo;
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
 {18, "804541"},
 {20, "5b342f"},
 {24, "4c3b2b"},
 {30, "38302e"},
 {40, "31302c"}};


	// Start is called before the first frame update
	void Start()
    {
		Material mat = renderer.material;
		string srm = beerInfo.color;

		float aprox;
		float.TryParse(srm, out aprox);
		int final_value = Mathf.RoundToInt(aprox);


		string hex;
		srmToColor.TryGetValue(final_value, out hex);
		Color newCol;
		if (ColorUtility.TryParseHtmlString(hex, out newCol))

		mat.SetColor("Tint", newCol);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
