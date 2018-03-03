using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLandOnBlock : MonoBehaviour {

    public ManageBlocks blockManager;
    private GameObject currentMovingBlock;
    private BlockMovement currentMovingBlockMovement;

	// Use this for initialization
	void Start () {

       currentMovingBlock = blockManager.getCurrentBlockPrefab();
       currentMovingBlockMovement = currentMovingBlock.GetComponent<BlockMovement>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		switch (col.tag) {
		case "block": 
			Debug.Log ("It hits block");
            // Need to get the current block that is moving in order to make this method work.
			currentMovingBlockMovement.SetIsMoving(false);
			break;
		}
	}
}
