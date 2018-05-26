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
 
}
