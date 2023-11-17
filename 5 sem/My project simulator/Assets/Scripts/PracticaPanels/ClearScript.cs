using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClearScript : MonoBehaviour, IPointerClickHandler
{
    internal GameObject table;
    private GameObject[] tableCellsT, TableCellsR;
    public TaskPanel taskPanel;
    public Tasks tasks;

    private void Awake()
    {
        table = GameObject.Find("Table");
        tableCellsT = GameObject.FindGameObjectsWithTag("Temperature");
        TableCellsR = GameObject.FindGameObjectsWithTag("Resistance");
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        for (int i = 0; i < TableCellsR.Length; i++)
        {
            tableCellsT[i].GetComponent<Text>().text = "-";
            TableCellsR[i].GetComponent<Text>().text = "-";
            tasks.state = Tasks.States.Started;
            tasks.currentTask = Tasks.TasksNums.NULL;
        }
    }
}
