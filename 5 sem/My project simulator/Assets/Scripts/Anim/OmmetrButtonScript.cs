using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OmmetrButtonScript : MonoBehaviour
{
    public Animator _turnOn;
    private bool isClicked = false;
    [SerializeField] private TMP_Text OhmmetrText;

    private float randomValueSmall;

    void Start()
    {
        _turnOn = GetComponent<Animator>();
    }

    private void Update()
    {
        randomValueSmall = Random.Range(0.003f, 0.017f);
    }

    public void OnMouseDown()
    {
        bool currentClickedState = _turnOn.GetBool("isClicked");
        _turnOn.SetBool("isClicked", !currentClickedState);

        isClicked = !isClicked;

        if (isClicked)
            OhmmetrText.text = randomValueSmall.ToString("F3");
        else
            OhmmetrText.text = "";
    }
}
