﻿// This script moves the GameObject you attach in the Inspector to a Scene you specify in the Inspector.
// Attach this script to an empty GameObject.
// Click on the GameObject, go to its Inspector and type the name of the Scene you would like to load in the Scene field.
// Attach the GameObject you would like to move to a new Scene in the "My Game Object" field

// Make sure your Scenes are in your build (File>Build Settings).

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneT : MonoBehaviour
{
	// Type in the name of the Scene you would like to load in the Inspector
	public string m_Scene;

	// Assign your GameObject you want to move Scene in the Inspector
	public GameObject m_MyGameObject;

	void Update()
	{
		// Press the space key to add the Scene additively and move the GameObject to that Scene
		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine(LoadYourAsyncScene());
		}
	}

	IEnumerator LoadYourAsyncScene()
	{
		// Set the current Scene to be able to unload it later
		Scene currentScene = SceneManager.GetActiveScene();

		// The Application loads the Scene in the background at the same time as the current Scene.
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(m_Scene, LoadSceneMode.Additive);

		// Wait until the last operation fully loads to return anything
		while (!asyncLoad.isDone)
		{
			yield return null;
		}

		// Move the GameObject (you attach this in the Inspector) to the newly loaded Scene
		SceneManager.MoveGameObjectToScene(m_MyGameObject, SceneManager.GetSceneByName(m_Scene));
		// Unload the previous Scene
		SceneManager.UnloadSceneAsync(currentScene);
	}
}