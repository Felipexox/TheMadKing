using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {

    [SerializeField]
    InputController _inputController;
    Rigidbody rigidBody;

    [SerializeField]
    float walkSpeed;
    [SerializeField]
    float runSpeed;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        Move(_inputController.GetDirection(), _inputController.GetRun());

    }


    void Move(Vector3 direction, bool isRunning)
    {
        float velocity = (isRunning) ? runSpeed : walkSpeed;

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
