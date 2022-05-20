using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{
    private const float PLAYER_DISTANCE_SPAWN_LEVEL_PART = 200f;

    public Transform wallBegin;
    public Transform wallPrefab;
    public Transform holePrefab;
    public Transform player;

    private Vector3 lastPosition;

    private void Awake()
    {
        lastPosition = wallBegin.Find("End position").position;
        SpawnLevelPart();
        SpawnLevelPart();
    }

    private void Update()
    {
        if(Vector3.Distance(player.position, lastPosition) < PLAYER_DISTANCE_SPAWN_LEVEL_PART)
        {
            SpawnLevelPart();
        }
    }

    private void SpawnLevelPart()
    {
        Transform lastWall = SpawnLevelPart(lastPosition);
        lastPosition = lastWall.Find("End position").position;
    }

    private Transform SpawnLevelPart(Vector3 spawnPosition)
    {
        Transform levelParttransform;
        if (Random.Range(0,10)%2 == 0)
        {
            levelParttransform = Instantiate(wallPrefab, spawnPosition, Quaternion.identity);
        }
        else
        {
            levelParttransform = Instantiate(holePrefab, spawnPosition, Quaternion.identity);
        }
        return levelParttransform;
    }

}
