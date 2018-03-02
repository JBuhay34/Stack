using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour {

    private Vector3 moveRight;
    private Vector3 moveLeft;
    private bool isMovingRight;
    private bool isMoving;

	public void SetIsMoving(bool isMoving){
		this.isMoving = isMoving;
	}

	private Rigidbody currentBlockRb;

    // Use this for initialization
    void Start() {
		Debug.Log ("begin");

        moveRight = new Vector3(5, 0, 0);
        moveLeft = new Vector3(-5, 0, 0);

		currentBlockRb = GetComponent<Rigidbody> ();
        isMovingRight = true;
        isMoving = true;


    }

    // Update is called once per frame
    void FixedUpdate() {

		BlockMoveLeftAndRight(currentBlockRb);

    }

    // This method makes the block move left and right.
    void BlockMoveLeftAndRight(Rigidbody rb)
    {
		if (isMovingRight && isMoving) {
			rb.velocity = moveRight;
			if (rb.position.x >= 6) {
				isMovingRight = false;
			}
		} else if (!isMovingRight && isMoving) {
			rb.velocity = moveLeft;
			if (rb.position.x <= -6) {
				isMovingRight = true;
			}
		} else {
			currentBlockRb.velocity = new Vector3(0, 0, 0);
			currentBlockRb.isKinematic = true;
		}
    }
		
}
