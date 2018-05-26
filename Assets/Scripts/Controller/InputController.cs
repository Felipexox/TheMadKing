using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController {

    KeyCode leftKey;
    KeyCode upKey;
    KeyCode rightKey;
    KeyCode downKey;
    KeyCode actionKey;
    KeyCode runKey;

    float walkVelocity;
    float runVelocity;

    public InputController(KeyCode leftKey, KeyCode upKey, KeyCode rightKey, KeyCode downKey, KeyCode actionKey, KeyCode runKey, float walkVelocity, float runVelocity)
    {
        this.leftKey = leftKey;
        this.upKey = upKey;
        this.rightKey = rightKey;
        this.downKey = downKey;
        this.actionKey = actionKey;
        this.runKey = runKey;
        this.walkVelocity = walkVelocity;
        this.runVelocity = runVelocity;
    }

    public Vector3 GetDirection()
    {
        Vector3 direction = Vector3.zero;

        direction.x = GetDirectionX();
        direction.z = GetDirectionZ();
        return direction;
    }

    public float GetDirectionX()
    {
        if (Input.GetKey(leftKey))
            return -1;
        else if (Input.GetKey(rightKey))
            return 1;
        return 0;
    }

    public float GetDirectionZ()
    {
        if (Input.GetKey(upKey))
            return 1;
        else if (Input.GetKey(downKey))
            return -1;
        return 0;
    }

    public bool GetActionButton()
    {
        if (Input.GetKey(actionKey))
            return true;
        return false;
    }

    public float GetSpeed()
    {
        if (Input.GetKey(runKey))
            return runVelocity;
        return walkVelocity;
    }

}
