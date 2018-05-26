using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InputController {

    [SerializeField]
    private KeyCode leftKey;
    [SerializeField]
    private KeyCode upKey;
    [SerializeField]
    private KeyCode rightKey;
    [SerializeField]
    private KeyCode downKey;
    [SerializeField]
    private KeyCode actionKey;
    [SerializeField]
    private KeyCode runKey;

    float walkVelocity;
    float runVelocity;

    public KeyCode LeftKey
    {
        get
        {
            return leftKey;
        }

        set
        {
            leftKey = value;
        }
    }

    public KeyCode UpKey
    {
        get
        {
            return upKey;
        }

        set
        {
            upKey = value;
        }
    }

    public KeyCode RightKey
    {
        get
        {
            return rightKey;
        }

        set
        {
            rightKey = value;
        }
    }

    public KeyCode DownKey
    {
        get
        {
            return downKey;
        }

        set
        {
            downKey = value;
        }
    }

    public KeyCode ActionKey
    {
        get
        {
            return actionKey;
        }

        set
        {
            actionKey = value;
        }
    }

    public KeyCode RunKey
    {
        get
        {
            return runKey;
        }

        set
        {
            runKey = value;
        }
    }

    public Vector3 GetDirection()
    {
        Debug.Log(DownKey);
        Vector3 direction = Vector3.zero;

        direction.x = GetDirectionX();
        direction.z = GetDirectionZ();
        return direction;
    }

    public float GetDirectionX()
    {
        if (Input.GetKey(LeftKey))
            return -1;
        else if (Input.GetKey(RightKey))
            return 1;
        return 0;
    }

    public float GetDirectionZ()
    {
        if (Input.GetKey(UpKey))
            return 1;
        else if (Input.GetKey(DownKey))
            return -1;
        return 0;
    }

    public bool GetActionButton()
    {
        if (Input.GetKey(ActionKey))
            return true;
        return false;
    }

    public float GetSpeed()
    {
        if (Input.GetKey(RunKey))
            return runVelocity;
        return walkVelocity;
    }

}
