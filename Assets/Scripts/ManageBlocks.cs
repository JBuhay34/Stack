using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBlocks : MonoBehaviour {

    private ArrayList blocks;
    private GameObject currentMovingBlock;
    public GameObject player;
    public GameObject blockPrefab;

	// Use this for initialization
	void Start () {
        blocks = new ArrayList();

        blocks.Add(Instantiate(blockPrefab));

        currentMovingBlock = blocks[blocks.Count - 1] as GameObject;

	}
	
	// Update is called once per frame
	void Update () {

        if (!currentMovingBlock.GetComponent<BlockMovement>().GetIsMoving())
        {
            int position = blocks.Count - 1;

            blocks.Add(Instantiate(blockPrefab));
            currentMovingBlock = blocks[position] as GameObject;
            currentMovingBlock.transform.position = new Vector3(-8, position * 1.01f, 0);


        }
		
	}


    public GameObject getCurrentBlockPrefab()
    {
        return currentMovingBlock;
    }
}
