using UnityEngine;
using UnityEngine.UI;

public class TaskPanel : MonoBehaviour
{
    internal Text selectedCondText;

    private void Awake()
    {
        selectedCondText = GameObject.Find("SelectedCond").GetComponent<Text>();
    }
}
