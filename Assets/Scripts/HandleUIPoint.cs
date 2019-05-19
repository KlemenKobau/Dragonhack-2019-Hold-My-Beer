﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleUIPoint : MonoBehaviour
{
    private Vector3 screenPos;
    public GameObject panel;
	private float distanceToCam = 0.7f;

    public BeerInfo pir;
	[SerializeField] private Text NameText;
	[SerializeField] private Text StyleText;
	[SerializeField] private Text AlcoholText;
	[SerializeField] private Text IBUText;

	void OnEnable()
    {
        ChangeInfo();
    }


	public void ChangeInfo () {
		NameText.text = pir.title;
		StyleText.text = pir.style;
		AlcoholText.text = pir.alcohol + "%";
		IBUText.text = pir.IBU.ToString();
	}
}
