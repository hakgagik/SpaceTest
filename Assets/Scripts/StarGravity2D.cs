using UnityEngine;
using System.Collections;

public class StarGravity2D : Gravity {

    //NOTE: Make this a global variable in the future.
    public float G = 1.0f;

    public override Vector3 GetField(Vector3 position)
    {
        Vector3 force;
        Vector3 displacement = position - transform.position;
        // In 2D, F/m = GM/r instead of GM/r^2
        force = -G * rigidbody.mass * displacement / displacement.sqrMagnitude;

        return force;
    }
}
