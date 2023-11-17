using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class StepsScript : MonoBehaviour, IPointerExitHandler, IPointerClickHandler
{
    private string stepName;
    [SerializeField] private TMP_Text groundText;
    [SerializeField] private TMP_Text TaskText;

    public void OnPointerClick(PointerEventData eventData)
    {
        stepName = gameObject.name.Replace("Step", "");
        switch (stepName)
        {
            case "1":
                groundText.text = "Задание 1. Запишите в таблицу температуру проводника (свинец).";
                TaskText.text = groundText.text;
                break;
            case "2":
                groundText.text = "Задание 2. Запишите в таблицу сопротивление проводника.";
                TaskText.text = groundText.text;
                break;
            case "3":
                groundText.text = "Задание 3. Включите горелку и нагрейте металл до 90 °С.";
                TaskText.text = groundText.text;
                break;
            case "4":
                groundText.text = "Задание 4. Запишите в таблицу температуру проводника.";
                TaskText.text = groundText.text;
                break;
            case "5":
                groundText.text = "Задание 5. Запишите в таблицу сопротивление проводника.";
                TaskText.text = groundText.text;
                break;
            case "6":
                groundText.text = "Задание 6. Выключите горелку. Смените металл на алюминий.";
                TaskText.text = groundText.text;
                break;
            case "7":
                groundText.text = "Задание 7. Запишите в таблицу температуру проводника.";
                TaskText.text = groundText.text;
                break;
            case "8":
                groundText.text = "Задание 8. Запишите в таблицу сопротивление проводника.";
                TaskText.text = groundText.text;
                break;
            case "9":
                groundText.text = "Задание 9. Включите горелку и нагрейте металл до 90 °С. Запишите температуру.";
                TaskText.text = groundText.text;
                break;
            case "10":
                groundText.text = "Задание 10. Запишите сопротивление.";
                TaskText.text = groundText.text;
                break;
            case "11":
                groundText.text = "Задание 11. Выключите горелку. Смените металл на железо.";
                TaskText.text = groundText.text;
                break;
            case "12":
                groundText.text = "Задание 12. Запишите в таблицу температуру проводника.";
                TaskText.text = groundText.text;
                break;
            case "13":
                groundText.text = "Задание 13. Запишите в таблицу сопротивление проводника.";
                TaskText.text = groundText.text;
                break;
            case "14":
                groundText.text = "Задание 14. Включите горелку и нагрейте металл до 90 °С. Запишите температуру.";
                TaskText.text = groundText.text;
                break;
            case "15":
                groundText.text = "Задание 15. Запишите сопротивление.";
                TaskText.text = groundText.text;
                break;
            case "16":
                groundText.text = "Задание 16. Выключите горелку. Можно гулять 😊.";
                TaskText.text = groundText.text;
                break;
            default:
                groundText.text = "";
                TaskText.text = "";
                break;
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        groundText.text = "";
    }
}
