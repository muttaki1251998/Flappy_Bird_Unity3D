using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingGround : MonoBehaviour {

    private Rigidbody2D rgbd;

	// Use this for initialization
	void Start () {
        rgbd = GetComponent<Rigidbody2D>();
        rgbd.velocity = new Vector2(GameController.instance.scrollSpeed, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if(GameController.instance.gameOver == true)
        {
            rgbd.velocity = Vector2.zero;
        }
	}
}
