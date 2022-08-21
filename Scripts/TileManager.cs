using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour
{
    public int RoomAmount;
    public Vector2 StandardRoomSize;

    public static List<DungeonTile> tiles = new List<DungeonTile>();
    
    void Start()
    {
        for(int i = 0; i < RoomAmount; i++)
        {
            RoomManager.GenerateRoom(new Vector2(10, 10), StandardRoomSize);
            //RoomManager.GenerateRoom(pos, Size);
        }    
    }
}
