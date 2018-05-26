using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    InputController _inputController;

    Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        _inputController = new InputController();
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        Move(_inputController.GetDirection());

	}


    void Move(Vector2 direction)
    {
        rigidBody.MovePosition((Vector2)transform.position + direction);
    }

}
