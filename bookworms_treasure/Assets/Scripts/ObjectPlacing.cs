using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Tilemaps;

public class ObjectPlacing : MonoBehaviour
{
    public Tilemap objectsTilemap;

    public TileBase poolTable;
    public TileBase armchair;
    public TileBase bookshelf;

    public bool poolTableButtonClicked = false;
    public bool armchairButtonClicked = false;
    public bool bookshelfButtonClicked = false;
    public bool noObjectToPlace = true;
    public bool deleteObjectMode = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var mouseWorldPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        var cellPos = objectsTilemap.WorldToCell(mouseWorldPos);

        if (poolTableButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            var tileChangeData = new TileChangeData
            {
                position = cellPos,
                tile = poolTable,
                color = Color.white,
                transform = Matrix4x4.Translate(new Vector3(0, 0, 1.0f)),
            };
            objectsTilemap.SetTile(tileChangeData, false);
        }

        if (armchairButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            var tileChangeData = new TileChangeData
            {
                position = cellPos,
                tile = armchair,
                color = Color.white,
                transform = Matrix4x4.Translate(new Vector3(0, 0, 1.0f)),
            };
            objectsTilemap.SetTile(tileChangeData, false);
        }

        if (bookshelfButtonClicked == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            var tileChangeData = new TileChangeData
            {
                position = cellPos,
                tile = bookshelf,
                color = Color.white,
                transform = Matrix4x4.Translate(new Vector3(0, 0, 1.0f)),
            };
            objectsTilemap.SetTile(tileChangeData, false);
        }

        if (deleteObjectMode == true && Mouse.current.leftButton.wasPressedThisFrame)
        {
            var tileChangeData = new TileChangeData
            {
                position = cellPos,
                tile = null,
                color = Color.white,
                transform = Matrix4x4.Translate(new Vector3(0, 0, 0)),
            };
            objectsTilemap.SetTile(tileChangeData, false);
        }
    }

    public void PoolTableButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = true;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
}

    public void ArmchairButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = true;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
    }

    public void BookshelfButton()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = true;
        deleteObjectMode = false;
    }

    public void PlaceNoObject()
    {
        noObjectToPlace = true;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = false;
    }

    public void DeleteObjects()
    {
        noObjectToPlace = false;
        poolTableButtonClicked = false;
        armchairButtonClicked = false;
        bookshelfButtonClicked = false;
        deleteObjectMode = true;
    }
}
