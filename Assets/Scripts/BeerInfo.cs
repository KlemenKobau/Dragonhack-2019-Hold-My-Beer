using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "BeerInfo", menuName = "KobauCar/BeerInfo", order = 1)]
public class BeerInfo : ScriptableObject
{
    public string title;
    public string style;
    public float alcohol;
    public string color;
    public float IBU;
}