using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour {
    [SerializeField]
    private Animator _trunkUp;
    [SerializeField]
    private Animator _trunkDown;
    [SerializeField]
    private Animator _head;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _trunkDown.Play("Feet_Walk");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _trunkDown.Play("Feet_Idle");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _trunkUp.Play("Arm_Cut");
            _head.Play("Head_Cut");
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _trunkUp.Play("Arm_Idle");
            _head.Play("Head_Idle");
        }
    }
    void playAnimation(string animName)
    {
        if (_trunkUp.GetLayerIndex("Arm_" + animName) != -1)
        {
            _trunkUp.Play("Arm_" + animName);
        }
        if (_trunkDown.GetLayerIndex("Feet_" + animName) >= 0)
        {
           
        }
        if (_head.GetLayerIndex("Head_" + animName) != -1)
        {
            _head.Play("Head_" + animName);
        }
    }
}
