using UnityEngine;

public class TileCell : MonoBehaviour
{
    public Vector2Int coordinages { get; set; }
    public Tile tile { get; set; }

    public bool empty => tile == null;
    public bool ocuppied => tile != null;
}
