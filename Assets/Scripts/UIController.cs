using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{   

    public Button leftButton, rightButton;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {

    }

    public void TaskOnClickLeft() {
        Debug.Log("levo");
    }

    public void TaskOnClickRight() {
        Debug.Log("desno");
    }
}
