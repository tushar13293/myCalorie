using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bmrCalculator : MonoBehaviour {

	public Slider AgeSlider;
	public Slider WeightSlider;
	public Slider HeightSlider;
    public Dropdown GenderDropdown;

	public Text bmrText;
    public static double calorieScore;


    //Invoked when a submit button is clicked.
    public void SubmitSliderSetting()
    {
        //Displays the value of the slider in the console.
        Debug.Log(AgeSlider.value);
        Debug.Log(WeightSlider.value);
        Debug.Log(HeightSlider.value);
        Debug.Log(GenderDropdown.value);
        
        if(GenderDropdown.value == 0) {
            double a = ((10 * WeightSlider.value) + (6.25 * HeightSlider.value) - (5 * AgeSlider.value) + 5) * 1.2;
            Debug.Log(a);
            calorieScore = (int)a;

            bmrText.text = "Your ideal calorie intake is : " + a.ToString() + " Calories/Day";
        }

        else {
            double a = ((10 * WeightSlider.value) + (6.25 * HeightSlider.value) - (5 * AgeSlider.value) - 161) * 1.2;
            Debug.Log(a);
            calorieScore = (int)a;

            bmrText.text = "Your ideal calorie intake index is : " + a.ToString() + " Calories/Day";
        }
        

    }
	
}
