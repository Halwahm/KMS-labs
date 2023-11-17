using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class BurnerOnScript : MonoBehaviour
{
    public Animator _turnOn;
    public Animator _arrowAnimator;

    [SerializeField] private GameObject fire;
    private ParticleSystem ps;

    [SerializeField] private TMP_Text OhmmetrText;

    private float randomValueSmall;
    private float randomValueBig;

    private bool isClicked = false;

    void Start()
    {
        AnimationEvent animationEvent = new AnimationEvent();
        animationEvent.functionName = "OnButtonAnimationComplete";
        _turnOn.GetComponent<Animation>().clip.AddEvent(animationEvent);
    }
    
    private void OnButtonAnimationComplete()
    {
        if (_arrowAnimator != null)
        {
            _arrowAnimator.SetBool("StopArrowAnimation", false);
            _arrowAnimator.SetTrigger("StartArrowAnimation");
        }
    }

    public enum BurnerState
    {
        Off = 12,
        Full = 90
    };
    public BurnerState currentState/*, prevState*/;
    private void Awake()
    {
        ps = fire.GetComponent<ParticleSystem>();
        currentState = BurnerState.Off;
        DeactivateFire();
    }

    private void ActivateFire()
    {
        ps.Play();
    }

    private void DeactivateFire()
    {
        ps.Stop();
        ps.Clear();
    }


    public void OnMouseDown()
    {
        bool currentClickedState = _turnOn.GetBool("isClicked");
        _turnOn.SetBool("isClicked", !currentClickedState);

        isClicked = !isClicked;
        if (isClicked)
            OhmmetrText.text = randomValueBig.ToString("F3");
        else
            OhmmetrText.text = randomValueSmall.ToString("F3");

        if (_arrowAnimator != null)
        {
            _arrowAnimator.StopPlayback();
        }

        switch (currentState)
        {
            case BurnerState.Off:
                //prevState = currentState;
                currentState = BurnerState.Full;
                ActivateFire();
            break;

            case BurnerState.Full:
                //prevState = currentState;
                currentState = BurnerState.Off;
                DeactivateFire();
                if (_arrowAnimator != null)
                {
                    _arrowAnimator.SetBool("StopArrowAnimation", true);
                }
            break;
        }
    }

    private void Update()
    {
        randomValueBig = Random.Range(0.231f, 0.568f);
        randomValueSmall = Random.Range(0.003f, 0.017f);
    }
}
