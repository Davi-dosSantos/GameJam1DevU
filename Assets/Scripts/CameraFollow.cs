using System;
using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{
    public PlayerControl player;

    private Vector3 lastPlayerPosition;
    private float distanceToMove;

    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
        lastPlayerPosition = player.transform.position;
    }

    void Update()
    {
        distanceToMove = player.transform.position.x - lastPlayerPosition.x;

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);
        lastPlayerPosition = player.transform.position;

    }
}
