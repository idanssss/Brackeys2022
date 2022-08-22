using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    Summoner, PlayerSpawner, Spike, Chest, Wall, Floor, Abyss
}


public class DungeonTile : MonoBehaviour
{
    [SerializeField]
    private TileType type;

    private void Awake() =>
     TileManager.AddTile(this);
}
