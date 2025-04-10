using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ObjectSpawn : MonoBehaviour
{

    //Spawn
    public Tilemap tilemap;
    public GameObject AppleSpawn;
    public int numObjSpawn = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObjects()
    {
        for (int i = 0; i < numObjSpawn; i++)
        {
            Vector3Int celdaRandom = CeldaVacia();
            if (celdaRandom != Vector3Int.zero)
            {
                Vector3 worldPosition = tilemap.CellToWorld(celdaRandom);
                Instantiate(AppleSpawn, worldPosition, Quaternion.identity);
            }
        }
    }
    Vector3Int CeldaVacia()
    {
        // Obtiene todas las posiciones del Tilemap en terminos de celdas 
        BoundsInt terreno = tilemap.cellBounds;

        // Encuentra la fila superior del Tilemap
        int superior = terreno.yMax - 1;

        List<Vector3Int> CeldaVacia = new List<Vector3Int>();

        // Recorre las celdas de la fila superior
        for (int x = terreno.x; x < terreno.xMax; x++)
        {
            Vector3Int PosicionCelda = new Vector3Int(x, superior, 0);
            if (tilemap.GetTile(PosicionCelda) == null)
            {
                CeldaVacia.Add(PosicionCelda);
            }
        }

        // Selecciona una celda vacía aleatoria de la fila superior
        if (CeldaVacia.Count > 0)
        {
            return CeldaVacia[Random.Range(0, CeldaVacia.Count)];
        }

        return Vector3Int.zero; // Retorna cero si no hay celdas vacías en la fila superior
    }
}
