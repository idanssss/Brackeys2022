using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType
{
    summoner, PlayerSpawner, spike, chest, wall, floor, abyss
}


public class DungeonTile : MonoBehaviour
{
    public TileType type;
    void Awake() => TileManager.tiles.Add(this);
}
