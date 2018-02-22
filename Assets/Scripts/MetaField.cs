using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MetaField {
    [SerializeField]
    private List<MetaCell> _field = new List<MetaCell>();
    [SerializeField]
    private int _columns, _rows;


    public static string Serialize(MetaField field)
    {
        string json = JsonUtility.ToJson(field);
        return json;
    }

    public static MetaField Deserialize(string json)
    {
        MetaField field = JsonUtility.FromJson<MetaField>(json);
        return field;
    }

    public static MetaField CreateMetaField(int cols, int rows, List<Cell> cells)
    {
        MetaField field = new MetaField();
        field._columns = cols;
        field._rows = rows;
        for (int i = 0; i < cells.Count; i++)
        {
           field._field.Add(MetaCell.CreateMetaCell(cells[i]));
        }
        return field;
    }
    
}
