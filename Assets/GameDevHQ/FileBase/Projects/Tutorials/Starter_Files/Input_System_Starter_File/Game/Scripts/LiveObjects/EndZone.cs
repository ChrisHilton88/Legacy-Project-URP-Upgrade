using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Scripts.LiveObjects
{
    public class EndZone : MonoBehaviour
    {
        void OnEnable()
        {
            InteractableZone.onZoneInteractionComplete += InteractableZone_onZoneInteractionComplete;
        }

        void InteractableZone_onZoneInteractionComplete(InteractableZone zone)
        {
            if (zone.GetZoneID() == 7)
            {
                InteractableZone.CurrentZoneID = 0;
                SceneManager.LoadScene(0);
            }
        }

        void OnDisable()
        {
            InteractableZone.onZoneInteractionComplete -= InteractableZone_onZoneInteractionComplete;
        }
    }
}