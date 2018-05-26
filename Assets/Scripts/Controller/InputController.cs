using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController {

    
    public Vector2 GetDirection()
    {
        Vector2 direction = Vector2.zero;

        if (Input.GetKey(KeyCode.A))
            direction.x = -1;
        if (Input.GetAxis("Vertical") != 0)
            direction.y = Input.GetAxis("Vertical");

        return direction;
    }


}
