using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleUIPoint : MonoBehaviour
{
    private Vector3 screenPos;
    public GameObject panel;
	private float distanceToCam = 0.7f;

    [SerializeField] private BeerInfo pir;
	[SerializeField] private Text NameText;
	[SerializeField] private Text StyleText;

	private void Start () {
		NameText.text = "Name: " + pir.title;
		StyleText.text = "Style: " + pir.style;
	}
}
