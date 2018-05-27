using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseInteraction : MonoBehaviour {
    [SerializeField]
    protected Animator animator;

   protected virtual void Start()
    {
        animator = GetComponent<Animator>();
    }

    public virtual void Interact()
    {
        animator.Play("Interact");
    }
    public virtual void StopInteract()
    {
        animator.Play("Idle");
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entrou no " + this.name);
    }



}
