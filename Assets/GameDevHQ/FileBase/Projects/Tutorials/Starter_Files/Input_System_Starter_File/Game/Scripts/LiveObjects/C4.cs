using Game.Scripts.Interfaces;
using UnityEngine;

namespace Game.Scripts.LiveObjects
{
    public class C4 : MonoBehaviour
    {
        private Collider[] hits = new Collider[5];

        [SerializeField] private GameObject _explosionPrefab;

        // C4 Exploding - Called from Detonator
        public void Explode()
        {
            Instantiate(_explosionPrefab, transform.position, Quaternion.identity);

            var count = Physics.OverlapSphereNonAlloc(transform.position, 1, hits);
            
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

            gameObject.SetActive(false);         
        }

        public void Place(Transform target)
        {
           transform.SetPositionAndRotation(target.position, target.rotation);
           transform.parent = null;
        }
    }
}

