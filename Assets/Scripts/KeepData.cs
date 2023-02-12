using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeepData : MonoBehaviour
{

    public static float PlayingSpeed;



    public Slider speedSlider;


    
    public Text playingSpeedText;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    public void SetSpeed() //method for the slider on intro screen
    {
        PlayingSpeed = speedSlider.value;
        playingSpeedText.text = PlayingSpeed.ToString();
    }
    public void ShowSpeed() // method for clicking on playing speed button on game screen 
    {
        playingSpeedText.text = PlayingSpeed.ToString();
        speedSlider.value = PlayingSpeed; // you use the speed value here

    }
    public void ChangeSpeed() //method for slider on game screen, so you see that you can still change the value after transfer between screens
    {
        PlayingSpeed = speedSlider.value; // change to the new value from game screen slider
        playingSpeedText.text = speedSlider.value.ToString(); //show updated value
    }

}