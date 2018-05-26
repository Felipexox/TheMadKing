using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

    InputController _inputController;

    Rigidbody rigidBody;

    [SerializeField]
    float walkSpeed;
    [SerializeField]
    float runSpeed;

    // Use this for initialization
    void Start()
    {
        _inputController = new InputController(KeyCode.A, KeyCode.W, KeyCode.D, KeyCode.S, KeyCode.Space, KeyCode.LeftShift, walkSpeed, runSpeed);
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Move(_inputController.GetDirection(), _inputController.GetSpeed());

    }


    void Move(Vector3 direction, float velocity)
    {
        direction = direction.normalized * velocity;
        rigidBody.velocity = direction;
    }


    void OnTriggerStay(Collider other)
    {
        BaseInteraction baseInteraction = other.GetComponent<BaseInteraction>();
        if(baseInteraction != null)
        {
            if (_inputController.GetActionButton())
            {
                Interact(baseInteraction);
            }
        }
    }
    void Interact(BaseInteraction ObjInteract)
    {
         ObjInteract.Interact();
    }

}
