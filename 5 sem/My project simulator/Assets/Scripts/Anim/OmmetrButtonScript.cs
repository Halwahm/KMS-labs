using TMPro;
using UnityEngine;

public class OmmetrButtonScript : MonoBehaviour
{
    public Animator _turnOn;
    private bool isClicked = false;
    [SerializeField] private TMP_Text _ohmmetrText;

    public enum OhmmetrState
    {
        Off,
        On
    };
    public OhmmetrState ohmmetrState;

    private float randomValueSmall;

    void Start()
    {
        _turnOn = GetComponent<Animator>();
    }

    private void Awake()
    {
        ohmmetrState = OhmmetrState.Off;
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
            _ohmmetrText.text = randomValueSmall.ToString("F3");
        else
            _ohmmetrText.text = "";

        switch (ohmmetrState)
        {
            case OhmmetrState.Off:
                ohmmetrState = OhmmetrState.On;
                break;

            case OhmmetrState.On:
                ohmmetrState = OhmmetrState.Off;
                break;
        }
    }
}
