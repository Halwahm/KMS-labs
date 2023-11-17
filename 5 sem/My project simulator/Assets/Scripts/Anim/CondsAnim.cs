using UnityEngine;

public class CondsAnim : MonoBehaviour
{
    public enum Conductors
    {
        Lead,
        Aluminium,
        Iron
    };
    public Conductors currentConductor;
    public TaskPanel taskPanel;
    public Animator leadAnimation;
    public Animator aluminiumAnimation;
    public Animator ironAnimation;

    private void Start()
    {
        currentConductor = Conductors.Lead;
        taskPanel.selectedCondText.text = "Свинец";
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "Aluminium")
                {
                    leadAnimation.SetInteger("ChosenCond", 1);
                    aluminiumAnimation.SetInteger("ChosenCond", 1);
                    ironAnimation.SetInteger("ChosenCond", 1);
                    currentConductor = Conductors.Aluminium;
                    taskPanel.selectedCondText.text = "Алюминий";
                }
                if (hit.collider.gameObject.name == "Iron")
                {
                    leadAnimation.SetInteger("ChosenCond", 2);
                    aluminiumAnimation.SetInteger("ChosenCond", 2);
                    ironAnimation.SetInteger("ChosenCond", 2);
                    currentConductor = Conductors.Iron;
                    taskPanel.selectedCondText.text = "Железо";
                }
                if (hit.collider.gameObject.name == "Lead")
                {
                    leadAnimation.SetInteger("ChosenCond", 3);
                    aluminiumAnimation.SetInteger("ChosenCond", 3);
                    ironAnimation.SetInteger("ChosenCond", 3);
                    currentConductor = Conductors.Lead;
                    taskPanel.selectedCondText.text = "Свинец";
                }
            }
        }
    }
}