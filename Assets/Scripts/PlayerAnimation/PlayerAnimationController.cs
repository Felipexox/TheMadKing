using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PlayerAnimationController{
    [SerializeField]
    private Animator _trunkUp;
    [SerializeField]
    private Animator _trunkDown;
    [SerializeField]
    private Animator _head;
	

    public void PlayWalk()
    {
        _trunkDown.Play("Feet_Walk");
    }
    public void StopWalk()
    {
        _trunkDown.Play("Feet_Idle");
    }
    public virtual void PlayInteraction()
    {
        _trunkUp.Play("Arm_Interaction");
    }
    public virtual void StopInteraction()
    {
        _trunkUp.Play("Arm_Idle");
    }
 
}
