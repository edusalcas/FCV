using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private float targetAngle = 0;
    const float rotationAmount = 5.0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.E))
        {
            targetAngle += 90.0f * Input.GetAxis("RotateCamara");
        } 

        if(targetAngle != 0)
        {
            Rotate();
        }

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desirePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

    private void Rotate()
    {

        if (targetAngle < 0)
        {
            transform.RotateAround(target.position, Vector3.up, rotationAmount);
            targetAngle += rotationAmount;
            offset = transform.position - target.position;
        }
        else if (targetAngle > 0)
        {
            transform.RotateAround(target.transform.position, Vector3.up, -rotationAmount);
            targetAngle -= rotationAmount;
            offset = transform.position - target.position;
        }
    }
}
