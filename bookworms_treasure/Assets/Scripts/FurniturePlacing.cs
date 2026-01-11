using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.InputSystem;

public class FurniturePlacing : MonoBehaviour
{
    public Tilemap objectsTilemap;
    public TileBase poolTableTile;

    public void PlacePoolTable()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector3Int cellPos = objectsTilemap.WorldToCell(mousePosition);
        objectsTilemap.SetTile(cellPos, poolTableTile);
    }

    public void EraseObjects()
    {
        Vector2 mousePosition = Mouse.current.position.ReadValue();
        Vector3Int cellPos = objectsTilemap.WorldToCell(mousePosition);
        objectsTilemap.SetTile(cellPos, null);
    }
}
