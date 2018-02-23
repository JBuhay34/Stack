using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour {

    public int numBlocks;
    public GameObject[] blocks;
    public GameObject block;
	// Use this for initialization
	void Start () {

        blocks = new GameObject[numBlocks];

        for (int i = 0; i < blocks.Length; i++) {

            GameObject go = Instantiate(block, new Vector3(-6, (i) * 5, 0), Quaternion.identity) as GameObject;

            blocks[i] = go;
		}

	}
	
	// Update is called once per frame
	void Update () {
        Rigidbody rb = blocks[0].GetComponent<Rigidbody>();
        rb.velocity = new Vector3(5, 0, 0);


	}
}
