using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PopupViewController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject _view;
    [SerializeField] private Transform targetCamera;
    [SerializeField] private Vector3 cameraPosition;
    [SerializeField] private Vector3 cameraRotation;

    void Start()
    {
        _view.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _view.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _view.SetActive(false);
    }

    public void OnPointerClick()
    {
        targetCamera.position = cameraPosition;
        targetCamera.rotation = Quaternion.Euler(cameraRotation);
    }
}
