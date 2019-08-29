using Platformer.Gameplay;
using UnityEngine;

using static Platformer.Core.Simulation;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a gameobject as a spawnpoint in a scene.
    /// </summary>
    /// 
    [RequireComponent(typeof(BoxCollider2D))]
    public class SpawnPoint : MonoBehaviour
    {
        private BoxCollider2D boxCollider;

        private void Start()
        {
            boxCollider = GetComponent<BoxCollider2D>();
            boxCollider.isTrigger = true;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.gameObject.GetComponent<PlayerController>();
            if (player != null) OnPlayerEnter();
        }

        private void OnPlayerEnter()
        {
            //send an event into the gameplay system to perform some behaviour.
            var ev = Schedule<PlayerSpawnCollision>();
            ev.spawnPoint = this;
        }
    }
}
