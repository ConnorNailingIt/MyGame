using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

public class Ship : MonoBehaviour
{
    [Range(0f, 1f)]
    public float duration;

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
        if(tileCopy != null) {
            transform.position = Vector3.Lerp(transform.position, tileCopy.transform.position, duration);
            //duration += Time.deltaTime * 0.25f;
        }
        
    }
    public void GetTile(GameObject tile)
    {
        duration = 0f;
        tileCopy = tile;
        //iTween.MoveTo(gameObject, iTween.Hash("position", tileCopy, "speed", duration, "easeType", "easeInOutQuad", "looktarget", tileCopy));
    }
}
