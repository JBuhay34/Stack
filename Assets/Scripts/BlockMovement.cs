using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour {

	private GameObject myprefab;
	// Use this for initialization
	void Start () {
		myprefab = Resources.Load ("blocks") as GameObject;
		for (int i = 0; i < 10; i++) {
			GameObject block1 = Instantiate (myprefab);
			block1.transform.position = new Vector3 (0, (i+1)*5,0);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
