using UnityEngine;

public class GameEventManager 
{
    public delegate void tileFunction(GameObject tile);
    public event tileFunction tileSelected;

    public void publishSelectedTile(GameObject tile)
    {
        if(tileSelected != null) { tileSelected(tile); }
    }
}
