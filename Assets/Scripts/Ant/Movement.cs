using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    private void Update()
    {
        float translationX = Input.GetAxis("Horizontal");
        float translationY = Input.GetAxis("Vertical");

        Vector3 translation = new Vector3(translationX, translationY, 0);

        transform.position += translation * Time.deltaTime * speed;

        if (translation != Vector3.zero)
        {
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, translation);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
        }
    }
}
