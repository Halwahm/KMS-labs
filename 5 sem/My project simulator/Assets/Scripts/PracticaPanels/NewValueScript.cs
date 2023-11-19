using UnityEngine;
using UnityEngine.EventSystems;

public class NewValueScript : MonoBehaviour, IPointerClickHandler
{
    internal bool isAddButtonClicked = false;
    private Tasks _tasks;

    private void Awake()
    {
        _tasks = GameObject.Find("Panel Praktika").GetComponent<Tasks>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (_tasks.currentTask == Tasks.TasksNums.NULL) return;
        isAddButtonClicked = !isAddButtonClicked;
    }
}
