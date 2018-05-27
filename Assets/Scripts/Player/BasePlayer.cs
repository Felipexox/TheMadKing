using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer : MonoBehaviour {
    [SerializeField]
    private PlayerAnimationController animController = new PlayerAnimationController();
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
        if (!_inputController.GetDirection().Equals(Vector3.zero))
        {
            animController.PlayWalk();
        }else
        {
            animController.StopWalk();
        }
    }


    void Move(Vector3 direction, bool isRunning)
    {
        float velocity = (isRunning) ? runSpeed : walkSpeed;

        direction = direction.normalized * velocity;
        rigidBody.velocity = direction;
    }


    protected void OnTriggerStay(Collider other)
    {
        BaseInteraction baseInteraction = other.GetComponent<BaseInteraction>();
        if(baseInteraction != null)
        {
            if (_inputController.GetActionButton())
            {
                Interact(baseInteraction);
                animController.PlayInteraction();
            }else
            {
                animController.StopInteraction();
                StopInteract(baseInteraction);
            }
        }
    }
    protected void OnTriggerExit(Collider other)
    {
        BaseInteraction baseInteraction = other.GetComponent<BaseInteraction>();
        if (baseInteraction != null)
        {
            StopInteract(baseInteraction);
            animController.StopInteraction();
        }
    }
    void Interact(BaseInteraction ObjInteract)
    {
         ObjInteract.Interact();
    }
    void StopInteract(BaseInteraction ObjInteract)
    {
        ObjInteract.StopInteract();
    }

    void TriggerInteraction(Collider other)
    {

    }
}
