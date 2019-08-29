using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player Points", menuName = "Player Points")]
public class PlayerPoints : ScriptableObject
{
    [HideInInspector] public int tokens;
}
