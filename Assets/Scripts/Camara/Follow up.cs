using UnityEngine;

public class CameraOrbit : MonoBehaviour
{
    public GameObject ballPlayer;
    public Vector3 offSet;
    public float rotationSpeed = 50f; 

    private void Start()
    {
        transform.position = ballPlayer.transform.position + offSet;

    }

    private void LateUpdate()
    {
        transform.position = ballPlayer.transform.position + offSet;
    }
}
