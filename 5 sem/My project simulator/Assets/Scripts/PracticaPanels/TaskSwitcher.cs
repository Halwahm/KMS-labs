using UnityEngine;
using UnityEngine.EventSystems;

public partial class Tasks : MonoBehaviour, IPointerClickHandler
{
    internal enum TasksNums
    {
        NULL,
        FirstTask,
        SecondTask,
        ThirdTask,
        FourthTask,
        FifthTask,
        SixthTask,
        SeventhTask,
        EighthTask,
        NinthTask,
        TenthTask,
        EleventhTask,
        TwelfthTask,
        ThirteenthTask,
        FourteenthTask,
        FifteenthTask,
        SixteenthTask,
    }

    private void Update()
    {
        switch (currentTask)
        {
            case TasksNums.FirstTask:
                Task1();
                break;
            case TasksNums.SecondTask:
                Task2();
                break;
            case TasksNums.ThirdTask:
                Task3();
                break;
            case TasksNums.FourthTask:
                Task4();
                break;
            case TasksNums.FifthTask:
                Task5();
                break;
            case TasksNums.SixthTask:
                Task6();
                break;
            case TasksNums.SeventhTask:
                Task7();
                break;
            case TasksNums.EighthTask:
                Task8();
                break;
            case TasksNums.NinthTask:
                Task9();
                break;
            case TasksNums.TenthTask:
                Task10();
                break;
            case TasksNums.EleventhTask:
                Task11();
                break;
            case TasksNums.TwelfthTask:
                Task12();
                break;
            case TasksNums.ThirteenthTask:
                Task13();
                break;
            case TasksNums.FourteenthTask:
                Task14();
                break;
            case TasksNums.FifteenthTask:
                Task15();
                break;
            case TasksNums.SixteenthTask:
                Task16();
                break;
        }
    }
}
