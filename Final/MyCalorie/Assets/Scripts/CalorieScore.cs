using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalorieScore : MonoBehaviour {

	public Text calorieText;
	public static double calories = 0;
	public Slider energyBar;
	public static int energyBarValue = 20;
	//public static int ;

	// Use this for initialization
	void Start () {
		energyBar.value = energyBarValue;
	}
	
	// Update is called once per frame
	void Update () {
		calories = bmrCalculator.calorieScore - CalorieIntake.totalCalorieTaken + CalorieIntake.totalCalorieBurnt + BedroomMenuTrigger.caloriesBurntWhileSleeping;
		calorieText.text = "Calories: " + (bmrCalculator.calorieScore - CalorieIntake.totalCalorieTaken + CalorieIntake.totalCalorieBurnt + BedroomMenuTrigger.caloriesBurntWhileSleeping).ToString();
	}
}
