using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Ship : MonoBehaviour
{
    [Range(0f, 10f)]
    public float travelDuration;

    [Range(0f, 10f)]
    public float shipElevation;

    private GameObject tileCopy;
    private void OnDestroy()
    {
        Game.events.tileSelected -= GetTile;
    }

    private void Start()
    {
        Game.events.tileSelected += GetTile;
    }
    private void Update()
    {
        activateShip();
    }

    public void activateShip()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            CameraController.instance.followTransform = transform;
        }
    }
    public void GetTile(GameObject tile)
    {
        tileCopy = tile;

        Vector3 moveTarget = new Vector3(tile.transform.position.x, tile.transform.position.y + shipElevation, tile.transform.position.z);
        //Vector3 lookTarget = new Vector3(transform.position.x, tile.transform.position.y + transform.position.y, transform.position.z);
        Vector3 lookTarget = tile.transform.position;   

        iTween.MoveTo(gameObject, iTween.Hash("position", moveTarget, "speed", travelDuration, "easeType", "easeInOutQuad", "axis", "y", "looktarget", lookTarget));
    }

    private void CollisionDetection()
    {

    }
}
