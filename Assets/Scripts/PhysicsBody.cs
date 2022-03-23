using UnityEngine;

public class PhysicsBody : MonoBehaviour
{
    public float mass;
    public Vector3 velocity;
    public Vector3 angularVelocity;

    private float rotX;
    private float rotY;
    private float rotZ;

    private void FixedUpdate()
    {
        SetVelocity();
        SetAngularVelocity();
    }

    public void AddForce(Vector3 forceVector)
    {
        Vector3 accelerationVector = forceVector / mass;
        velocity += accelerationVector * Time.deltaTime;
    }

    private void SetVelocity()
    {
        transform.position += velocity * Time.deltaTime;
    }

    private void SetAngularVelocity()
    {
        rotX += (180 / Mathf.PI) * angularVelocity.x * Time.deltaTime;
        rotY += (180 / Mathf.PI) * angularVelocity.y * Time.deltaTime;
        rotZ += (180 / Mathf.PI) * angularVelocity.z * Time.deltaTime;

        transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);
    }

    public void AddTorque(Vector3 _torquePosition,Vector3 _torqueDirection)
    {
        Vector3 radiusVector = _torquePosition - transform.position;
        Vector3 torqueVector = Vector3.Cross(radiusVector, _torqueDirection);
        angularVelocity += torqueVector * Time.deltaTime;
    }
}
