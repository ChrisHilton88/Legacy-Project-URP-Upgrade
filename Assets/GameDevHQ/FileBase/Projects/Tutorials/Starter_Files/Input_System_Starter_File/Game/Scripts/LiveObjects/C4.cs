using Game.Scripts.Interfaces;
using UnityEngine;

namespace Game.Scripts.LiveObjects
{
    public class C4 : MonoBehaviour
    {
        private Collider[] hits = new Collider[5];

        [SerializeField] private GameObject _explosionPrefab;

        // This gets called from the Detonator
        public void Explode()
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);

            // Computes and stores colliders touching or inside the sphere into the provided buffer.
            var count = Physics.OverlapSphereNonAlloc(transform.position, 1, hits);
            
            // It will explode above, cycle through the collider array and then destroy itself
            if (count > 0)
            {
                foreach (var obj in hits)
                {
                    if (obj != null)
                    {
                        if (obj.TryGetComponent(out IDestroyable destroyable))
                            destroyable.DestroyAction();
                    }
                }
            }
            
            Destroy(gameObject);           
        }

        public void Place(Transform target)
        {
           transform.SetPositionAndRotation(target.position, target.rotation);
           transform.parent = null;
        }
    }
}

