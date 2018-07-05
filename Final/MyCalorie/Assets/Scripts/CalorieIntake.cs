using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalorieIntake : MonoBehaviour {

	//public int calorieInFood;	
	public InputField chooseQuantityInputField;
	public static string storeTag;
	public static int calorieTakenFromFood;
	public static int totalCalorieTaken = 0;
	public static int totalCalorieBurnt = 0;

	public static int caloriesBurnt;


	public void storeTagOfFood() {
		storeTag = gameObject.tag;
		Debug.Log(storeTag);
	}

	public void storeTagOfWorkout() {
		storeTag = gameObject.tag;
		Debug.Log(storeTag);
	}

	public void calculateCaloriesInFood() {
		switch(storeTag) {
			case "milk" : {
				//calorieInFood = 146;
				calorieTakenFromFood = 140 * int.Parse(chooseQuantityInputField.text);
				Debug.Log(storeTag);
				Debug.Log(calorieTakenFromFood);
				break;
			}
			case "bread" :{
				//calorieInFood = 75;
				calorieTakenFromFood = 75 * int.Parse(chooseQuantityInputField.text);
				Debug.Log(storeTag);
				Debug.Log(calorieTakenFromFood);
				break;
			}
                
		}

		totalCalorieTaken = totalCalorieTaken + calorieTakenFromFood;
		CalorieScore.energyBarValue = CalorieScore.energyBarValue + 10;
	}


	public void calculateCaloriesBurntInWorkout() {
		switch(storeTag) {
			case "trademill" : {
				//calorieInFood = 146;
				caloriesBurnt = 10 * int.Parse(chooseQuantityInputField.text);
				Debug.Log(storeTag);
				Debug.Log(calorieTakenFromFood);
				break;
			}
			case "bread" :{
				//calorieInFood = 75;
				caloriesBurnt = 75 * int.Parse(chooseQuantityInputField.text);
				Debug.Log(storeTag);
				Debug.Log(calorieTakenFromFood);
				break;
			}
                
		}

		totalCalorieBurnt = totalCalorieBurnt + caloriesBurnt;
		CalorieScore.energyBarValue = CalorieScore.energyBarValue - 5;
	}
	

	// void calorieCalculator() {

	// }

}
