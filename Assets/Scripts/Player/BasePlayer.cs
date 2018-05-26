using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

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
        //rigidBody.MovePosition((Vector2)transform.position + direction);
    }

    protected virtual void OnTriggerStay(Collider other)
    {
        BaseInteraction baseInteraction = other.GetComponent<BaseInteraction>();
        if(baseInteraction != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Interact(baseInteraction);
            }
        }
    }
    protected virtual void Interact(BaseInteraction ObjInteract)
    {
         ObjInteract.Interact();
    }

}
