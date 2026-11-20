using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;

    private void Update()
    {
        RotateObject();
    }

    void RotateObject()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
