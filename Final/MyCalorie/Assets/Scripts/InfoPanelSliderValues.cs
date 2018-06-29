using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelSliderValues : MonoBehaviour {

	Text ageSliderValue;

	void Start () {
		ageSliderValue = GetComponent<Text> ();
	}

	public void valueUpdate (float value){
		ageSliderValue.text = Mathf.RoundToInt(value).ToString();
	}

}
