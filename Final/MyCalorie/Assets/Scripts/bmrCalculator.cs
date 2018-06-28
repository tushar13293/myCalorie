using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bmrCalculator : MonoBehaviour {

	public Slider AgeSlider;
	public Slider WeightSlider;
	public Slider HeightSlider;
	public Text bmrText;


    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        Debug.Log(AgeSlider.value);
        Debug.Log(WeightSlider.value);
        Debug.Log(HeightSlider.value);

        double a = (10 * WeightSlider.value) + (6.25 * HeightSlider.value) - (5 * AgeSlider.value) + 5;
        Debug.Log(a);

        bmrText.text = "Your BMR index is : " + a.ToString() + " Calories/Day";

    }
	
}
