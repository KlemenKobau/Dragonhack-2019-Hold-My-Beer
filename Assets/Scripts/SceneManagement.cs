using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void gotToApp()
	{
		SceneManager.LoadScene("VuforiaTest arrows");
	}

	public void GoToPicutreMode()
	{
		SceneManager.LoadScene("VuforiaPicture");
	}

	
}
