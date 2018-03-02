using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLandOnBlock : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		switch (col.tag) {
		case "block": 
			Debug.Log ("It hits block");
            // Need to get the current block that is moving in order to make this method work.
			//BlockMovement.SetIsMoving(false);
			break;
		}
	}
}
