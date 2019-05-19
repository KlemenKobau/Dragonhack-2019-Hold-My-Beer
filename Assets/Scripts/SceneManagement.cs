using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void gotToApp()
	{
		CrossSceneArgs.numBeers = CrossSceneArgs.allBeers;
		SceneManager.LoadScene("VuforiaTest arrows");
	}

	public void goToRandom()
	{
		int n = CrossSceneArgs.numBeers;
	}
}
