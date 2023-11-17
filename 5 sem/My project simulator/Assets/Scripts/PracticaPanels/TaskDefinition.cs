using System.Globalization;
using UnityEngine;

public partial class Tasks : MonoBehaviour
{
    // Lead
    private void Task1()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 1. Запишите в таблицу температуру проводника (свинец).";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    table.temps[0].text = inputField.text;
                    inputField.text = "";
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.SecondTask;
                break;
        }
    }
    private void Task2()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 2. Запишите в таблицу сопротивление проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    table.resists[0].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[0].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000309f / 0.21f;
                        table.densitys[0].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.ThirdTask;
                break;
        }
    }
    private void Task3()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 3. Включите горелку и нагрейте металл до 90 °С.";
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Full)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.FourthTask;
                break;
        }
    }
    private void Task4()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 4. Запишите в таблицу температуру проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    table.temps[1].text = inputField.text;
                    inputField.text = "";
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.FifthTask;
                break;
        }
    }
    private void Task5()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 5. Запишите в таблицу сопротивление проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                    table.resists[1].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[1].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000309f / 0.21f;
                        table.densitys[1].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.SixthTask;
                break;
        }
    }

    private void Task6()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 6. Выключите горелку. Смените металл на алюминий.";
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Off ||
                    condsAnimClass.currentConductor == CondsAnim.Conductors.Aluminium)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.SeventhTask;
                break;
        }
    }
    private void Task7()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 7. Запишите в таблицу температуру проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                    table.temps[2].text = inputField.text;
                    inputField.text = "";
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.EighthTask;
                break;
        }
    }

    private void Task8()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 8. Запишите в таблицу сопротивление проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    table.resists[2].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[2].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000314f / 0.25f;
                        table.densitys[2].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.NinthTask;
                break;
        }
    }
    private void Task9()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 9. Включите горелку и нагрейте металл до 90 °С. " +
                    "Запишите температуру.";
                addValue.isAddButtonClicked = false;
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Full && addValue.isAddButtonClicked)
                {
                    table.temps[3].text = inputField.text;
                    inputField.text = "";
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.TenthTask;
                break;
        }
    }
    private void Task10()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 10. Запишите сопротивление";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                    table.resists[3].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[3].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000314f / 0.25f;
                        table.densitys[3].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.EleventhTask;
                break;
        }
    }
    private void Task11()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 11. Выключите горелку. Смените металл на железо.";
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Off || 
                    condsAnimClass.currentConductor == CondsAnim.Conductors.Iron)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.TwelfthTask;
                break;
        }
    }
    private void Task12()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 12. Запишите в таблицу температуру проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    table.temps[4].text = inputField.text;
                    inputField.text = "";
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.ThirteenthTask;
                break;
        }
    }
    private void Task13()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 13. Запишите в таблицу сопротивление проводника.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    table.resists[4].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[4].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000311f / 0.23f;
                        table.densitys[4].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.FourteenthTask;
                break;
        }
    }
    private void Task14()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 14. Включите горелку и нагрейте металл до 90 °С. " +
                    "Запишите температуру.";
                addValue.isAddButtonClicked = false;
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Full && addValue.isAddButtonClicked)
                {
                    table.temps[5].text = inputField.text;
                    inputField.text = "";
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.FifteenthTask;
                break;
        }
    }

    private void Task15()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 15. Запишите сопротивление.";
                state = States.Continue;
                break;
            case States.Continue:
                if (addValue.isAddButtonClicked)
                {
                    state = States.Completed;
                    table.resists[5].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resists[5].text, NumberStyles.Any, CultureInfo.InvariantCulture,
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000311f / 0.23f;
                        table.densitys[5].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                state = States.Started;
                currentTask = TasksNums.SixteenthTask;
                break;
        }
    }

    private void Task16()
    {
        switch (state)
        {
            case States.Started:
                groundTaskText.text = "Задание 16. Выключите горелку. Можно гулять 😊.";
                state = States.Continue;
                break;
            case States.Continue:
                if (burner.currentState == BurnerOnScript.BurnerState.Off)
                {
                    state = States.Completed;
                    addValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                table.table.SetActive(true);
                groundTaskText.text = "Опыт завершен! Нажмите на кнопку 'Clear', чтобы очистить таблицу.";
                state = States.Started;
                currentTask = TasksNums.NULL;
                break;
        }
    }
}