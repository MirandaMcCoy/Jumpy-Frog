using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour {

    private void Start()
    {
        Screen.SetResolution(960, 600, false);
    }

    // When user presses enter key, game scene is loaded
    void Update () {
		if (Input.GetKeyDown("return"))
        {
            SceneManager.LoadScene("Scene_GamePlay");
        }
	}
}
