using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonGenerator : MonoBehaviour
{

    Dictionary<int, RoomObject[,]> roomMap = new Dictionary<int, RoomObject[,]>();

    void Start()
    {
        int floors = Random.Range(2, 5);
        for (int i = 0; i < floors; i++)
        {
            roomMap.Add(i, new RoomObject[40,40]);
        }

        //RoomObject[]

    
    
    }




}
