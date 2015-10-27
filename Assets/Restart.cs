using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.R))
		   {
			
			Pathermaker.floorMakerCount = 1;
			Pathermaker.totalTiles = 0;
			Application.LoadLevel(0);
		}
	
	}
}
