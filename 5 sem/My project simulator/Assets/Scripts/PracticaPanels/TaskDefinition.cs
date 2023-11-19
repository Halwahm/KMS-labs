using System.Globalization;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;

public partial class Tasks : MonoBehaviour
{
    private void Task1()
    {
        switch (state)
        {
            case States.Started:
                taskNowTxt.text = "Задание 1. Запишите в таблицу температуру проводника (свинец).";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.tempValue[0].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
                }
                break;
            case States.Completed:
                inputField.interactable = false;
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
                taskNowTxt.text = "Задание 2. Включите омметр. Запишите в таблицу сопротивление проводника.";
                state = States.Now;
                break;
            case States.Now:
                if (_ohmmetr.ohmmetrState == OmmetrButtonScript.OhmmetrState.On)
                    inputField.interactable = true;
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.resistValue[0].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[0].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000309f / 0.21f;
                        table.densValue[0].text = densityValue.ToString(CultureInfo.InvariantCulture);
                    }
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 3. Включите горелку и нагрейте металл до 90 °С.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = false;
                if (burner.burnerState == BurnerOnScript.BurnerState.On)
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
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
                taskNowTxt.text = "Задание 4. Запишите в таблицу температуру проводника.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = true;
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.tempValue[1].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 5. Запишите в таблицу сопротивление проводника.";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    _newValue.isAddButtonClicked = false;
                    table.resistValue[1].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[1].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000309f / 0.21f;
                        table.densValue[1].text = densityValue.ToString(CultureInfo.InvariantCulture);
                        state = States.Completed;
                    }
                    else
                    {
                        _newValue.isAddButtonClicked = false;
                        state = States.Started;
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
                taskNowTxt.text = "Задание 6. Выключите горелку. Смените металл на алюминий.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = false;
                if (burner.burnerState == BurnerOnScript.BurnerState.Off &&
                    _metallsAnimCl.currMetall == MetallsAnimation.Metalls.Aluminium)
                {
                    state = States.Completed;
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
                taskNowTxt.text = "Задание 7. Запишите в таблицу температуру проводника.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = true;
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.tempValue[2].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 8. Запишите в таблицу сопротивление проводника.";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.resistValue[2].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[2].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000314f / 0.25f;
                        table.densValue[2].text = densityValue.ToString(CultureInfo.InvariantCulture);
                        _newValue.isAddButtonClicked = false;
                        state = States.Completed;
                    }
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
                }
                break;
            case States.Completed:
                inputField.interactable = false;
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
                taskNowTxt.text = "Задание 9. Включите горелку и нагрейте металл до 90 °С. " +
                    "Запишите температуру.";
                if (burner.burnerState == BurnerOnScript.BurnerState.On)
                {
                    inputField.interactable = true;
                    state = States.Now;
                }
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.tempValue[3].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 10. Запишите сопротивление";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.resistValue[3].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[3].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000314f / 0.25f;
                        table.densValue[3].text = densityValue.ToString(CultureInfo.InvariantCulture);
                        _newValue.isAddButtonClicked = false;
                        state = States.Completed;
                    }
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 11. Выключите горелку. Смените металл на железо.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = false;
                if (burner.burnerState == BurnerOnScript.BurnerState.Off &&
                    _metallsAnimCl.currMetall == MetallsAnimation.Metalls.Fe)
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
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
                taskNowTxt.text = "Задание 12. Запишите в таблицу температуру проводника.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = true;
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.tempValue[4].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 13. Запишите в таблицу сопротивление проводника.";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.resistValue[4].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[4].text, NumberStyles.Any, CultureInfo.InvariantCulture, 
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000311f / 0.23f;
                        table.densValue[4].text = densityValue.ToString(CultureInfo.InvariantCulture);
                        _newValue.isAddButtonClicked = false;
                        state = States.Completed;
                    }
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
                }
                break;
            case States.Completed:
                inputField.interactable = false;
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
                taskNowTxt.text = "Задание 14. Включите горелку и нагрейте металл до 90 °С. " +
                    "Запишите температуру.";
                if (burner.burnerState == BurnerOnScript.BurnerState.On)
                {
                    inputField.interactable = true;
                    state = States.Now;
                }
                break;
            case States.Now:
                if (burner.burnerState == BurnerOnScript.BurnerState.On && _newValue.isAddButtonClicked
                    && inputField.text != "")
                {
                    table.tempValue[5].text = inputField.text;
                    inputField.text = "";
                    _newValue.isAddButtonClicked = false;
                    state = States.Completed;
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 15. Запишите сопротивление.";
                state = States.Now;
                break;
            case States.Now:
                if (_newValue.isAddButtonClicked && inputField.text != "")
                {
                    table.resistValue[5].text = inputField.text;
                    inputField.text = "";
                    if (float.TryParse(table.resistValue[5].text, NumberStyles.Any, CultureInfo.InvariantCulture,
                        out float resistanceValue))
                    {
                        float densityValue = resistanceValue * 0.000311f / 0.23f;
                        table.densValue[5].text = densityValue.ToString(CultureInfo.InvariantCulture);
                        _newValue.isAddButtonClicked = false;
                        state = States.Completed;
                    }
                }
                else
                {
                    _newValue.isAddButtonClicked = false;
                    state = States.Started;
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
                taskNowTxt.text = "Задание 16. Выключите горелку и омметр. Можно гулять 😊.";
                state = States.Now;
                break;
            case States.Now:
                inputField.interactable = false;
                if (burner.burnerState == BurnerOnScript.BurnerState.Off && 
                    _ohmmetr.ohmmetrState == OmmetrButtonScript.OhmmetrState.Off)
                {
                    _clearButton.SetActive(true);
                    state = States.Completed;
                    _newValue.isAddButtonClicked = false;
                }
                break;
            case States.Completed:
                table.table.SetActive(true);
                taskNowTxt.text = "Опыт завершен! Нажмите на кнопку 'Clear', чтобы очистить таблицу.";
                inputField.interactable = true;
                state = States.Started;
                currentTask = TasksNums.NULL;
                break;
        }
    }
}