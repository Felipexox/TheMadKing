using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooker : BaseInteraction {

    public override void Interact()
    {
        base.Interact();
        Debug.Log("Interacted");
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}
