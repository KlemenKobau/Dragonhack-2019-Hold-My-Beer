using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleUIPoint : MonoBehaviour
{
    private Vector3 screenPos;
    public GameObject panel;

    // Update is called once per frame
    void Update()
    {
        panel.transform.rotation = Camera.main.transform.rotation;
    }
}
