using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class CreateField : MonoBehaviour
{

    public int columns;
    public int rows;
    public GameObject Cell;
    public GameObject GameField;
    public GameObject Wall;
    private List<Cell> Cells = new List<Cell>();

    public void Save()
    {
        
    }

    void Start()
    {
        CreateGameField();
        MetaField metaField = MetaField.CreateMetaField(columns, rows, Cells);

        using (FileStream fs = new FileStream("field.json", FileMode.OpenOrCreate))
        {
            string json = MetaField.Serialize(metaField);
            byte[] info = new UTF8Encoding(true).GetBytes(json);
            fs.Write(info, 0, info.Length);

        }
    }

    void CreateGameField()
    {
        if (columns <= 3 && rows <= 3)
        {
            return;
        }
        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                var cell = Instantiate(Cell, new Vector2(i, -j), Quaternion.identity, GameField.transform).GetComponent<Cell>();
                Cells.Add(cell);
                var wall = Instantiate(Wall, Vector3.zero, Quaternion.identity);
                var rand = Random.value;
                if (i == 0 || j == 0 || i == columns - 1 || j == rows - 1 || rand <= 0.3f)
                {
                    cell.Init(wall, i, j);
                }
                else
                {
                    cell.Init(null, i, j);
                }
            }
        }
    }



    void Update()
    {

    }

}