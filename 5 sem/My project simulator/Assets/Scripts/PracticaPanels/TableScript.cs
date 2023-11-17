using UnityEngine.UI;
using UnityEngine;

public class TableScript : MonoBehaviour
{
    [SerializeField] private int resAndTempCount;
    public GameObject table;
    private GameObject[] tableCellsT, TableCellsR, tableCellsD;
    internal Text[] temps, resists, densitys;
    public ShowTable showTable;
    private void Start()
    {
        showTable._table = table;
        tableCellsT = new GameObject[6];
        TableCellsR = new GameObject[6];
        tableCellsD = new GameObject[6];
        for (byte i = 1; i <= resAndTempCount; i++)
        {
            tableCellsT[i - 1] = GameObject.Find("T" + i);
            TableCellsR[i - 1] = GameObject.Find("R" + i);
            tableCellsD[i - 1] = GameObject.Find("D" + i);
        }

        temps = new Text[tableCellsT.Length];
        resists = new Text[TableCellsR.Length];
        densitys = new Text[tableCellsD.Length];
        for (int i = 0; i < tableCellsT.Length; i++)
        {
            temps[i] = tableCellsT[i].GetComponent<Text>();
            resists[i] = TableCellsR[i].GetComponent<Text>();
            densitys[i] = tableCellsD[i].GetComponent<Text>();
        }

        table.SetActive(false);
    }
}
