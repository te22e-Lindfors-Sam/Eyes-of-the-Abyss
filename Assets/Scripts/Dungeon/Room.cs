using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Room", menuName = "Rooms", order = 1)]
public class Room : ScriptableObject
{
    public GameObject gameObject;
    public RoomType type;
    public Vector2 size;
}
public class RoomObject
{
    public GameObject gameObject;
    public int id = -1;
    public RoomType type;
    public Vector2 size;
    public Vector3 position;
    public List<RoomObject> links = new List<RoomObject>();

    public List<RoomObject> totalLinks = new List<RoomObject>();

    public RoomObject(GameObject gameObject, int id, RoomType type, Vector2 size, Vector3 position)
    {
        this.gameObject = gameObject;
        this.id = id;
        this.type = type;
        this.size = size;
        this.position = position;
    }

    public RoomObject()
    {
        type = RoomType.None;
    }
}
public enum RoomType { None, Alcehmist, Prison, Libery, TortureChamber, SacrifialAltar, RitualChambers }
