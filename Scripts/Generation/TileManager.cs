using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int RoomAmount;
    public Vector2 StandardRoomSize;

    private static List<DungeonTile> tiles = new List<DungeonTile>();
    public static void AddTile(DungeonTile tile) => tiles.Add(tile);
    public static void ClearTiles()
    {
        Utility.DestroyAll(tiles);
        tiles.Clear();
    }

    void Start()
    {
        for(int i = 0; i < RoomAmount; i++)
        {
            RoomManager.GenerateRoom(new Vector2(Random.Range(0, 10000), Random.Range(0, 100)), StandardRoomSize);
            //RoomManager.GenerateRoom(pos, Size);
        }    
    }
}
