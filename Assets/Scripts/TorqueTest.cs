using UnityEditor;
using UnityEngine;

public class TorqueTest : MonoBehaviour
{
    private PhysicsBody physicsBody;
    public Vector3 torqueDirection;
    public Vector3 torquePosition;
    public float torqueFactor;

    private void Awake()
    {
        physicsBody = GetComponent<PhysicsBody>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            physicsBody.AddTorque(torquePosition, torqueDirection * torqueFactor);
        }

 

    }
    private void OnDrawGizmos()
    {
        Debug.DrawLine(transform.position, torquePosition, Color.black, Mathf.Infinity);
        Debug.DrawLine(torquePosition, torquePosition + torqueDirection, Color.red, Mathf.Infinity);
        Handles.Label(torquePosition, "Torque Position");
        Handles.Label(torquePosition + torqueDirection, "Torque Direction");

    }

}
