using Platformer.Gameplay;
using UnityEngine;
using UnityEngine.Events;
using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a trigger as a VictoryZone, usually used to end the current game level.
    /// </summary>
    public class VictoryZone : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnVictory;

        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                OnVictory?.Invoke();
                var ev = Schedule<PlayerEnteredVictoryZone>();
                ev.victoryZone = this;
            }
        }
    }
}