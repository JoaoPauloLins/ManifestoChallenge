using Platformer.Core;
using Platformer.Mechanics;
using Platformer.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Platformer.Gameplay
{
    public class PlayerSpawnCollision : Simulation.Event<PlayerSpawnCollision>
    {
        public SpawnPoint spawnPoint;

        PlatformerModel model = Simulation.GetModel<PlatformerModel>();

        public override void Execute()
        {
            model.spawnPoint = spawnPoint.transform;
        }
    }
}
