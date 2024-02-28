using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Map : MonoBehaviour
{
    public Tilemap tilemap, baseTilemap, adornsTilemap;

    public TileBase[] tile;
    private TextAsset map;
    static public int idMap;
    public int countAdorns, dimensionMap;

    public TileBase[] adornsTile;


    // Start is called before the first frame update
    void Start()
    {
        idMap = 2;
        //map = Resources.Load<TextAsset>($"Map_{idMap}");
        map = Resources.Load<TextAsset>($"Map_{idMap}"); 
        string[] row = map.text.Split('\n');

        for (int i = 0; i < row.Length; i++)
        {
            string[] column = row[i].Split(',');
            int idTile = int.Parse(column[2]);

            Vector3Int position = new Vector3Int(int.Parse(column[0]), int.Parse(column[1]), 0);
            baseTilemap.SetTile(position, tile[7]);
            if (idTile != 7 )
            {
                
                tilemap.SetTile(position, tile[int.Parse(column[2])]);

            }
        }
        generateAdorns();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void generateAdorns()
    {
        for (int i = 0;i < countAdorns; i++)
        {
            Vector3Int position = new Vector3Int(Random.Range(0, dimensionMap), Random.Range(0, dimensionMap), 0);
            int adornTile = Random.Range(0, adornsTile.Length);
            Debug.Log(adornTile.ToString());
            adornsTilemap.SetTile(position, adornsTile[adornTile]);
        }
    }
}
