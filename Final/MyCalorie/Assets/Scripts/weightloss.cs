using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class weightloss : MonoBehaviour {

	public Text weightlossText;
	private double weightlossValue;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		weightlossValue = 0.000128 * CalorieScore.calories;
		weightlossText.text = "Congratulations!! You have lost " +  weightlossValue.ToString() + " Kgs";
	}
}
