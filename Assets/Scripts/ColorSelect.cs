using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSelect : MonoBehaviour
{
    public Dropdown ColorDropdown;
    public Dropdown SizeDropdown;
    public GameObject PlayerBall;

    public void ChooseColor() // use in the change event for the dropdown
    {
        switch (ColorDropdown.value)
        {
            case 1:
                PlayerBall.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                PlayerBall.GetComponent<Renderer>().material.color = Color.white;
                break;
            case 3:
                PlayerBall.GetComponent<Renderer>().material.color = Color.blue;
                break;
            default:
                PlayerBall.GetComponent<Renderer>().material.color = Color.black;
                break;
        }
    }
}
