using UnityEngine;
using UnityEngine.EventSystems;

public class AddValueScript : MonoBehaviour, IPointerClickHandler
{
    public bool isAddButtonClicked = false;
    public Tasks tasks;

    private void Awake()
    {
        tasks = GameObject.Find("Panel Praktika").GetComponent<Tasks>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (tasks.currentTask == Tasks.TasksNums.NULL) return;
        isAddButtonClicked = true;
    }
}
