using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class HandleUIPoint : MonoBehaviour
{
    private Vector3 screenPos;
    public GameObject panel;

    [SerializeField] private List<BeerInfo> piri;

    // Update is called once per frame
    void Update()
    {
        panel.transform.rotation = Camera.main.transform.rotation;
    }
}
