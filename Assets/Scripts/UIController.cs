using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class UIController : MonoBehaviour
{   

    public Button leftButton, rightButton;

    [SerializeField] SelectBeer pir;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update() {

    }

    public void TaskOnClickLeft() {
        pir.SwitchToLeftBeer();
    }

    public void TaskOnClickRight() {
        pir.SwitchToRightBeer();
    }
}
