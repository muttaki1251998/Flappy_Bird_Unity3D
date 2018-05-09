using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float horizontalLength;

	// Use this for initialization
	void Start () {

        groundCollider = GetComponent<BoxCollider2D>();
        horizontalLength = groundCollider.size.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.x < -horizontalLength)
        {
            RepositionGround();
        }
	}

    private void RepositionGround()
    {
        Vector2 doubledGround = new Vector2(horizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + doubledGround;
    }
}
