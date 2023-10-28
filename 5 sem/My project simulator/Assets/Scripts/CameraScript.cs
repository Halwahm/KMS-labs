using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Transform _startCameraPos;
    [SerializeField] private Vector3 _endCameraPos;
    [SerializeField] private Vector3 _endCameraRot;
    [SerializeField] private Transform targetTransform;

    public static readonly Vector3 initialPosition = new Vector3(0, 0, 0);
    public static readonly Quaternion initialRotation = Quaternion.Euler(0, 0, 0);
    private Vector3 currentPosition = initialPosition, targetPosition = initialPosition;
    private Quaternion currentRotation = initialRotation, targetRotation = initialRotation;


    private Quaternion _rot;
    private Quaternion _startRot;

    public float rotationSpeed;
    public float movementSpeed;
    public int maxX;
    public int minX;
    public int maxZ;
    public int minZ;

    void Start()
    {
        _startRot = Quaternion.Euler(45f, 0, 0);
        _rot = Quaternion.Euler(_endCameraRot);
        _startCameraPos = _camera.transform;
    }

    void Update()
    {
        MoveCamera();

        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetTransform.position, Vector3.up, Input.GetAxis("Mouse X") * 2);
            targetPosition = transform.position;
            targetRotation = transform.rotation;
        }

        float mouseWheelValue = Input.GetAxis("Mouse ScrollWheel");
        if (mouseWheelValue != 0)
        {
            Vector3 transformDirection = transform.TransformDirection(mouseWheelValue * 2f * Vector3.up);
            transform.position += transformDirection;

            if (transform.position.y < 2f) transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
            if (transform.position.y > 5f) transform.position = new Vector3(transform.position.x, 5f, transform.position.z);

            targetPosition = transform.position;
            targetRotation = transform.rotation;
        }
    }

    void MoveCamera()
    {
        float horizontal = -Input.GetAxis("Horizontal"); 
        float vertical = -Input.GetAxis("Vertical"); 

        Vector3 newPosition = transform.position + new Vector3(horizontal, 0, vertical) * movementSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, minX, maxX);
        newPosition.z = Mathf.Clamp(newPosition.z, minZ, maxZ);

        transform.position = newPosition;
    }
}
