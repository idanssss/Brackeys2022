using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static void GenerateRoom(Vector2 pos, Vector2 size)
    {
        GameObject parent = Instantiate(new GameObject(), pos, Quaternion.identity);
        for(int x = 0; x < size.x; x++)
        {
            for(int y = 0; y < size.y; y++)
            {
                Instantiate(ConstantReferences.instance.prefabs[Random.Range(1, ConstantReferences.instance.prefabs.Count - 1)], parent.transform);
            }
        }
    }
}
