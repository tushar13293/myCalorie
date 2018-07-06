using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void openScene()
    {
        Invoke ("openMainScene", 3);
    }

    public void openMainScene() {
		SceneManager.LoadScene ("MainScene");
		Debug.Log("invoke");
	}

	public void LoadByIndex(int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
		Debug.Log("invoke");
	}

}
