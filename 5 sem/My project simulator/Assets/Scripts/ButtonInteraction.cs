using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonInteraction : MonoBehaviour
{
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private GameObject[] installationElements; 
    [SerializeField] private string installationInfo;

    private Material highlightMaterial;
    private Material[] originalMaterials;

    [SerializeField] private Transform targetCamera;
    [SerializeField] private Vector3 cameraPosition;
    [SerializeField] private Vector3 cameraRotation;

    private void Start()
    {
        originalMaterials = new Material[installationElements.Length];
        int index = 0;

        foreach (var element in installationElements)
        {
            originalMaterials[index] = element.GetComponent<Renderer>().material;
            index++;
        }
    }

    public void OnPointerEnter()
    {
        infoText.text = installationInfo;
        foreach (var element in installationElements)
        {
            element.GetComponent<Renderer>().material = highlightMaterial;
        }
    }

    public void OnPointerExit()
    {
        int index = 0;
        foreach (var element in installationElements)
        {
            element.GetComponent<Renderer>().material = originalMaterials[index];
            index++;
        }
        infoText.text = "";
    }

    public void OnPointerClick()
    {
        targetCamera.position = cameraPosition;
        targetCamera.rotation = Quaternion.Euler(cameraRotation);
    }
}
