using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsOperation : MonoBehaviour
{
    public static Vector3 MagnusVector(PhysicsBody _physicsBody)
    {
        Vector3 magnusVector = Vector3.Cross(_physicsBody.angularVelocity, _physicsBody.velocity);
        return magnusVector;
    }
}
