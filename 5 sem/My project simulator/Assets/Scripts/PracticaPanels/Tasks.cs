using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public partial class Tasks : MonoBehaviour, IPointerClickHandler
{
    private GameObject practicePanel, taskPanel;
    public TMP_Text groundTaskText;
    private AddValueScript addValue;
    private BurnerOnScript burner;
    private CondsAnim condsAnimClass;
    private TMP_InputField inputField;
    public TableScript table;
    public enum States
    {
        Started,
        Continue,
        Completed,
    }
    public States state = States.Started;
    internal TasksNums currentTask = TasksNums.NULL;

    private void Awake()
    {
        practicePanel = GameObject.Find("Panel PraktikaElements");
        taskPanel = GameObject.Find("TaskPanel");
        addValue = GameObject.Find("Write").GetComponent<AddValueScript>();
        burner = GameObject.Find("Button for Burner").GetComponent<BurnerOnScript>();
        condsAnimClass = GameObject.Find("Conductors").GetComponent<CondsAnim>();
        inputField = GameObject.Find("InputField (TMP)").GetComponent<TMP_InputField>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        currentTask = TasksNums.FirstTask;
    }
}
