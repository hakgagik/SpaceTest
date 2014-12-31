using UnityEngine;
using System.Collections;

public class NewBehaviourScript : Gravity {
    //NOTE: Make this a global variable in the future.
    public float G = 1.0f;

    public override Vector3 GetField(Vector3 position)
    {
        Vector3 force;
        Vector3 displacement = position - transform.position;
        float r = displacement.magnitude;
        force = -G * rigidbody.mass * displacement / (r * r * r);

        return force;
    }
}
