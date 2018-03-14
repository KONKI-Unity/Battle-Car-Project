using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public float distance;
    public float height;
    public float rotationDamping;
    public float heightDamping;
    public float zoomRatio;
    public float defaultPOV;

    private float rotation_vector;


    void FixedUpdate()
    {
        Vector3 target_velocity = target.GetComponent<Rigidbody>().velocity;
        
        Vector3 local_velocity = target.InverseTransformDirection(target_velocity);
        if (local_velocity.z < -0.5f)
        {
            rotation_vector = target.eulerAngles.y + 100;
        }
        else
        {
            rotation_vector = target.eulerAngles.y;
        }
        float acceleration = target.GetComponent<Rigidbody>().velocity.magnitude;
        Camera.main.fieldOfView = defaultPOV + acceleration * zoomRatio * Time.deltaTime;
    }

    void LateUpdate()
    {
        float wantedAngle = rotation_vector;
        float wantedHeight = target.position.y + height;
        float cameraAngle = transform.eulerAngles.y;
        float cameraHeight = transform.position.y;

        cameraAngle = Mathf.LerpAngle(cameraAngle, wantedAngle, rotationDamping * Time.deltaTime);
        cameraHeight = Mathf.LerpAngle(cameraHeight, wantedHeight, heightDamping * Time.deltaTime);

        Quaternion currentRotation = Quaternion.Euler(0, cameraAngle, 0);
        transform.position = target.position;
        transform.position -= currentRotation * Vector3.forward * distance;

        Vector3 tmp = transform.position;
        tmp.y = cameraHeight;
        transform.position = tmp;

        transform.LookAt(target);



    }

}
