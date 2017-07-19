using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class nextscene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (jumpToScene ());
	}

	IEnumerator jumpToScene (){
		yield return new WaitForSeconds (5.0f);
		SceneManager.LoadScene ("FPSController");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
