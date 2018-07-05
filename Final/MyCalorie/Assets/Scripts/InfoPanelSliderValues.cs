using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelSliderValues : MonoBehaviour {

	Text SliderValue;

	void Start () {
		SliderValue = GetComponent<Text> ();
	}

	public void valueUpdate (float value){
		SliderValue.text = Mathf.RoundToInt(value).ToString();
	}

}
