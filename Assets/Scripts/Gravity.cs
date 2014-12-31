using UnityEngine;
using System.Collections;

public abstract class Gravity : MonoBehaviour {
    public abstract Vector3 GetField(Vector3 pos);
}
