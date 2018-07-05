﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class KitchenMenuTrigger : MonoBehaviour {

	Collider2D m_ObjectCollider;
    public Image Popup;
    public Text KitchenPopupText;
    public Text GymPopupText;

    void Start()
    {
        m_ObjectCollider = GetComponent<Collider2D>();
        Popup.enabled = false;
        KitchenPopupText.enabled = false;
        GymPopupText.enabled = false;
        Debug.Log("Trigger On : " + m_ObjectCollider.isTrigger);
    }

    void Update() {
        if (Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene ("KitchenSceneMenu");
        }
    }

    void OnTriggerEnter2D()
    {
        //GameObject's Collider is now a trigger Collider when the GameObject is clicked. It now acts as a trigger
        m_ObjectCollider.isTrigger = true;
        Debug.Log(Popup.enabled);
        Popup.enabled = true;
        KitchenPopupText.enabled = true;
    }

    void OnTriggerExit2D()
    {
        Popup.enabled = false;
        KitchenPopupText.enabled = false;
        Debug.Log("Fridge");
    }

}
