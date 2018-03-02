using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageBlocks : MonoBehaviour {

    private List<GameObject> blocks;
    private GameObject currentMovingBlock;
    public GameObject player;
    public GameObject blockPrefab;

	// Use this for initialization
	void Start () {
        blocks = new List<GameObject>();

        blocks.Add(Instantiate(blockPrefab));

	}
	
	// Update is called once per frame
	void Update () {
        
		
	}
}
