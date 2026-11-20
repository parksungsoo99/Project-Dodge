using UnityEngine;

public class Dropper_Area : MonoBehaviour
{
    [SerializeField] Dropper dropper;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            dropper.CanFalling();
        }
    }
}
