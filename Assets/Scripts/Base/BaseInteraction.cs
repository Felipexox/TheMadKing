using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInteraction : MonoBehaviour {

    public virtual void Interact()
    {

    }

    public virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou no " + this.name);
    }
}
