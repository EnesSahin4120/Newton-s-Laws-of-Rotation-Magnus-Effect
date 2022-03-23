using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffectTest : MonoBehaviour
{
    public PhysicsBody physicsBody;

    private void Start()
    {
        StartCoroutine(MagnusProcess());
    }

    private IEnumerator MagnusProcess()
    {
        float countDown = 2;
        while (countDown > 0)
        {
            countDown -= Time.deltaTime;
            physicsBody.AddForce(PhysicsOperation.MagnusVector(physicsBody));
            yield return null;
        }
    }
}
