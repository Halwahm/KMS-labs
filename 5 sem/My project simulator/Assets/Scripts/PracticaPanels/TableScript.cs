using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class TableScript : MonoBehaviour
{
    [SerializeField] private int fill;
    [SerializeField] internal GameObject table;
    private GameObject[] _tempCells, _resistCells, _densCells;
    internal List<Text> tempValue = new List<Text>();
    internal List<Text> resistValue = new List<Text>();
    internal List<Text> densValue = new List<Text>();
    public ShowTable showTable;

    private void Start()
    {
        showTable._table = table;
        _tempCells = new GameObject[6];
        _resistCells = new GameObject[6];
        _densCells = new GameObject[6];
        for (byte i = 1; i <= fill; i++)
        {
            _tempCells[i - 1] = GameObject.Find("T" + i);
            _resistCells[i - 1] = GameObject.Find("R" + i);
            _densCells[i - 1] = GameObject.Find("D" + i);
        }

        foreach (GameObject tempCell in _tempCells)
        {
            Text tempText = tempCell.GetComponent<Text>();
            if (tempText != null)
            {
                tempValue.Add(tempText);
            }
        }

        foreach (GameObject resistCell in _resistCells)
        {
            Text resistText = resistCell.GetComponent<Text>();
            if (resistText != null)
            {
                resistValue.Add(resistText);
            }
        }

        foreach (GameObject densCell in _densCells)
        {
            Text densText = densCell.GetComponent<Text>();
            if (densText != null)
            {
                densValue.Add(densText);
            }
        }

        table.SetActive(false);
    }
}
