using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject ant;
    [SerializeField] private Vector3 offset;
    private void LateUpdate()
    {
        transform.position = ant.transform.position + offset;
    }
}
