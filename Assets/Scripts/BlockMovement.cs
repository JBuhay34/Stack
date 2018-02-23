using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour {

    public int numBlocks;
    public GameObject block;
    public GameObject player;

    public Rigidbody[] blocksRb;
    public GameObject[] blocks;
    private Vector3 moveRight;
    private Vector3 moveLeft;
    private bool isMovingRight;
    private bool isStopped;

    // Use this for initialization
    void Start() {

        moveRight = new Vector3(5, 0, 0);
        moveLeft = new Vector3(-5, 0, 0);

        blocks = new GameObject[numBlocks];
        blocksRb = new Rigidbody[numBlocks];

        for (int i = 0; i < blocks.Length; i++) {

            GameObject go = Instantiate(block, new Vector3(-6, (i+.6f) * block.transform.localScale.y, 0), Quaternion.identity) as GameObject;

            blocks[i] = go;
            blocksRb[i] = blocks[i].GetComponent<Rigidbody>();
        }

        isMovingRight = true;
        isStopped = false;


    }

    // Update is called once per frame
    void FixedUpdate() {
        Debug.Log(DoesPlayerLandOnBlock(blocksRb[0]));
        if (DoesPlayerLandOnBlock(blocksRb[0]))
        {

            blocksRb[0].velocity = new Vector3(0, 0, 0);
            isStopped = true;
        }

        BlockMoveLeftAndRight(blocksRb[0]);




    }

    // This method makes the block move left and right.
    void BlockMoveLeftAndRight(Rigidbody rb)
    {
        if (isMovingRight && !isStopped)
        {
            rb.velocity = moveRight;
            if (rb.position.x >= 6)
            {
                isMovingRight = false;
            }
        }
        else if(!isMovingRight && !isStopped)
        {
            rb.velocity = moveLeft;
            if (rb.position.x <= -6)
            {
                isMovingRight = true;
            }
        }
    }

    // Determines whether or not player lands on the block. If it does. it will stop movement.
    bool DoesPlayerLandOnBlock(Rigidbody rb)
    {

        if((rb.transform.position.x >= -1) && (rb.transform.position.x <= 1) && ( player.transform.position.y <=  rb.transform.localScale.y + 1.05 && player.transform.position.y >= rb.transform.localScale.y + 1))
        {

            return true;
        }
        else
        {
            return false;
        }

       
    }
    
}
