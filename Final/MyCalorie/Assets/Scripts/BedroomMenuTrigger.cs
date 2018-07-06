using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class BedroomMenuTrigger : MonoBehaviour {

	Collider2D m_ObjectCollider;
    public Image Popup;
    public Text KitchenPopupText;
    public Text GymPopupText;
    public Text BedroomPopupText;

    public static int caloriesBurntWhileSleeping = 0;

    void Start()
    {
        m_ObjectCollider = GetComponent<Collider2D>();
        Popup.enabled = false;
        KitchenPopupText.enabled = false;
        GymPopupText.enabled = false;
        BedroomPopupText.enabled = false;
        Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
    }

    void Update() {
        if (Input.GetKeyDown("s"))
        {
            caloriesBurntWhileSleeping = caloriesBurntWhileSleeping + 500;
            //Debug.Log(CalorieScore.calories);
            SceneManager.LoadScene ("weightlostScene");
        }
    }

    void OnTriggerEnter2D()
    {
        //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
        m_ObjectCollider.isTrigger = true;
        Debug.Log(Popup.enabled);
        Popup.enabled = true;
        BedroomPopupText.enabled = true;
    }

    void OnTriggerExit2D()
    {
        Popup.enabled = false;
        BedroomPopupText.enabled = false;
        Debug.Log("Fridge");
    }

}
