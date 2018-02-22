using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MetaCell {
    [SerializeField]
    private int _x;
    [SerializeField]
    private int _y;
    [SerializeField]
    private bool _isWall;

    public static MetaCell CreateMetaCell(Cell cell)
    {
        MetaCell metaCell= new MetaCell();
        metaCell._x = cell.X;
        metaCell._y = cell.Y;
        metaCell._isWall = cell.Contains!=null;
        return metaCell;
    }
}
