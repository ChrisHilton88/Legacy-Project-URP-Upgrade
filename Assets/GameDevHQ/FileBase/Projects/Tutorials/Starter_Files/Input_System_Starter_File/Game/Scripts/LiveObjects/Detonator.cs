using UnityEngine;

namespace Game.Scripts.LiveObjects
{
    public class Detonator : MonoBehaviour
    {
        private bool _c4Placed;

        private MeshRenderer _render;

        [SerializeField] private C4 _c4;
        [SerializeField] private InteractableZone[] _interactableZone;


        void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
        }

        void Start()
        {
            _render = GetComponent<MeshRenderer>();
        }

        void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            if (_c4Placed != true && zone.GetZoneID() == 1) // placed C4
            {             
                PlaceC4(zone.GetItems()[0].transform);
                _c4Placed = true;                
            }
        }

        public void TriggerExplosion()
        {
            if (_c4Placed == false)
                return;

            _c4.Explode();
            _c4Placed = false;
            _interactableZone[1].CompleteTask(2);
            gameObject.SetActive(false);
        }

        void PlaceC4(Transform target)
        {
            _c4.Place(target);
            _c4.gameObject.SetActive(true);
            _c4Placed = true;
            _interactableZone[0].CompleteTask(1);
        }

        public void Show()
        {
            _render.enabled = true;
        }

        void Ondisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
        }
    }
}

