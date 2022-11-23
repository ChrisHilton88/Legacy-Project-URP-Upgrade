using UnityEngine;

public class Lift : MonoBehaviour
{
    [SerializeField] private GameObject _section;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Liftable"))
            other.transform.parent = transform;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Liftable"))
            other.transform.parent = _section.transform;
    }
}
